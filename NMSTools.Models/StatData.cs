using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StatData : ModelBase
    {
        private string baseStatID;
        private decimal statValue;

        [DataMember(Name = "QL1")]
        public string BaseStatID
        {
            get => baseStatID;
            set
            {
                if ((ReferenceEquals(baseStatID, value) != true))
                {
                    baseStatID = value;
                    OnPropertyChanged("BaseStatID");
                }
            }
        }

        [DataMember(Name = ">MX")]
        public decimal StatValue
        {
            get => statValue;
            set
            {
                if ((ReferenceEquals(statValue, value) != true))
                {
                    statValue = value;
                    OnPropertyChanged("StatValue");
                }
            }
        }
    }
}