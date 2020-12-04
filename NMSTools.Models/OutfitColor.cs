using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class OutfitColor : ModelBase
    {
        private PaletteData palette;
        private float[] rgb;

        [JsonProperty("RVl")]
        public PaletteData Palette
        {
            get => palette;
            set
            {
                if ((ReferenceEquals(palette, value) != true))
                {
                    palette = value;
                    OnPropertyChanged("Palette");
                }
            }
        }

        [JsonProperty("xEg")]
        public float[] RGB
        {
            get => rgb;
            set
            {
                if ((ReferenceEquals(rgb, value) != true))
                {
                    rgb = value;
                    OnPropertyChanged("RGB");
                }
            }
        }
    }
}