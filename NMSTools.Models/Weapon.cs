using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    [JsonObject]
    public class Weapon : ModelBase
    {
        private string filename;
        private object[] generationSeed;

        [JsonProperty(PropertyName = "93M", ItemConverterType = typeof(FilePathConverter))]
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