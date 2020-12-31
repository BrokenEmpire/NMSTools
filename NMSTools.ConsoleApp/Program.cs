using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;

using libMBIN;
using Newtonsoft.Json;

namespace NMSTools.ConsoleApp
{
    using Framework.Models;
    using Framework.Converters;
    using Framework.Meta;
    using Platforms;
   
    class Program
    {
        public const string steamSavePath = "C:\\Users\\dhr\\AppData\\Roaming\\HelloGames\\NMS\\st_76561197972355393";

        public const string pcBanksDir = "D:\\NMSData\\PCBANKS";
        public const string mBinDir = "D:\\NMSData\\MBIN";
        public const string eXMLDir = "D:\\NMSData\\EXML";

        public const string saveFile = "D:\\NMSProjects\\Archives\\Misc\\save.hg";
        public const string metaFile = "D:\\NMSProjects\\Archives\\Misc\\mf_save.hg";

        public const string testSaveFile = "D:\\NMSProjects\\Archives\\Misc\\save.nmstools.hg";
        public const string testMetaFile = "D:\\NMSProjects\\Archives\\Misc\\mf_save.nmstools.hg";

        public const string randomSaveFile = "D:\\NMSProjects\\Archives\\Misc\\save.nmseditor.hg";
        public const string randomMetaFile = "D:\\NMSProjects\\Archives\\Misc\\mf_save.nmseditor.hg";

        public const string ps4SaveFile = "D:\\NMSProjects\\Archives\\Misc\\5c034a628ee6353c\\CUSA04841\\sce_sdmemory";
        public const string ps4MetaFile = "D:\\NMSProjects\\Archives\\Misc\\5c034a628ee6353c\\CUSA04841\\sce_sdmemory.bin";


        public struct SaveContainer
        {
            public string Meta { get; set; }

            public string Data { get; set; }

            public int Index { get; set; }

            public int SaveType { get; set; }
        }

        static void Main(string[] args)
        {
            // var slot = new SaveSlot(metaFile, saveFile);

            //  using var inputFile = File.Open("D:\\TestFile.dump", FileMode.Open, FileAccess.Read, FileShare.Read);
            //  using var sha256 = new SHA256Managed();
            //  var result = sha256.ComputeHash(inputFile);

            FindOtherFiles();
            //Console.WriteLine(inputFile.Position);
            // var root = Deserialize<NMSRoot>(saveFile);

            // var playerBases = root.PlayerStateData.PersistentPlayerBases;

            // foreach (var item in playerBases.SelectMany(i => i.Objects).GroupBy(i => i.ObjectID).OrderByDescending(i => i.Count()))
            //  {
            //    Console.WriteLine("{0}\t\t({1})", item.Key, item.Count());
            // }

            //   Serialize(root, testSaveFile);
            Console.WriteLine();
            Console.WriteLine("Program Complete");
            Console.Read();
        }

        static void FindOtherFiles()
        {
            using var outputFile = File.Create("C:\\Users\\dhr\\Desktop\\output.txt");
            using var sw = new StreamWriter(outputFile);

            var dirInfo = new DirectoryInfo(mBinDir);
            var files = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            var special = new string[5] { ".TXT", ".XML", ".JSON", ".CSV", ".DDS" };
            foreach (var group in files.Where(i => i.Extension.Length > 0).GroupBy(i => i.Extension).OrderByDescending(i => i.Count()))
            {
                sw.WriteLine(string.Format("{0} ({1})", group.Key, group.Count()));

                if (special.Contains(group.Key.ToUpper()))
                {
                    foreach (var item in group)
                    {
                        sw.WriteLine(item.FullName);
                    }
                }
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

                sw.Write("\0");
            }
            finally
            {
                if (jtw != null)
                {
                    jtw.Flush();
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
            var files = dirInfo.GetFiles("*.MBIN;*.PC", SearchOption.AllDirectories);

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
    }
}
