using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class StatValue : ModelBase
    {
        private int intValue;
        private decimal floatValue;

        [JsonProperty(">vs", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
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

        [JsonProperty("eoL", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
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