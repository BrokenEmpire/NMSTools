using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class PhotoSettings : ModelBase
    {
        private double fog;
        private double cloudAmount;
        private Vector4 sunDir;
        private bool sunDirSet;
        private double foV;
        private bool foVSet;
        private string depthOfField;
        private double depthOfFieldStrengthSetting;
        private double depthOfFieldDistance;
        private double depthOfFieldDistanceSpace;
        private double halfFocalPlaneDepth;
        private double halfFocalPlaneDepthSpace;
        private double vignette;
        private int filter;

        [JsonProperty("qAx")]
        public double Fog
        {
            get => fog;
            set
            {
                if (ReferenceEquals(fog, value) != true)
                {
                    fog = value;
                    OnPropertyChanged("Fog");
                }
            }
        }

        [JsonProperty("22a")]
        public double CloudAmount
        {
            get => cloudAmount;
            set
            {
                if (ReferenceEquals(cloudAmount, value) != true)
                {
                    cloudAmount = value;
                    OnPropertyChanged("CloudAmount");
                }
            }
        }

        [JsonProperty("qLk")]
        public Vector4 SunDir
        {
            get => sunDir;
            set
            {
                if (ReferenceEquals(sunDir, value) != true)
                {
                    sunDir = value;
                    OnPropertyChanged("SunDir");
                }
            }
        }

        [JsonProperty("OCG")]
        public bool SunDirSet
        {
            get => sunDirSet;
            set
            {
                if (ReferenceEquals(sunDirSet, value) != true)
                {
                    sunDirSet = value;
                    OnPropertyChanged("SunDirSet");
                }
            }
        }

        [JsonProperty("yGF")]
        public double FoV
        {
            get => foV;
            set
            {
                if (ReferenceEquals(foV, value) != true)
                {
                    foV = value;
                    OnPropertyChanged("FoV");
                }
            }
        }

        [JsonProperty("ARP")]
        public bool FoVSet
        {
            get => foVSet;
            set
            {
                if (ReferenceEquals(foVSet, value) != true)
                {
                    foVSet = value;
                    OnPropertyChanged("FoVSet");
                }
            }
        }

        [JsonProperty("?sW")]
        public string DepthOfField
        {
            get => depthOfField;
            set
            {
                if (ReferenceEquals(depthOfField, value) != true)
                {
                    depthOfField = value;
                    OnPropertyChanged("DepthOfField");
                }
            }
        }

        [JsonProperty("wKU")]
        public double DepthOfFieldStrengthSetting
        {
            get => depthOfFieldStrengthSetting;
            set
            {
                if (ReferenceEquals(depthOfFieldStrengthSetting, value) != true)
                {
                    depthOfFieldStrengthSetting = value;
                    OnPropertyChanged("DepthOfFieldStrengthSetting");
                }
            }
        }

        [JsonProperty("RUO")]
        public double DepthOfFieldDistance
        {
            get => depthOfFieldDistance;
            set
            {
                if (ReferenceEquals(depthOfFieldDistance, value) != true)
                {
                    depthOfFieldDistance = value;
                    OnPropertyChanged("DepthOfFieldDistance");
                }
            }
        }

        [JsonProperty("yuu")]
        public double DepthOfFieldDistanceSpace
        {
            get => depthOfFieldDistanceSpace;
            set
            {
                if (ReferenceEquals(depthOfFieldDistanceSpace, value) != true)
                {
                    depthOfFieldDistanceSpace = value;
                    OnPropertyChanged("DepthOfFieldDistanceSpace");
                }
            }
        }

        [JsonProperty("n0h")]
        public double HalfFocalPlaneDepth
        {
            get => halfFocalPlaneDepth;
            set
            {
                if (ReferenceEquals(halfFocalPlaneDepth, value) != true)
                {
                    halfFocalPlaneDepth = value;
                    OnPropertyChanged("HalfFocalPlaneDepth");
                }
            }
        }

        [JsonProperty(">xF")]
        public double HalfFocalPlaneDepthSpace
        {
            get => halfFocalPlaneDepthSpace;
            set
            {
                if (ReferenceEquals(halfFocalPlaneDepthSpace, value) != true)
                {
                    halfFocalPlaneDepthSpace = value;
                    OnPropertyChanged("HalfFocalPlaneDepthSpace");
                }
            }
        }

        [JsonProperty("L85")]
        public double Vignette
        {
            get => vignette;
            set
            {
                if (ReferenceEquals(vignette, value) != true)
                {
                    vignette = value;
                    OnPropertyChanged("Vignette");
                }
            }
        }

        [JsonProperty("HJQ")]
        public int Filter
        {
            get => filter;
            set
            {
                if (ReferenceEquals(filter, value) != true)
                {
                    filter = value;
                    OnPropertyChanged("Filter");
                }
            }
        }
    }
}