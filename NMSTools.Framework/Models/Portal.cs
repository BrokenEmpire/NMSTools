using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class Portal : ModelBase
    {
        private object[] portalSeed;  //todo: strong type
        private object lastPortalUA;  //todo:: strong type

        [JsonProperty("3fO")]
        public object[] PortalSeed
        {
            get => portalSeed;
            set
            {
                if (ReferenceEquals(portalSeed, value) != true)
                {
                    portalSeed = value;
                    OnPropertyChanged("PortalSeed");
                }
            }
        }

        [JsonProperty("K:U")]
        public object LastPortalUA
        {
            get => lastPortalUA;
            set
            {
                if (ReferenceEquals(lastPortalUA, value) != true)
                {
                    lastPortalUA = value;
                    OnPropertyChanged("LastPortalUA");
                }
            }
        }
    }
}