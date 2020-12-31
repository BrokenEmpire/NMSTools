using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class WordGroup : ModelBase
    {
        private string group;
        private bool[] races;

        [JsonProperty("MYl")]
        public string Group
        {
            get => group;
            set
            {
                if (ReferenceEquals(group, value) != true)
                {
                    group = value;
                    OnPropertyChanged("Group");
                }
            }
        }

        [JsonProperty("D;o")]
        public bool[] Races
        {
            get => races;
            set
            {
                if (ReferenceEquals(races, value) != true)
                {
                    races = value;
                    OnPropertyChanged("Races");
                }
            }
        }
    }
}