using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Portal : ModelBase
    {
        private string[] portalSeed;
        private string lastPortalUA;

        [JsonProperty("3fO")]
        public string[] PortalSeed
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
        public string LastPortalUA
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