using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Outfit : ModelBase
    {
        private string[] descriptorGroups;
        private OutfitColor[] outfitColors;
        private TextureOption[] textureOptions;
        private BoneScale[] boneScaleData;
        private float scale;

        [DataMember(Name = "SMP")]
        public string[] DescriptorGroups
        {
            get => descriptorGroups;
            set
            {
                if ((ReferenceEquals(descriptorGroups, value) != true))
                {
                    descriptorGroups = value;
                    OnPropertyChanged("DescriptorGroups");
                }
            }
        }

        [DataMember(Name = "Aak")]
        public OutfitColor[] OutfitColors
        {
            get => outfitColors;
            set
            {
                if ((ReferenceEquals(outfitColors, value) != true))
                {
                    outfitColors = value;
                    OnPropertyChanged("OutfitColors");
                }
            }
        }

        [DataMember(Name = "T>1")]
        public TextureOption[] TextureOptions
        {
            get => textureOptions;
            set
            {
                if ((ReferenceEquals(textureOptions, value) != true))
                {
                    textureOptions = value;
                    OnPropertyChanged("TextureOptions");
                }
            }
        }

        [DataMember(Name = "gsg")]
        public BoneScale[] BoneScaleData
        {
            get => boneScaleData;
            set
            {
                if ((ReferenceEquals(boneScaleData, value) != true))
                {
                    boneScaleData = value;
                    OnPropertyChanged("BoneScaleData");
                }
            }
        }

        [DataMember(Name = "unY")]
        public float Scale
        {
            get => scale;
            set
            {
                if ((ReferenceEquals(scale, value) != true))
                {
                    scale = value;
                    OnPropertyChanged("Scale");
                }
            }
        }
    }
}