using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;
    
    [JsonObject]
    public class PortalData : ModelBase
    {
        private UniverseCoordinates universeAddress;
        private Vector3 position;
        private Vector3 facing;
        private string teleporterType;
        private string name;
        private bool calcWarpOffset;
        private bool isFeatured;

        [JsonProperty("yhJ")]
        public UniverseCoordinates UniverseAddress
        {
            get => universeAddress;
            set
            {
                if (ReferenceEquals(universeAddress, value) != true)
                {
                    universeAddress = value;
                    OnPropertyChanged("UniverseAddress");
                }
            }
        }

        [JsonProperty("wMC")]
        public Vector3 Position
        {
            get => position;
            set
            {
                if (ReferenceEquals(position, value) != true)
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        [JsonProperty("gk4")]
        public Vector3 Facing
        {
            get => facing;
            set
            {
                if (ReferenceEquals(facing, value) != true)
                {
                    facing = value;
                    OnPropertyChanged("Facing");
                }
            }
        }

        [JsonProperty("iAF")]
        public string TeleporterType
        {
            get => teleporterType;
            set
            {
                if (ReferenceEquals(teleporterType, value) != true)
                {
                    teleporterType = value;
                    OnPropertyChanged("TeleporterType");
                }
            }
        }

        [JsonProperty("NKm")]
        public string Name
        {
            get => name;
            set
            {
                if (ReferenceEquals(name, value) != true)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [JsonProperty("a>;")]
        public bool CalcWarpOffset
        {
            get => calcWarpOffset;
            set
            {
                if (ReferenceEquals(calcWarpOffset, value) != true)
                {
                    calcWarpOffset = value;
                    OnPropertyChanged("CalcWarpOffset");
                }
            }
        }

        [JsonProperty("tww")]
        public bool IsFeatured
        {
            get => isFeatured;
            set
            {
                if (ReferenceEquals(isFeatured, value) != true)
                {
                    isFeatured = value;
                    OnPropertyChanged("IsFeatured");
                }
            }
        }
    }
}