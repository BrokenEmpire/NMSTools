using Newtonsoft.Json;
using System;
using System.IO;

namespace NMSTools.ConsoleApp
{
    using Models;

    class Program
    {
        public const string saveFile = "D:\\NMSProjects\\Archives\\Misc\\save.hg";

        static void Main(string[] args)
        {
            using var inputFile = File.Open(saveFile, FileMode.Open);
            using var sr = new StreamReader(inputFile);
            using var json = new JsonTextReader(sr);

            var serializer = new JsonSerializer();
            var root = serializer.Deserialize<NMSRoot>(json);

            Console.WriteLine("Program Complete");
            Console.Read();
        }
    }
}
