namespace NMSTools.Framework.Platforms
{
    using Base;

    public class Playstation : PlatformBase
    {
        private readonly string name = "Playstation";
        private const string filePrefix = "sce_sdmemory";
        private const string fileExtension = "";

        private const string metaPrefix = "sce_sdmemory";
        private const string metaExtension = ".bin";

        public override string Name => name;

        public override string FilePrefix => filePrefix;

        public override string FileExtension => fileExtension;

        public override string MetaPrefix => metaPrefix;

        public override string MetaExtension => metaExtension;

        public override string GetDefaultPath() => string.Empty;
    }
}
