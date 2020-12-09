using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class FrigateClass : ModelBase
    {
        private string className;

        [DataMember(Name = "uw7")]
        public string ClassName
        {
            get => className;
            set
            {
                if ((ReferenceEquals(className, value) != true))
                {
                    className = value;
                    OnPropertyChanged("ClassName");
                }
            }
        }
    }
}