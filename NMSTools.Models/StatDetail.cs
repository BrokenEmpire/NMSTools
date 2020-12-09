using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StatDetail : ModelBase
    {
        private string id;
        private StatValue statValue;

        [DataMember(Name = "b2n")]
        public string Id
        {
            get => id;
            set
            {
                if ((ReferenceEquals(id, value) != true))
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
       
        [DataMember(Name = ">MX")]
        public StatValue StatValue
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