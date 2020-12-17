using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    public class OutfitColor : ModelBase
    {
        private PaletteData palette;
        private double[] rgb;

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
        public double[] RGB
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