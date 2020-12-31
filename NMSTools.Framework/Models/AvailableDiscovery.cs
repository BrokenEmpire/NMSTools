using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class AvailableDiscovery : ModelBase
    {
        private int tSrec;
        private DD dD;

        [JsonProperty("kVv")]
        public int TSrec
        {
            get => tSrec;
            set
            {
                if (ReferenceEquals(tSrec, value) != true)
                {
                    tSrec = value;
                    OnPropertyChanged("TSrec");
                }
            }
        }

        [JsonProperty("8P3")]
        public DD DD
        {
            get => dD;
            set
            {
                if (ReferenceEquals(dD, value) != true)
                {
                    dD = value;
                    OnPropertyChanged("DD");
                }
            }
        }
    }
}