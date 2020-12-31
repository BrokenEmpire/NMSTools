using System;
using System.IO;

namespace NMSTools.Framework.Platforms
{
    using Base;

    public class Steam : PlatformBase
    {
        private const string name = "Playstation";
        private const string filePrefix = "save";
        private const string fileExtension = ".hg";
        private const string metaPrefix = "mf_save";

        public override string Name => name;

        public override string FilePrefix => filePrefix;

        public override string FileExtension => fileExtension;

        public override string MetaPrefix => metaPrefix;

        public override string MetaExtension => fileExtension;

        public override string GetDefaultPath() => Path.Combine(new[] 
        { 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
            "HelloGames", 
            "NMS" 
        });
    }
}
