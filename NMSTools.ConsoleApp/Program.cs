using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using libMBIN;
using Newtonsoft.Json;
using SpookilySharp;

namespace NMSTools.ConsoleApp
{
    using Framework.Converters;
    using Platforms;
   
    class Program
    {
        public const string pcBanksDir = "D:\\NMSData\\PCBANKS";
        public const string mBinDir = "D:\\NMSData\\MBIN";
        public const string eXMLDir = "D:\\NMSData\\EXML";

        public const string saveFile = "D:\\NMSProjects\\Archives\\Misc\\save.hg";
        public const string metaFile = "D:\\NMSProjects\\Archives\\Misc\\mf_save.hg";
        
        public const string randomSaveFile = "D:\\NMSProjects\\Archives\\Misc\\save.nmseditor.hg";
        public const string randomMetaFile = "D:\\NMSProjects\\Archives\\Misc\\mf_save.nmseditor.hg";

        public const string ps4SaveFile = "D:\\NMSProjects\\Archives\\Misc\\5c034a628ee6353c\\CUSA04841\\sce_sdmemory";
        public const string ps4MetaFile = "D:\\NMSProjects\\Archives\\Misc\\5c034a628ee6353c\\CUSA04841\\sce_sdmemory.bin";

        public class Metadata
        {
            public byte[] SHA256 { get; set; }
            public ulong[] Hash { get; set; }
        }

        public struct SaveContainer
        {
            public string Meta { get; set; }

            public string Data { get; set; }

            public int Index { get; set; }

            public int SaveType { get; set; }
        }
        static void Main(string[] args)
        {
            
            Playstation.ReadMeta(ps4MetaFile);


            Console.WriteLine();
            Console.WriteLine("Program Complete");
            Console.Read();
        }

        public static bool RunHashTest(string saveFile, string metaFile)
        {
            bool result = true;

            try
            {
                Console.WriteLine("Save File: {0}", saveFile);
                Console.WriteLine("Meta File: {0}", metaFile);
                var testMetaFile = Path.Combine(Path.GetDirectoryName(saveFile), "mf_saveTest.hg");


                var testMeta = BuildMeta(saveFile);

                WriteMeta(ref testMeta, testMetaFile);

                var meta = GetMeta(testMetaFile);

                TestHash(ref meta, saveFile);
            }
            catch
            {
                result = false;
            }
            finally
            {
                Console.Write("Test Results: ");
                Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine(result ? "Pass" : "Fail");
                Console.WriteLine();
                Console.ResetColor();
            }

            return result;
        }


