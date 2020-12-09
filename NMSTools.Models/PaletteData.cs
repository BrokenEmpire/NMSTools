using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PaletteData : ModelBase
    {
        private string palette;
        private string colourAlt;

        [DataMember(Name = "RVl")]
        public string Palette
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

        [DataMember(Name = "Ty=")]
        public string ColourAlt
        {
            get => colourAlt;
            set
            {
                if ((ReferenceEquals(colourAlt, value) != true))
                {
                    colourAlt = value;
                    OnPropertyChanged("ColourAlt");
                }
            }
        }
    }
}