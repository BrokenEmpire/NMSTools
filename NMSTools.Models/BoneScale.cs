using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class BoneScale : ModelBase
    {
        private string boneName;
        private float scale;

        [DataMember(Name = "tIm")]
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