namespace NMSTools.Framework.Meta
{
    public struct SaveSlot
    {
        private readonly string metaFile;
        private readonly string dataFile;

        public string MetaFile => metaFile;

        public string DataFile => dataFile;

        public SaveSlot(string metaFile, string dataFile)
        {
            this.metaFile = metaFile;
            this.dataFile = dataFile;
        }
    }
}
