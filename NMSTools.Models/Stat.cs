using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Stat : ModelBase
    {
        private string groupId;
        private object address;
        private StatDetail[] stats;

        [DataMember(Name = ":rc")]
        public string GroupId
        {
            get => groupId;
            set
            {
                if ((ReferenceEquals(groupId, value) != true))
                {
                    groupId = value;
                    OnPropertyChanged("GroupId");
                }
            }
        }

        [DataMember(Name = "2Ak")]
        public object Address
        {
            get => address;
            set
            {
                if ((ReferenceEquals(address, value) != true))
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        [DataMember(Name = "gUR")]
        public StatDetail[] Stats
        {
            get => stats;
            set
            {
                if ((ReferenceEquals(stats, value) != true))
                {
                    stats = value;
                    OnPropertyChanged("Stats");
                }
            }
        }
    }
}