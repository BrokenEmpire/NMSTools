using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class CatalogLayout : ModelBase
    {
        private int slots;
        private string[] seed;
        private int level;

        [JsonProperty(":No")]
        public int Slots
        {
            get => slots;
            set
            {
                if ((ReferenceEquals(slots, value) != true))
                {
                    slots = value;
                    OnPropertyChanged("Slots");
                }
            }
        }

        [JsonProperty("@EL")]
        public string[] Seed
        {
            get => seed;
            set
            {
                if ((ReferenceEquals(seed, value) != true))
                {
                    seed = value;
                    OnPropertyChanged("Seed");
                }
            }
        }

        [JsonProperty("9;o")]
        public int Level
        {
            get => level;
            set
            {
                if ((ReferenceEquals(level, value) != true))
                {
                    level = value;
                    OnPropertyChanged("Level");
                }
            }
        }
    }
}