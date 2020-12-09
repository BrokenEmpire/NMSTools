using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class DiscoveryData : ModelBase
    {
        private Discovery discoveryDataV1;

        [DataMember(Name = "ETO")]
        public Discovery DiscoveryDataV1
        {
            get => discoveryDataV1;
            set
            {
                if ((ReferenceEquals(discoveryDataV1, value) != true))
                {
                    discoveryDataV1 = value;
                    OnPropertyChanged("DiscoveryDataV1");
                }
            }
        }
    }
}