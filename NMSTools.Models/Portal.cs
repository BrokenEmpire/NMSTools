using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Portal : ModelBase
    {
        private object[] portalSeed;
        private object lastPortalUA;

        [JsonProperty("3fO")]
        public object[] PortalSeed
        {
            get => portalSeed;
            set
            {
                if ((ReferenceEquals(portalSeed, value) != true))
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
                if ((ReferenceEquals(lastPortalUA, value) != true))
                {
                    lastPortalUA = value;
                    OnPropertyChanged("LastPortalUA");
                }
            }
        }
    }
}