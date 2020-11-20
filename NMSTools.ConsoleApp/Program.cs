using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace NMSTools.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static async Task<byte[]> DecryptAsync(byte[] value, byte[] iv, byte[] systemKey)
        {
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(iv, systemKey, 16000))
            {
                var keyBytes = keyDerivationFunction.GetBytes(32);
                var ivBytes = keyDerivationFunction.GetBytes(16);

                using (var outputStream = new MemoryStream())
                {
                    using (var inputStream = new MemoryStream(value))
                    using (var aesCypher = new AesManaged())
                    using (var decryptor = aesCypher.CreateDecryptor(keyBytes, ivBytes))
                    using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                        await cryptoStream.CopyToAsync(outputStream);

                    return outputStream.ToArray();
                }
            }
        }
    }
}
