using RainState.Tags;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RainState
{
    public class StateFile
    {
        static byte[] NewSavePrefix =  new UTF8Encoding().GetBytes(@"<ArrayOfKeyValueOfanyTypeanyType xmlns:i=""http://www.w3.org/2001/XMLSchema-instance"" xmlns=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><KeyValueOfanyTypeanyType><Key xmlns:d3p1=""http://www.w3.org/2001/XMLSchema"" i:type=""d3p1:string"">save</Key><Value xmlns:d3p1=""http://www.w3.org/2001/XMLSchema"" i:type=""d3p1:string"">");
        static byte[] NewSavePostfix = new UTF8Encoding().GetBytes(@"</Value></KeyValueOfanyTypeanyType></ArrayOfKeyValueOfanyTypeanyType>");

        static Regex ChecksumRegex = new(@"^[0-9a-fA-F]{32}", RegexOptions.Compiled);
        static byte[] ChecksumSalt = Encoding.UTF8.GetBytes("WY+Nhg+PuYNEz6WVOo9DpOoPZ11fT3DuTU9WigSP9yeKT8U+EQ/EghqPxKqbj8AAIA/pihwPzuncT9L2XI/In50PzpJdj9D4n");

        public StateFile? CurrentFile;

        public bool HasChecksum;
        public NewFormatNamedTag? NewFormatTag;
        public Tag MainTag;

        public StateFile(Tag mainTag, bool hasChecksum, NewFormatNamedTag? newFormatTag)
        {
            MainTag = mainTag;
            HasChecksum = hasChecksum;
            NewFormatTag = newFormatTag;
        }

        public static StateFile? Load(string data, Func<IEnumerable<string>, string?>? newFormatNameSelector = null)
        {
            int zeroIndex = data.IndexOf('\0');
            if (zeroIndex >= 0)
                data = data.Substring(0, zeroIndex);

            NewFormatNamedTag? newFormatTag = null;
            if (data.StartsWith("<ArrayOfKeyValueOfanyTypeanyType"))
            {
                XDocument xml = XDocument.Parse(data);

                if (xml.Root is not null)
                {
                    XName keyName = XName.Get("Key", xml.Root.Name.Namespace.NamespaceName);
                    XName valueName = XName.Get("Value", xml.Root.Name.Namespace.NamespaceName);

                    Dictionary<string, XElement> saves = new();

                    foreach (XElement element in xml.Root.Elements())
                    {
                        XElement? key = element.Element(keyName);
                        XElement? value = element.Element(valueName);

                        if (key is not null && value is not null)
                            saves[key.Value] = value;
                    }
                    string? name = newFormatNameSelector is null ? saves.Keys.FirstOrDefault() : newFormatNameSelector.Invoke(saves.Keys);
                    if (name is null || !saves.TryGetValue(name, out XElement? saveElement))
                        return null;

                    newFormatTag = new(name, saveElement);
                    data = saveElement.Value;
                }
            }

            bool checksum = ChecksumRegex.IsMatch(data);
            Tag? tag = Tag.ReadTag(data, checksum ? 32 : 0);

            if (tag is null)
                return null;

            return new(tag, checksum, newFormatTag);
        }

        public void Save(Stream stream)
        {
            StringBuilder builder = SaveInternal();
            UTF8Encoding encoding = new();

            if (NewFormatTag is null)
            {
                int maxchunksize = 0;
                foreach (ReadOnlyMemory<char> chars in builder.GetChunks())
                    maxchunksize = Math.Max(maxchunksize, chars.Length);

                Span<byte> bytes = stackalloc byte[maxchunksize * 2];

                foreach (ReadOnlyMemory<char> chars in builder.GetChunks())
                {
                    int count = encoding.GetBytes(chars.Span, bytes);
                    stream.Write(bytes.Slice(0, count));
                }

                return;
            }

            NewFormatTag.Value.Value = builder.ToString();

            // https://stackoverflow.com/a/16681276/13645088
            XmlWriterSettings xws = new XmlWriterSettings { OmitXmlDeclaration = true };
            XmlWriter writer = XmlWriter.Create(stream, xws);
            NewFormatTag.Value.Document!.Save(writer);
            writer.Flush();
        }

        StringBuilder SaveInternal()
        {
            StringBuilder builder = new();

            MainTag.Serialize(builder);
            if (HasChecksum)
            {
                string checksum = CalculateChecksum(builder);
                builder.Insert(0, checksum);
            }

            return builder;
        }

        static string CalculateChecksum(StringBuilder builder)
        {
            IncrementalHash md5 = IncrementalHash.CreateHash(HashAlgorithmName.MD5);
            UTF8Encoding encoding = new();

            int maxchunksize = 0;
            foreach (ReadOnlyMemory<char> chars in builder.GetChunks())
            {
                maxchunksize = Math.Max(maxchunksize, chars.Length);
            }

            Span<byte> bytes = stackalloc byte[maxchunksize * 2];

            foreach (ReadOnlyMemory<char> chars in builder.GetChunks())
            {
                int count = encoding.GetBytes(chars.Span, bytes);
                md5.AppendData(bytes.Slice(0, count));
            }

            md5.AppendData(ChecksumSalt);

            byte[] hash = md5.GetHashAndReset();

            return Convert.ToHexString(hash).ToLower();
        }

        static void CopyAndHtmlEncode(Stream src, Stream dest)
        {
            byte gt = (byte)'>';
            byte lt = (byte)'<';

            byte[] gtRepl = Encoding.ASCII.GetBytes("&gt;");
            byte[] ltRepl = Encoding.ASCII.GetBytes("&lt;");

            byte[] buffer = new byte[1024];

            while (true)
            {
                int read = src.Read(buffer, 0, buffer.Length);

                if (read <= 0)
                    break;

                int prevCharIdx = 0;
                for (int i = 0; i < read; i++)
                {
                    byte b = buffer[i];
                    if ((b == lt || b == gt) && i > prevCharIdx)
                    {
                        dest.Write(buffer, prevCharIdx, i - prevCharIdx);
                    }

                    if (b == lt)
                    {
                        prevCharIdx = i + 1;
                        dest.Write(ltRepl);
                    }

                    if (b == gt)
                    {
                        prevCharIdx = i + 1;
                        dest.Write(gtRepl);
                    }

                }
                if (prevCharIdx < read)
                    dest.Write(buffer, prevCharIdx, read - prevCharIdx);
            }
        }

        public record NewFormatNamedTag(string Key, XElement Value);
    }
}
