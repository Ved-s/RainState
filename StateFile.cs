using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using RainState.Tags;

namespace RainState
{
    class StateFile
    {
        static Regex ChecksumRegex = new(@"^[0-9a-fA-F]{32}", RegexOptions.Compiled);
        static byte[] ChecksumSalt = Encoding.UTF8.GetBytes("WY+Nhg+PuYNEz6WVOo9DpOoPZ11fT3DuTU9WigSP9yeKT8U+EQ/EghqPxKqbj8AAIA/pihwPzuncT9L2XI/In50PzpJdj9D4n");

        public StateFile? CurrentFile;

        public bool HasChecksum;
        public Tag MainTag;

        public StateFile(Tag mainTag, bool hasChecksum)
        {
            MainTag = mainTag;
            HasChecksum = hasChecksum;
        }

        public static StateFile? Load(string data)
        {
            bool checksum = ChecksumRegex.IsMatch(data);
            Tag? tag = Tag.ReadTag(data, checksum ? 32 : 0);

            if (tag is null)
                return null;

            return new(tag, checksum);
        }

        public void Save(Stream stream) 
        {
            if (!HasChecksum)
            {
                MainTag.Serialize(new(stream, encoding: Encoding.UTF8, leaveOpen: true));
                return;
            }

            MemoryStream ms = new();
            MainTag.Serialize(new(ms, encoding: Encoding.UTF8, leaveOpen: true));
            ms.Position = 0;
            string checksum = CalculateChecksum(ms.GetBuffer(), 0, (int)ms.Length);

            using (StreamWriter writer = new(stream, encoding: Encoding.UTF8, leaveOpen: true))
            {
                writer.Write(checksum);
            }
            ms.Position = 0;
            ms.CopyTo(stream);
        }

        static string CalculateChecksum(byte[] data, int offset, int count)
        {
            IncrementalHash md5 = IncrementalHash.CreateHash(HashAlgorithmName.MD5);

            md5.AppendData(data, offset, count);
            md5.AppendData(ChecksumSalt);
            
            byte[] hash = md5.GetHashAndReset();

            return Convert.ToHexString(hash).ToLower();
        }
    }
}
