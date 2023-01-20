using RainState.Tags;
using System;
using System.Buffers;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        public bool NewFormat;
        public Tag MainTag;

        public StateFile(Tag mainTag, bool hasChecksum, bool newFormat)
        {
            MainTag = mainTag;
            HasChecksum = hasChecksum;
            NewFormat = newFormat;
        }

        public static StateFile? Load(string data)
        {
            bool newFormat = false;
            if (data.StartsWith("<ArrayOfKeyValueOfanyTypeanyType"))
            {
                int valueIndex = data.IndexOf(">save</Key><Value");
                if (valueIndex >= 0)
                {
                    int dataStart = data.IndexOf('>', valueIndex+19);
                    if (dataStart >= 0)
                    {
                        int dataEnd = data.IndexOf("</Value>");
                        if (dataEnd >= 0)
                        {
                            newFormat = true;
                            data = WebUtility.HtmlDecode(data.Substring(dataStart + 1, dataEnd - dataStart - 1));
                        }
                    }
                }
                if (!newFormat && MessageBox.Show("File appears to be corrupted. Continue loading?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return null;
            }

            bool checksum = ChecksumRegex.IsMatch(data);
            Tag? tag = Tag.ReadTag(data, checksum ? 32 : 0);

            if (tag is null)
                return null;

            return new(tag, checksum, newFormat);
        }

        public void Save(Stream stream)
        {
            if (NewFormat)
                stream.Write(NewSavePrefix);

            MemoryStream ms = new();
            StreamWriter writer = new(ms, encoding: new UTF8Encoding(), leaveOpen: true)
            {
                AutoFlush = true
            };

            MainTag.Serialize(writer);
            ms.Position = 0;

            if (HasChecksum)
            {
                string checksum = CalculateChecksum(ms.GetBuffer(), 0, (int)ms.Length);
                using (writer = new(stream, encoding: new UTF8Encoding(), leaveOpen: true) { AutoFlush = true })
                {
                    writer.Write(checksum);
                }
            }
            ms.Position = 0;
            if (NewFormat)
            {
                CopyAndHtmlEncode(ms, stream);
                stream.Write(NewSavePostfix);
            }
            else ms.CopyTo(stream);
        }

        static string CalculateChecksum(byte[] data, int offset, int count)
        {
            IncrementalHash md5 = IncrementalHash.CreateHash(HashAlgorithmName.MD5);

            md5.AppendData(data, offset, count);
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
    }
}
