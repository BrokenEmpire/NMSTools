using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class StatData : ModelBase
    {
        private string baseStatID;
        private decimal statValue;

        [JsonProperty("QL1")]
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

        [JsonProperty(">MX")]
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