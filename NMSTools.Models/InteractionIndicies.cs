using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class InteractionIndicies : ModelBase
    {
        private int[] savedRaceIndicies;

        [JsonProperty("SEK")]
        public int[] SavedRaceIndicies
        {
            get => savedRaceIndicies;
            set
            {
                if ((ReferenceEquals(savedRaceIndicies, value) != true))
                {
                    savedRaceIndicies = value;
                    OnPropertyChanged("SavedRaceIndicies");
                }
            }
        }
    }
}