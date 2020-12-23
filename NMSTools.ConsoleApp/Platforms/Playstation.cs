using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using K4os.Compression.LZ4;

namespace NMSTools.ConsoleApp.Platforms
{
    public static class Extenions
    {
       
    }
    public class Playstation
    {
		private static class PS4
		{
			public const int MetaSize = 48;
			public const int MetaStart = 64;
        }



        public static void ReadMeta(string metaPath)
		{
			byte[] meta = File.ReadAllBytes(metaPath);
			Console.WriteLine(meta.Length);

		}

		private static class LZ4
        {
			public static int Encode(byte[] source, out byte[] target, int sourceOffset = 0, int targetOffset = 0, LZ4Level level = LZ4Level.L00_FAST)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				target = new byte[LZ4Codec.MaximumOutputSize(source.Length)];
				int result = LZ4Codec.Encode(source, sourceOffset, source.Length, target, targetOffset, target.Length, level);
				target = target.Take(result).ToArray<byte>();
				return result;
			}

			// Token: 0x06000031 RID: 49 RVA: 0x00002738 File Offset: 0x00000938
			public static int Decode(byte[] source, out byte[] target, int knownTargetLength, int sourceOffset = 0, int targetOffset = 0)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				target = new byte[knownTargetLength];
				int result = LZ4Codec.Decode(source, sourceOffset, source.Length, target, targetOffset, target.Length);
				if (result < 0)
				{
					target = new byte[source.Length * 255];
					result = LZ4Codec.Decode(source, sourceOffset, source.Length, target, targetOffset, target.Length);
				}
				return result;
			}
		}


        public static int DecompressData(ref byte[] data, out byte[] result) 
			=> LZ4.Decode(data, out result, 0, 0, 0);

        public static int CompressData(ref byte[] data, out byte[] result) 
			=> LZ4.Encode(data, out result, 0, 0, LZ4Level.L00_FAST);
    }
}
