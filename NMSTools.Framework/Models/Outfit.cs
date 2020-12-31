using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    
    [JsonObject]
    public class Outfit : ModelBase
    {
        private string[] descriptorGroups;
        private OutfitColor[] outfitColors;
        private TextureOption[] textureOptions;
        private BoneScale[] boneScaleData;
        private double scale;

        [JsonProperty("SMP")]
        public string[] DescriptorGroups
        {
            get => descriptorGroups;
            set
            {
                if (ReferenceEquals(descriptorGroups, value) != true)
                {
                    descriptorGroups = value;
                    OnPropertyChanged("DescriptorGroups");
                }
            }
        }

        [JsonProperty("Aak")]
        public OutfitColor[] OutfitColors
        {
            get => outfitColors;
            set
            {
                if (ReferenceEquals(outfitColors, value) != true)
                {
                    outfitColors = value;
                    OnPropertyChanged("OutfitColors");
                }
            }
        }

        [JsonProperty("T>1")]
        public TextureOption[] TextureOptions
        {
            get => textureOptions;
            set
            {
                if (ReferenceEquals(textureOptions, value) != true)
                {
                    textureOptions = value;
                    OnPropertyChanged("TextureOptions");
                }
            }
        }

        [JsonProperty("gsg")]
        public BoneScale[] BoneScaleData
        {
            get => boneScaleData;
            set
            {
                if (ReferenceEquals(boneScaleData, value) != true)
                {
                    boneScaleData = value;
                    OnPropertyChanged("BoneScaleData");
                }
            }
        }

        [JsonProperty("unY")]
        public double Scale
        {
            get => scale;
            set
            {
                if (ReferenceEquals(scale, value) != true)
                {
                    scale = value;
                    OnPropertyChanged("Scale");
                }
            }
        }
    }
}