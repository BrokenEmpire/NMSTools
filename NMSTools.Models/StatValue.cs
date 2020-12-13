using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class StatValue : ModelBase
    {
        private int intValue;
        private decimal doubleValue;

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
        public decimal DoubleValue
        {
            get => doubleValue;
            set
            {
                if ((ReferenceEquals(doubleValue, value) != true))
                {
                    doubleValue = value;
                    OnPropertyChanged("doubleValue");
                }
            }
        }
    }
}