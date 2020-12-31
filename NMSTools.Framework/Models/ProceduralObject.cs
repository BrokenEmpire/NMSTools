using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Converters;

    [JsonObject]
    public class ProceduralObject : ModelBase
    {
        private string filename;
        private object[] seed;  //todo: strong type
        private string altId;
        private ProceduralObjectTexture proceduralTexture;

        [JsonConverter(typeof(PathConverter))]
        [JsonProperty("93M")]
        public string Filename
        {
            get => filename;
            set
            {
                if (ReferenceEquals(filename, value) != true)
                {
                    filename = value;
                    OnPropertyChanged("Filename");
                }
            }
        }

        [JsonProperty("@EL")]
        public object[] Seed
        {
            get => seed;
            set
            {
                if (ReferenceEquals(seed, value) != true)
                {
                    seed = value;
                    OnPropertyChanged("Seed");
                }
            }
        }

        [JsonProperty("QlJ")]
        public string AltId
        {
            get => altId;
            set
            {
                if (ReferenceEquals(altId, value) != true)
                {
                    altId = value;
                    OnPropertyChanged("AltId");
                }
            }
        }

        [JsonProperty("<d2")]
        public ProceduralObjectTexture ProceduralTexture
        {
            get => proceduralTexture;
            set
            {
                if (ReferenceEquals(proceduralTexture, value) != true)
                {
                    proceduralTexture = value;
                    OnPropertyChanged("ProceduralTexture");
                }
            }
        }
    }
}