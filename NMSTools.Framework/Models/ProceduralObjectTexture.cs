using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    
    [JsonObject]
    public class ProceduralObjectTexture : ModelBase
    {
        private string[] samplers;

        [JsonProperty("bnT")]
        public string[] Samplers
        {
            get => samplers;
            set
            {
                if (ReferenceEquals(samplers, value) != true)
                {
                    samplers = value;
                    OnPropertyChanged("Samplers");
                }
            }
        }
    }
}