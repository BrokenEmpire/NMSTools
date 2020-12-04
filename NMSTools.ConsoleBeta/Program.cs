using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NMSTools.ConsoleBeta
{
    class Program
    {
        public const string inputDir = "D:\\NMSData\\BackupContracts";
        public const string outputDir = "D:\\NMSData\\DataContracts";

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

        static void Main(string[] args)
        {
            if (!Directory.Exists(inputDir))
            {
                Console.WriteLine("Input directory does not exist.");
                Console.Read();

                return;
            }

            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            var dirInfo = new DirectoryInfo(inputDir);
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
                using var outputFile = File.Create(outputDir + "\\" + file.Name);
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

            Console.WriteLine();
            Console.WriteLine("Program Complete");
            Console.Read();
        }
    }
}
