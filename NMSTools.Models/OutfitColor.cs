using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class OutfitColor : ModelBase
    {
        private PaletteData palette;
        private float[] rgb;

        [DataMember(Name = "RVl")]
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

        [DataMember(Name = "xEg")]
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