        public static Metadata BuildMeta(string saveFile)
        {
            byte[] raw = File.ReadAllBytes(saveFile);

            var sha256 = ComputeHash(raw);
            var spookyHash = new SpookyHash(96176015842230784UL, 9999999999999999999UL);

            spookyHash.Update(sha256);
            spookyHash.Update(raw);
            spookyHash.Final(out ulong hash0, out ulong hash1);

            return new Metadata { SHA256 = sha256, Hash = new ulong[] { hash0, hash1 }};
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
        
        static void FindOtherFiles()
        {
            using var outputFile = File.Create("C:\\Users\\dhr\\Desktop\\output.txt");
            using var sw = new StreamWriter(outputFile);

            var dirInfo = new DirectoryInfo(mBinDir);
            var files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (var group in files.Where(i => i.Extension.Length > 0).GroupBy(i => i.Extension).OrderByDescending(i => i.Count()))
            {
                sw.WriteLine(string.Format("{0} ({1})", group.Key, group.Count()));
            }
        }

        static void Serialize<T>(T value, string filename)
        {
            FileStream outputFile = default;
            StreamWriter sw = default;
            JsonTextWriter jtw = default;
            JsonSerializer serializer = default;

            try
            {
                serializer = new JsonSerializer();
                serializer.Converters.Add(new DoubleConverter());
                serializer.Converters.Add(new Vector3Converter());
                serializer.Converters.Add(new Vector4Converter());
                serializer.Error += Serializer_Error;

                outputFile = File.Create(filename);
                sw = new StreamWriter(outputFile);
                jtw = new JsonTextWriter(sw);

                serializer.Serialize(jtw, value, typeof(T));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (jtw != null)
                {
                    jtw.Close();

                    ((IDisposable)jtw).Dispose();
                    jtw = null;
                }

                if (sw != null)
                {
                    sw.Close();

                    sw.Dispose();
                    sw = null;
                }

                if (outputFile != null)
                {
                    outputFile.Close();

                    outputFile.Dispose();
                    outputFile = null;
                }

                serializer.Error -= Serializer_Error;
                serializer = null;
            }
        }

        static T Deserialize<T>(string filename) where T : class
        {
            T result = default;
            FileStream inputFile = default;
            StreamReader sr = default;
            JsonTextReader jtr = default;
            JsonSerializer serializer = default;

            try
            {
                serializer = new JsonSerializer();
                serializer.Converters.Add(new DoubleConverter());
                serializer.Converters.Add(new Vector3Converter());
                serializer.Converters.Add(new Vector4Converter());
                serializer.Error += Serializer_Error;

                inputFile = File.Open(filename, FileMode.Open);
                sr = new StreamReader(inputFile);
                jtr = new JsonTextReader(sr);

                result = serializer.Deserialize<T>(jtr);
            }
            finally
            {
                if (jtr != null)
                {
                    jtr.Close();

                    ((IDisposable)jtr).Dispose();
                    jtr = null;
                }

                if (sr != null)
                {
                    sr.Close();

                    sr.Dispose();
                    sr = null;
                }

                if (inputFile != null)
                {
                    inputFile.Close();

                    inputFile.Dispose();
                    inputFile = null;
                }

                serializer.Error -= Serializer_Error;
                serializer = null;
            }

            return result;
        }

        private static void Serializer_Error(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs e) => Console.WriteLine(e.ErrorContext.Error.Message);

        static void ExtractPak(string inputPath, string outputPath)
        {
            using var cancellationSource = new CancellationTokenSource();
            void cancellationHandler(object s, ConsoleCancelEventArgs e)
            {
                e.Cancel = true;
                cancellationSource.Cancel();
                Console.WriteLine("Cancelling Operation");
            }

            Console.CancelKeyPress += cancellationHandler;

            Task.Run(() => ExtractPakAsync(inputPath, outputPath, new Progress<string>(i => Console.WriteLine(i)), cancellationSource.Token)).ContinueWith((i) =>
            {
                if (i.Status == TaskStatus.Faulted || i.Exception != null)
                {
                    Console.WriteLine("Operation Failed");
                    i.Exception.Handle((ex) =>
                    {
                        Console.WriteLine(ex.Message);
                        return true;
                    });

                    return;
                }

                if (i.Status == TaskStatus.Canceled)
                {
                    Console.WriteLine("Operation Cancelled");
                    return;
                }

                Console.WriteLine("Operation Successful");

            }).Wait();

            Console.CancelKeyPress -= cancellationHandler;
        }

        public static async Task ExtractPakAsync(string inputPath, string outputPath, IProgress<string> progress, CancellationToken cancellationToken)
        {
            var executable = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "psarc.exe");
            if (!File.Exists(executable))
                throw new FileNotFoundException("{0} File Not Found", executable);

            if (!Directory.Exists(inputPath))
                throw new DirectoryNotFoundException();

            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            var dirInfo = new DirectoryInfo(inputPath);
            var taskInfo = dirInfo.GetFiles("*.pak", SearchOption.TopDirectoryOnly).Select(i => new ProcessStartInfo
            {
                FileName = executable,
                Arguments = string.Format("extract --verbose --overwrite --input=\"{0}\" --to=\"{1}\"", i.FullName, outputPath),
                WorkingDirectory = Environment.CurrentDirectory,
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = false,
                RedirectStandardOutput = false,
                UseShellExecute = true,
            }).Select(i => Task.Run(() => Process.Start(i).WaitForExit())).ToList();

            while (taskInfo.Count() > 0)
            {
                var task = await Task.WhenAny(taskInfo);
                taskInfo.Remove(task);

                await task;
            }
        }

        static void ExtractMBin(string input, string output)
        {
            if (!Directory.Exists(input))
                throw new DirectoryNotFoundException();

            var dirInfo = new DirectoryInfo(input);
            var files = dirInfo.GetFiles("*.PC", SearchOption.AllDirectories);
           // var files = dirInfo.GetFiles("*.MBIN;*.PC", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var outputDir = file.DirectoryName.Replace(input, output);
                var outputFile = Path.Combine(outputDir, file.Name.Replace(".MBIN", ".exml").Replace(".PC",""));

                if (!Directory.Exists(outputDir))
                    Directory.CreateDirectory(outputDir);

                try
                {
                    Console.WriteLine("{0} => {1}", file.FullName, outputFile);
                    ExtractMBinFile(file, outputFile);
                }
                catch (Exception ex)
                {
                    var previousColour = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = previousColour;
                }
            }
        }

