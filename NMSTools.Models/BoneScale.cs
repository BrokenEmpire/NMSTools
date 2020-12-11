using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class BoneScale : ModelBase
    {
        private string boneName;
        private float scale;

        [JsonProperty("tIm")]
        public string BoneName
        {
            get => boneName;
            set
            {
                if ((ReferenceEquals(boneName, value) != true))
                {
                    boneName = value;
                    OnPropertyChanged("BoneName");
                }
            }
        }

        [JsonProperty("unY")]
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