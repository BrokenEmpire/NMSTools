using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class StatDetail : ModelBase
    {
        private string id;
        private StatValue statValue;

        [JsonProperty("b2n")]
        public string Id
        {
            get => id;
            set
            {
                if (ReferenceEquals(id, value) != true)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
       
        [JsonProperty(">MX")]
        public StatValue StatValue
        {
            get => statValue;
            set
            {
                if (ReferenceEquals(statValue, value) != true)
                {
                    statValue = value;
                    OnPropertyChanged("StatValue");
                }
            }
        }
    }
}