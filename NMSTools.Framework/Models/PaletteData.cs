using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class PaletteData : ModelBase
    {
        private string palette;
        private string colourAlt;

        [JsonProperty("RVl")]
        public string Palette
        {
            get => palette;
            set
            {
                if (ReferenceEquals(palette, value) != true)
                {
                    palette = value;
                    OnPropertyChanged("Palette");
                }
            }
        }

        [JsonProperty("Ty=")]
        public string ColourAlt
        {
            get => colourAlt;
            set
            {
                if (ReferenceEquals(colourAlt, value) != true)
                {
                    colourAlt = value;
                    OnPropertyChanged("ColourAlt");
                }
            }
        }
    }
}