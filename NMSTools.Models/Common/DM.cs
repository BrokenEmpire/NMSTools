using Newtonsoft.Json;

namespace NMSTools.Models.Common
{
    using Base;

    public class DM : ModelBase
    {
        private string cN;

        [JsonProperty("q5u")]
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