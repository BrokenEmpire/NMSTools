using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StatValue : ModelBase
    {
        private int intValue;
        private decimal floatValue;

        [DataMember(Name = ">vs", EmitDefaultValue = false)]
        public int IntValue
        {
            get => intValue;
            set
            {
                if ((ReferenceEquals(intValue, value) != true))
                {
                    intValue = value;
                    OnPropertyChanged("IntValue");
                }
            }
        }

        [DataMember(Name = "eoL", EmitDefaultValue = false)]
        public decimal FloatValue
        {
            get => floatValue;
            set
            {
                if ((ReferenceEquals(floatValue, value) != true))
                {
                    floatValue = value;
                    OnPropertyChanged("FloatValue");
                }
            }
        }
    }
}