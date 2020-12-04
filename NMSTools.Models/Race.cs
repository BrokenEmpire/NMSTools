using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Race : ModelBase
    {
        private string alienRace;

        [JsonProperty("0Hi")]
        public string AlienRace 
        { 
            get => alienRace;
            set
            {
                if ((ReferenceEquals(alienRace, value) != true))
                {
                    alienRace = value;
                    OnPropertyChanged("AlienRace");
                }
            }
        }
    }
}
