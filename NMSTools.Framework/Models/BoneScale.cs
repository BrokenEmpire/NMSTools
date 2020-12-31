using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class BoneScale : ModelBase
    {
        private string boneName;
        private double scale;

        [JsonProperty("tIm")]
        public string BoneName
        {
            get => boneName;
            set
            {
                if (ReferenceEquals(boneName, value) != true)
                {
                    boneName = value;
                    OnPropertyChanged("BoneName");
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