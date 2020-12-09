using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Portal : ModelBase
    {
        private string[] portalSeed;
        private string lastPortalUA;

        [DataMember(Name = "3fO")]
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

        [DataMember(Name = "K:U")]
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