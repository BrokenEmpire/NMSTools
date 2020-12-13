using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    [JsonObject]
    public class Weapon : ModelBase
    {
        private string filename;
        private object[] generationSeed;

        [JsonConverter(typeof(FilePathConverter))]
        [JsonProperty("93M")]
        public string Filename
        {
            get => filename;
            set
            {
                if ((ReferenceEquals(filename, value) != true))
                {
                    filename = value;
                    OnPropertyChanged("Filename");
                }
            }
        }

        [JsonProperty("NNR")]
        public object[] GenerationSeed
        {
            get => generationSeed;
            set
            {
                if ((ReferenceEquals(generationSeed, value) != true))
                {
                    generationSeed = value;
                    OnPropertyChanged("GenerationSeed");
                }
            }
        }
    }
}