using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class DiscoveryData : ModelBase
    {
        private Discovery discoveryDataV1;

        [JsonProperty("ETO")]
        public Discovery DiscoveryDataV1
        {
            get => discoveryDataV1;
            set
            {
                if (ReferenceEquals(discoveryDataV1, value) != true)
                {
                    discoveryDataV1 = value;
                    OnPropertyChanged("DiscoveryDataV1");
                }
            }
        }
    }
}