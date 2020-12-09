using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PortalData : ModelBase
    {
        private UniverseCoordinates universeAddress;
        private float[] position;
        private float[] facing;
        private string teleporterType;
        private string name;
        private bool calcWarpOffset;
        private bool isFeatured;

        [DataMember(Name = "yhJ")]
        public UniverseCoordinates UniverseAddress
        {
            get => universeAddress;
            set
            {
                if ((ReferenceEquals(universeAddress, value) != true))
                {
                    universeAddress = value;
                    OnPropertyChanged("UniverseAddress");
                }
            }
        }

        [DataMember(Name = "wMC")]
        public float[] Position
        {
            get => position;
            set
            {
                if ((ReferenceEquals(position, value) != true))
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        [DataMember(Name = "gk4")]
        public float[] Facing
        {
            get => facing;
            set
            {
                if ((ReferenceEquals(facing, value) != true))
                {
                    facing = value;
                    OnPropertyChanged("Facing");
                }
            }
        }

        [DataMember(Name = "iAF")]
        public string TeleporterType
        {
            get => teleporterType;
            set
            {
                if ((ReferenceEquals(teleporterType, value) != true))
                {
                    teleporterType = value;
                    OnPropertyChanged("TeleporterType");
                }
            }
        }

        [DataMember(Name = "NKm")]
        public string Name
        {
            get => name;
            set
            {
                if ((ReferenceEquals(name, value) != true))
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [DataMember(Name = "a>;")]
        public bool CalcWarpOffset
        {
            get => calcWarpOffset;
            set
            {
                if ((ReferenceEquals(calcWarpOffset, value) != true))
                {
                    calcWarpOffset = value;
                    OnPropertyChanged("CalcWarpOffset");
                }
            }
        }

        [DataMember(Name = "tww")]
        public bool IsFeatured
        {
            get => isFeatured;
            set
            {
                if ((ReferenceEquals(isFeatured, value) != true))
                {
                    isFeatured = value;
                    OnPropertyChanged("IsFeatured");
                }
            }
        }
    }
}