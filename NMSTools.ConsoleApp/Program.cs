using Newtonsoft.Json;
using libMBIN;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NMSTools.ConsoleApp
{
    using Framework.Converters;
    using Framework.Models;

    class Program
    {
        public const string pcBanksDir = "D:\\NMSData\\PCBANKS";
        public const string mBinDir = "D:\\NMSData\\MBIN";
        public const string eXMLDir = "D:\\NMSData\\EXML";

        public const string saveFile = "D:\\NMSProjects\\Archives\\Misc\\save.hg";

        static void Main(string[] args)
        {
            var root = Deserialize<NMSRoot>(saveFile);
            using var outputFile = File.Create("C:\\Users\\dhr\\Desktop\\items.csv");
            using var outputStream = new StreamWriter(outputFile);
            
            foreach (var playerBase in root.PlayerStateData.PersistentPlayerBases)
            {
                if (playerBase.Name != "Test Base")
                    continue;

                foreach (var item in playerBase.Objects)
                    outputStream.WriteLine("{0},{1},{2},{3},\"{4}\"", item.Timestamp, item.Position.ToString(), item.At.ToString(), item.Up.ToString(), item.ObjectID);
            }

            outputStream.Flush();
            outputFile.Flush();



            Serialize(root, saveFile.Replace(".hg", ".nmsTools.hg"));

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

            foreach (var item in files.Where(i => !i.Extension.Equals(".MBIN")).GroupBy(i => i.Extension))
            {

                sw.WriteLine(string.Format("{0} ({1})", item.Key, item.Count()));
                foreach (var file in item)
                {
                    sw.WriteLine(string.Format("  {0}", file.FullName));
                }

                sw.WriteLine();
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

        static void ExtractMBins(string input, string output)
        {
            if (!Directory.Exists(input))
                throw new DirectoryNotFoundException();

            var dirInfo = new DirectoryInfo(input);
            var files = dirInfo.GetFiles("*.MBIN", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var outputDir = file.DirectoryName.Replace(input, output);
                var outputFile = Path.Combine(outputDir, file.Name.Replace(file.Extension, ".exml"));

                if (!Directory.Exists(outputDir))
                    Directory.CreateDirectory(outputDir);

                try
                {
                    Console.WriteLine("{0} => {1}", file.FullName, outputFile);
                    Extract(file, outputFile);
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

        static void Extract(FileInfo inputFile, string outputFileName)
        {


            using var mbinFile = new MBINFile(inputFile.FullName);
            using var outputFile = File.Create(outputFileName);
            using var sw = new StreamWriter(outputFile);

            if (!(mbinFile.Load() && mbinFile.Header.IsValid))
                throw new InvalidDataException("Invalid File");

            var type = NMSTemplate.GetTemplateType(mbinFile.Header.GetXMLTemplateName());
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
