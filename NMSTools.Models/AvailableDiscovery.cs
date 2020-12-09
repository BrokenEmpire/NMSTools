using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;
    using Common;

    [DataContract]
    public class AvailableDiscovery : ModelBase
    {
        private int tSrec;
        private DD dD;

        [DataMember(Name = "kVv")]
        public int TSrec
        {
            get => tSrec;
            set
            {
                if ((ReferenceEquals(tSrec, value) != true))
                {
                    tSrec = value;
                    OnPropertyChanged("TSrec");
                }
            }
        }

        [DataMember(Name = "8P3")]
        public DD DD
        {
            get => dD;
            set
            {
                if ((ReferenceEquals(dD, value) != true))
                {
                    dD = value;
                    OnPropertyChanged("DD");
                }
            }
        }
    }
}