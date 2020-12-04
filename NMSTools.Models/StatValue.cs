using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class StatValue : ModelBase
    {
        private int intValue;
        private float floatValue;

        [JsonProperty(">vs")]
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

        [JsonProperty("eoL")]
        public float FloatValue 
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
