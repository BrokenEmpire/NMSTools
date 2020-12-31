using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    
    [JsonObject]
    public class InteractionIndicies : ModelBase
    {
        private int[] savedRaceIndicies;

        [JsonProperty("SEK")]
        public int[] SavedRaceIndicies
        {
            get => savedRaceIndicies;
            set
            {
                if (ReferenceEquals(savedRaceIndicies, value) != true)
                {
                    savedRaceIndicies = value;
                    OnPropertyChanged("SavedRaceIndicies");
                }
            }
        }
    }
}