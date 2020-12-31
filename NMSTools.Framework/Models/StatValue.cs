using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class StatValue : ModelBase
    {
        private int intValue;
        private double doubleValue;

        [JsonProperty(">vs", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int IntValue
        {
            get => intValue;
            set
            {
                if (ReferenceEquals(intValue, value) != true)
                {
                    intValue = value;
                    OnPropertyChanged("IntValue");
                }
            }
        }

        [JsonProperty("eoL", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public double DoubleValue
        {
            get => doubleValue;
            set
            {
                if (ReferenceEquals(doubleValue, value) != true)
                {
                    doubleValue = value;
                    OnPropertyChanged("doubleValue");
                }
            }
        }
    }
}