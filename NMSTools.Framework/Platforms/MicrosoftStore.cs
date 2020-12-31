using System;
using System.IO;

namespace NMSTools.Framework.Platforms
{
    using Base;

    public class MicrosoftStore : PlatformBase
    {
        private readonly string name = "Microsoft Store";
        private const string filePrefix = "unknown";
        private const string fileExtension = "containers.index";

        private const string metaPrefix = "unknown";
        private const string metaExtension = "";

        public override string Name => name;

        public override string FileExtension => fileExtension;

        public override string FilePrefix => filePrefix;

        public override string MetaPrefix => metaPrefix;

        public override string MetaExtension => metaExtension;

        public override string GetDefaultPath() => Path.Combine(new[]
        {
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Packages",
            "HelloGames.NoMansSky_bs190hzg1sesy",
            "SystemAppData",
            "wgs"
        });
    }
}