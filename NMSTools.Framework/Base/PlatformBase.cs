namespace NMSTools.Framework.Base
{
    public abstract class PlatformBase
    {
        public abstract string Name { get; }

        public abstract string FilePrefix { get; }

        public abstract string FileExtension { get; }

        public abstract string MetaPrefix { get; }

        public abstract string MetaExtension { get; }

        protected PlatformBase() { }

        public virtual string GetDefaultPath() => string.Empty;
    }
}
