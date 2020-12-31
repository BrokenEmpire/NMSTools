using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class DM : ModelBase
    {
        private string cN;

        [JsonProperty("q5u", NullValueHandling = NullValueHandling.Ignore)]
        public string CN
        {
            get => cN;
            set
            {
                if (ReferenceEquals(cN, value) != true)
                {
                    cN = value;
                    OnPropertyChanged("CN");
                }
            }
        }
    }
}