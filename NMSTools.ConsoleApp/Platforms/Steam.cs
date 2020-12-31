using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using SpookilySharp;

namespace NMSTools.ConsoleApp.Platforms
{
    public static class Steam
    {
        private static byte[] ComputeHash(byte[] buffer)
        {
            byte[] result;
            using (var sha256 = new SHA256Managed())
            {
                result = sha256.ComputeHash(buffer);
            }
            return result;
        }

        public static List<uint> ConvertByteToUInt32(byte[] data)
        {
            List<uint> result = new List<uint>();
            if (data != null)
            {
                using (BinaryReader reader = new BinaryReader(new MemoryStream(data)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        result.Add(reader.ReadUInt32());
                    }
                }
            }
            return result;
        }

        public static byte[] ConvertUInt32ToByte(IEnumerable<uint> data)
        {
            return data.SelectMany(new Func<uint, IEnumerable<byte>>(BitConverter.GetBytes)).ToArray<byte>();
        }

        private static List<uint> GetKey(uint metaIndex)
        {
            uint h = RotateLeft(metaIndex ^ 337824652U, 13) * 5U + 3864292196U;
            byte[] input = Encoding.ASCII.GetBytes("NAESEVADNAYRTNRG");
            for (int i = 0; i < 4; i++)
            {
                input[i] = (byte)(h >> i * 8);
            }
            return ConvertByteToUInt32(input);
        }

        private static uint RotateLeft(uint value, int bits)
        {
            return value << bits | value >> 32 - bits;
        }

        public static Metadata BuildMeta(string saveFile)
        {
            byte[] raw = File.ReadAllBytes(saveFile);

            var sha256 = ComputeHash(raw);
            var spookyHash = new SpookyHash(96176015842230784UL, 9999999999999999999UL);

            spookyHash.Update(sha256);
            spookyHash.Update(raw);
            spookyHash.Final(out ulong hash0, out ulong hash1);

            return new Metadata { SHA256 = sha256, Hash = new ulong[] { hash0, hash1 } };
        }

        public static void WriteMeta(ref Metadata meta, string outputFile)
        {
            byte[] metaBuffer = new byte[104];
            using (BinaryWriter writer = new BinaryWriter(new MemoryStream(metaBuffer)))
            {
                writer.Write(4008636094U);
                writer.Write(2001);
                writer.Write(meta.Hash[0]);
                writer.Write(meta.Hash[1]);
                writer.Write(meta.SHA256);
            }

            List<uint> data = ConvertByteToUInt32(metaBuffer);
            List<uint> key = GetKey(2);

            uint hash = 0U;
            uint cur = 0U;

            for (int itr = 0; itr < 8; itr++)
            {
                hash += 2654435769U;
                int key_idx = (int)(hash >> 2 & 3U);
                int idx = 0;
                int itr2 = 0;
                uint tmp;
                List<uint> list;
                int index;

                while (itr2 < 25)
                {
                    tmp = (data[idx + 1] >> 3 ^ cur << 4) + (data[idx + 1] * 4U ^ cur >> 5);
                    tmp ^= (cur ^ key[(itr2 & 3) ^ key_idx]) + (data[idx + 1] ^ hash);
                    list = data;
                    index = idx;
                    list[index] += tmp;
                    cur = data[idx];
                    itr2++;
                    idx++;
                }

                tmp = (data[0] >> 3 ^ cur << 4) + (data[0] * 4U ^ cur >> 5);
                tmp ^= (cur ^ key[key_idx ^ 1]) + (data[0] ^ hash);
                list = data;
                index = data.Count - 1;
                list[index] += tmp;
                cur = data[data.Count - 1];
            }

            File.WriteAllBytes(outputFile, ConvertUInt32ToByte(data));

        }

        public static Metadata GetMeta(string metaFile)
        {
            var rawMeta = File.ReadAllBytes(metaFile);

            List<uint> data = ConvertByteToUInt32(rawMeta);
            List<uint> key = GetKey(2);
            uint hash = 4055616968U;

            for (int itr = 0; itr < 8; itr++)
            {
                uint cur = data[0];
                int idx = data.Count - 1;
                int key_idx = (int)(hash >> 2 & 3U);
                int itr2 = 25;
                uint tmp;
                List<uint> list;

                while (itr2 > 0)
                {
                    tmp = (cur >> 3 ^ data[idx - 1] << 4) + (cur * 4U ^ data[idx - 1] >> 5);
                    tmp ^= (data[idx - 1] ^ key[(itr2 & 3) ^ key_idx]) + (cur ^ hash);
                    list = data;
                    int index = idx;
                    list[index] -= tmp;
                    cur = data[idx];
                    itr2--;
                    idx--;
                }

                idx = data.Count - 1;
                tmp = ((cur >> 3 ^ data[idx] << 4) + (cur * 4U ^ data[idx] >> 5) & uint.MaxValue);
                tmp ^= ((data[idx] ^ key[key_idx]) + (cur ^ hash) & uint.MaxValue);
                list = data;
                list[0] = list[0] - tmp;
                hash += 1640531527U;
            }

            if (data[0] != 4008636094U)
            {
                throw new InvalidDataException("Invalid header of meta file.");
            }

            if (data[1] != 2001U)
            {
                throw new InvalidDataException("Invalid or unsupported format in header of meta file.");
            }

            if (rawMeta.Count<byte>() != 104L)
            {
                throw new InvalidDataException(string.Format("Invalid meta file. Expected a file of size {0}.", 104U));
            }

            var dataHash = data.Skip(2).Take(4).ToArray();
            var sha256 = data.Skip(6).Take(8).SelectMany(new Func<uint, IEnumerable<byte>>(BitConverter.GetBytes)).ToArray();
            var spookHash = new ulong[]
            {
                (ulong)dataHash[1] << 32 | dataHash[0],
                (ulong)dataHash[3] << 32 | dataHash[2]
            };

            return new Metadata { SHA256 = sha256, Hash = spookHash };
        }

        public static void TestHash(ref Metadata meta, string dataFile)
        {
            var data = File.ReadAllBytes(dataFile);
            var dataSha256 = ComputeHash(data);

            if (dataSha256 == null || meta.SHA256 == null || !meta.SHA256.SequenceEqual(dataSha256))
                throw new Exception("Invalid SHA256 hash. Corrupt or wrong file?");

            var spookyHash2 = new SpookyHash(96176015842230784UL, 9999999999999999999UL);

            spookyHash2.Update(dataSha256);
            spookyHash2.Update(data);
            spookyHash2.Final(out ulong hash, out ulong hash2);

            if (meta.Hash[0] != hash || meta.Hash[1] != hash2)
                throw new Exception("Invalid SpookyHash. Corrupt or wrong file?");
        }
    }
}