        static void ExtractMBinFile(FileInfo inputFile, string outputFileName)
        {
            using var mbinFile = new MBINFile(inputFile.FullName);
            using var outputFile = File.Create(outputFileName);
            using var sw = new StreamWriter(outputFile);

            if (!(mbinFile.Load() && mbinFile.Header.IsValid))
                throw new InvalidDataException("Invalid File");

            var type = NMSTemplate.GetTemplateType(mbinFile.Header.GetXMLTemplateName());
            if (type == null)
                throw new NullReferenceException();

            var nms = (NMSAttribute)(type.GetCustomAttributes(typeof(NMSAttribute), false)?[0] ?? null);

            var broken = nms.Broken;
            // GUID's for the old files
            ulong[] UnsupportedGUIDs = new ulong[] { };
            var mismatch = (mbinFile.Header.TemplateGUID != nms.GUID);
            bool unsupported = (UnsupportedGUIDs.Contains(mbinFile.Header.TemplateGUID));

            if (broken)
            {
                var previousColour = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File is broken");
                Console.ForegroundColor = previousColour;
            }
            else if (unsupported)
            {
                var previousColour = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("File is Unsupported");
                Console.ForegroundColor = previousColour;
            }
            else if (mismatch)
            {
                var previousColour = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("File is Mismatched");
                Console.ForegroundColor = previousColour;
            }

            var data = mbinFile.GetData();
            sw.Write(EXmlFile.WriteTemplate(data));
            sw.Flush();
        }

        static void DumpClassInfo<T>(string path) where T : class
        {
            using var outputFile = File.Create(path);
            using var writer = new StreamWriter(outputFile);

            var definedTypes = typeof(T).Assembly.DefinedTypes.Where(i => !i.IsAbstract)
                                                              .SelectMany(i => i.GetProperties())
                                                              .Select(i => new
                                                              {
                                                                  Key = i.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName,
                                                                  PropertyName = i.Name,
                                                                  i.PropertyType,
                                                                  Property = i
                                                              }).GroupBy(i => i.Key).OrderByDescending(i => i.Key);
            foreach (var group in definedTypes)
            {
                writer.WriteLine("{0} ({1})", group.Key, group.Count());

                foreach (var prop in group)
                    writer.WriteLine("{0}.{1} ({2})", prop.Property.ReflectedType.Name, prop.PropertyName, prop.PropertyType);

                writer.WriteLine();
            }
        }

        static void GenerateClasses<T>(string path) where T : class
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach (var classType in typeof(T).Assembly.DefinedTypes)
            {
                using var outputFile = File.Create(string.Format("{0}\\{1}.cs", path, classType.Name));
                using var writer = new StreamWriter(outputFile);

                if (classType.IsAbstract)
                    continue;

                // Search the members of each class to determin which namespaces we need to references.
                var isObjectModelRequired = classType.GetProperties().Where(i => i.PropertyType.Namespace == "System.Collections.ObjectModel").Count() > 0;

                if (isObjectModelRequired)
                    writer.WriteLine("using System.Collections.ObjectModel;");

                writer.WriteLine("using System.Runtime.Serialization;");
                writer.WriteLine("namespace NMSTools.DB");
                writer.WriteLine("{");
                writer.WriteLine("\tusing Base;");
                writer.WriteLine("");
                writer.WriteLine("\t[DataContract]");
                writer.WriteLine("\tpublic class {0} : ModelBase", classType.Name);
                writer.WriteLine("\t{");

                // foreach (var property in classType.GetProperties())
                // Console.WriteLine("{0}\t\t\t{1}\t{2}", 
                //   property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName,
                //   property.Name, 
                //  property.PropertyType);

                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        static void GenerateNativeClasses<T>() where T : class
        {
            foreach (var classType in typeof(T).Assembly.DefinedTypes)
            {
                using var outputFile = File.Create(string.Format("{0}{1}.hpp", "C:\\Users\\dhr\\Desktop\\NMS\\", classType.Name));
                using var writer = new StreamWriter(outputFile);

                if (classType.IsAbstract)
                    continue;

                var includeGuard = string.Format("_NMSTOOLKIT_DB_{0}_H", classType.Name.ToUpper());

                writer.WriteLine(string.Format("#ifndef {0}", includeGuard));
                writer.WriteLine(string.Format("#define {0}", includeGuard));

                writer.WriteLine();
                writer.WriteLine("namespace NMSToolKit");
                writer.WriteLine("{");
                writer.WriteLine("\tnamespace DB");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tclass {0}", classType.Name);
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\tpublic:");
                writer.WriteLine("\t\t\t{0}();", classType.Name);
                writer.WriteLine("\t\t\tvirtual ~{0}();", classType.Name);
                foreach (var property in classType.GetProperties())
                    Console.WriteLine("{0}\t\t\t{1}\t{2}", property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName, property.Name, property.PropertyType);

                writer.WriteLine("\t\t};");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
                writer.Write(string.Format("#endif // !_NMSTOOLKIT_DB_{0}_H", classType.Name.ToUpper()));
            }
        }



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





        public static void PS4_DecompressData(string saveFile, ref byte[] bytes)
        {

        }
    }
}
