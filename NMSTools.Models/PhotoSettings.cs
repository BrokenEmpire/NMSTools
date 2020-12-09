using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PhotoSettings : ModelBase
    {
        private float fog;
        private float cloudAmount;
        private float[] sunDir;
        private bool sunDirSet;
        private float foV;
        private bool foVSet;
        private string depthOfField;
        private float depthOfFieldStrengthSetting;
        private float depthOfFieldDistance;
        private float depthOfFieldDistanceSpace;
        private float halfFocalPlaneDepth;
        private float halfFocalPlaneDepthSpace;
        private float vignette;
        private int filter;

        [DataMember(Name = "qAx")]
        public float Fog
        {
            get => fog;
            set
            {
                if ((ReferenceEquals(fog, value) != true))
                {
                    fog = value;
                    OnPropertyChanged("Fog");
                }
            }
        }

        [DataMember(Name = "22a")]
        public float CloudAmount
        {
            get => cloudAmount;
            set
            {
                if ((ReferenceEquals(cloudAmount, value) != true))
                {
                    cloudAmount = value;
                    OnPropertyChanged("CloudAmount");
                }
            }
        }

        [DataMember(Name = "qLk")]
        public float[] SunDir
        {
            get => sunDir;
            set
            {
                if ((ReferenceEquals(sunDir, value) != true))
                {
                    sunDir = value;
                    OnPropertyChanged("SunDir");
                }
            }
        }

        [DataMember(Name = "OCG")]
        public bool SunDirSet
        {
            get => sunDirSet;
            set
            {
                if ((ReferenceEquals(sunDirSet, value) != true))
                {
                    sunDirSet = value;
                    OnPropertyChanged("SunDirSet");
                }
            }
        }

        [DataMember(Name = "yGF")]
        public float FoV
        {
            get => foV;
            set
            {
                if ((ReferenceEquals(foV, value) != true))
                {
                    foV = value;
                    OnPropertyChanged("FoV");
                }
            }
        }

        [DataMember(Name = "ARP")]
        public bool FoVSet
        {
            get => foVSet;
            set
            {
                if ((ReferenceEquals(foVSet, value) != true))
                {
                    foVSet = value;
                    OnPropertyChanged("FoVSet");
                }
            }
        }

        [DataMember(Name = "?sW")]
        public string DepthOfField
        {
            get => depthOfField;
            set
            {
                if ((ReferenceEquals(depthOfField, value) != true))
                {
                    depthOfField = value;
                    OnPropertyChanged("DepthOfField");
                }
            }
        }

        [DataMember(Name = "wKU")]
        public float DepthOfFieldStrengthSetting
        {
            get => depthOfFieldStrengthSetting;
            set
            {
                if ((ReferenceEquals(depthOfFieldStrengthSetting, value) != true))
                {
                    depthOfFieldStrengthSetting = value;
                    OnPropertyChanged("DepthOfFieldStrengthSetting");
                }
            }
        }

        [DataMember(Name = "RUO")]
        public float DepthOfFieldDistance
        {
            get => depthOfFieldDistance;
            set
            {
                if ((ReferenceEquals(depthOfFieldDistance, value) != true))
                {
                    depthOfFieldDistance = value;
                    OnPropertyChanged("DepthOfFieldDistance");
                }
            }
        }

        [DataMember(Name = "yuu")]
        public float DepthOfFieldDistanceSpace
        {
            get => depthOfFieldDistanceSpace;
            set
            {
                if ((ReferenceEquals(depthOfFieldDistanceSpace, value) != true))
                {
                    depthOfFieldDistanceSpace = value;
                    OnPropertyChanged("DepthOfFieldDistanceSpace");
                }
            }
        }

        [DataMember(Name = "n0h")]
        public float HalfFocalPlaneDepth
        {
            get => halfFocalPlaneDepth;
            set
            {
                if ((ReferenceEquals(halfFocalPlaneDepth, value) != true))
                {
                    halfFocalPlaneDepth = value;
                    OnPropertyChanged("HalfFocalPlaneDepth");
                }
            }
        }

        [DataMember(Name = ">xF")]
        public float HalfFocalPlaneDepthSpace
        {
            get => halfFocalPlaneDepthSpace;
            set
            {
                if ((ReferenceEquals(halfFocalPlaneDepthSpace, value) != true))
                {
                    halfFocalPlaneDepthSpace = value;
                    OnPropertyChanged("HalfFocalPlaneDepthSpace");
                }
            }
        }

        [DataMember(Name = "L85")]
        public float Vignette
        {
            get => vignette;
            set
            {
                if ((ReferenceEquals(vignette, value) != true))
                {
                    vignette = value;
                    OnPropertyChanged("Vignette");
                }
            }
        }

        [DataMember(Name = "HJQ")]
        public int Filter
        {
            get => filter;
            set
            {
                if ((ReferenceEquals(filter, value) != true))
                {
                    filter = value;
                    OnPropertyChanged("Filter");
                }
            }
        }
    }
}