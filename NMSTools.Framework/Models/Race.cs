using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
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