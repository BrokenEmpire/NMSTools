using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class FL : ModelBase
    {
        private int c;
        private int unknown;

        [JsonProperty("bLr")]
        public int C
        {
            get => c;
            set
            {
                if (ReferenceEquals(c, value) != true)
                {
                    c = value;
                    OnPropertyChanged("C");
                }
            }
        }

        [JsonProperty("tiH")]
        public int Unknown
        {
            get => unknown;
            set
            {
                if (ReferenceEquals(unknown, value) != true)
                {
                    unknown = value;
                    OnPropertyChanged("Unknown");
                }
            }
        }
    }
}