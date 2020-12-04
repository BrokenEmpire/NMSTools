using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

using libMBIN;

namespace NMSTools.ConsoleApp
{
    using Models;

    struct FieldData
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Attribute { get; set; }

        public string GetPrivateName()
        {
            return Name.Substring(0, 1).ToLower() + Name.Substring(1);
        }

        public string GetGeneratedType()
        {
            if (Type.Contains("IList"))
                return Type.Replace("IList", "ObservableCollection");

            return Type;
        }
    }

    class Program
    {
        public const string oldDataContracts = "D:\\NMSData\\ARCHIVE\\BackupContracts";
        public const string newDataContracts = "D:\\NMSData\\ARCHIVE\\NewpContracts";

        public const string pcBanksDir = "D:\\NMSData\\PCBANKS";
        public const string mBinDir = "D:\\NMSData\\MBIN";
        public const string eXMLDir = "D:\\NMSData\\EXML";

        public const string saveFile = "D:\\NMSProjects\\Archives\\Misc\\save.hg";

        static void Main(string[] args)
        {
            var root = ParseJson(saveFile);

            foreach (var playerBase in root.PlayerStateData.PersistentPlayerBases)
            {
                Console.WriteLine(playerBase.Name);

                foreach (var baseObject in playerBase.Objects)
                {
                    Console.WriteLine("Object ID: {0}", baseObject.ObjectID);
                    Console.WriteLine("Position: [ {0}, {1}, {2} ]", baseObject.Position[0], baseObject.Position[1], baseObject.Position[2]);
                    Console.WriteLine("Up:       [ {0}, {1}, {2} ]", baseObject.Up[0], baseObject.Up[1], baseObject.Up[2]);
                    Console.WriteLine("At:       [ {0}, {1}, {2} ]", baseObject.At[0], baseObject.At[1], baseObject.At[2]);
                    Console.WriteLine();
                }

                break;
            }

            Console.WriteLine();
            Console.WriteLine("Program Complete");
            Console.Read();
            
        }

        static NMSRoot ParseJson(string filename)
        {
            using var inputFile = File.Open(filename, FileMode.Open);
            using var sr = new StreamReader(inputFile);
            using var json = new JsonTextReader(sr);

            var serializer = new JsonSerializer();
            var root = serializer.Deserialize<NMSRoot>(json);

            return root;
        }

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

        static void GenerateClasses(string input, string output)
        {
            if (!Directory.Exists(input))
            {
                Console.WriteLine("Input directory does not exist.");
                Console.Read();

                return;
            }

            if (!Directory.Exists(output))
                Directory.CreateDirectory(output);

            var dirInfo = new DirectoryInfo(input);
            var modelFiles = dirInfo.GetFiles("*.cs", SearchOption.AllDirectories);

            foreach (var file in modelFiles)
            {
                switch (file.Directory.Name)
                {
                    case "Base":
                    case "Debug":
                    case "Release":
                    case "Properties":
                        continue;

                    default:
                        break;
                }

                using var inputFile = file.Open(FileMode.Open, FileAccess.Read);
                using var outputFile = File.Create(output + "\\" + file.Name);
                using var sr = new StreamReader(inputFile);
                using var sw = new StreamWriter(outputFile);

                var fields = new List<FieldData>();

                sw.WriteLine("using Newtonsoft.Json;");
                sw.WriteLine("using System;");
                sw.WriteLine("using System.Collections.Generic;");
                sw.WriteLine("using System.Collections.ObjectModel;");
                sw.WriteLine("");

                var line = string.Empty;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (line.Contains("namespace"))
                    {
                        sw.WriteLine(line);
                        sw.WriteLine("{");
                        sw.WriteLine("\tusing Base;");
                        sw.WriteLine("\tusing Common;");
                        sw.WriteLine("");
                    }
                    else if (line.Contains("public class"))
                    {
                        sw.WriteLine(line + " : ModelBase");
                        sw.WriteLine("\t{");
                    }
                    else if (line.Contains("JsonProperty"))
                    {
                        var field = new FieldData { Attribute = line };
                        var components = sr.ReadLine().Replace("{ get; set; }", "").Trim().Split(' ');

                        field.Type = components[1];
                        field.Name = components[2];

                        fields.Add(field);
                    }
                }

                foreach (var field in fields)
                    sw.WriteLine("\t\tprivate {0} {1};", field.GetGeneratedType(), field.GetPrivateName());

                sw.WriteLine();

                foreach (var field in fields)
                {
                    sw.WriteLine(field.Attribute);
                    sw.WriteLine("\t\tpublic {0} {1}", field.GetGeneratedType(), field.Name);
                    sw.WriteLine("\t\t{");

                    sw.WriteLine("\t\t\tget => {0};", field.GetPrivateName());
                    sw.WriteLine("\t\t\tset");
                    sw.WriteLine("\t\t\t{");
                    sw.WriteLine("\t\t\t\tif ((ReferenceEquals({0}, value) != true))", field.GetPrivateName());
                    sw.WriteLine("\t\t\t\t{");
                    sw.WriteLine("\t\t\t\t\t{0} = value;", field.GetPrivateName());
                    sw.WriteLine("\t\t\t\t\tOnPropertyChanged(\"{0}\");", field.Name);
                    sw.WriteLine("\t\t\t\t}");
                    sw.WriteLine("\t\t\t}");
                    sw.WriteLine("\t\t}");
                    sw.WriteLine();
                }

                sw.WriteLine("\t}");
                sw.WriteLine("}");
            }
        }
    }
}
