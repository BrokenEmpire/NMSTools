using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class TextureOption : ModelBase
    {
        private string textureOptionGroupName;
        private string textureOptionName;

        [JsonProperty("@6c")]
        public string TextureOptionGroupName
        {
            get => textureOptionGroupName;
            set
            {
                if (ReferenceEquals(textureOptionGroupName, value) != true)
                {
                    textureOptionGroupName = value;
                    OnPropertyChanged("TextureOptionGroupName");
                }
            }
        }

        [JsonProperty("=Cv")]
        public string TextureOptionName
        {
            get => textureOptionName;
            set
            {
                if (ReferenceEquals(textureOptionName, value) != true)
                {
                    textureOptionName = value;
                    OnPropertyChanged("TextureOptionName");
                }
            }
        }
    }
}