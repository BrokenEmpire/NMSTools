using System.Runtime.Serialization;

namespace NMSTools.Models.Common
{
    using Base;

    [DataContract]
    public class DM : ModelBase
    {
        private string cN;

        [DataMember(Name = "q5u")]
        public string CN
        {
            get => cN;
            set
            {
                if ((ReferenceEquals(cN, value) != true))
                {
                    cN = value;
                    OnPropertyChanged("CN");
                }
            }
        }
    }
}