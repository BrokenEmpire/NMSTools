using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class GalaxyCoordinates : ModelBase
    {
        private int voxelX;
        private int voxelY;
        private int voxelZ;
        private int solarSystemIndex;
        private short planetIndex;

        [DataMember(Name = "dZj")]
        public int VoxelX
        {
            get => voxelX;
            set
            {
                if ((ReferenceEquals(voxelX, value) != true))
                {
                    voxelX = value;
                    OnPropertyChanged("VoxelX");
                }
            }
        }

        [DataMember(Name = "IyE")]
        public int VoxelY
        {
            get => voxelY;
            set
            {
                if ((ReferenceEquals(voxelY, value) != true))
                {
                    voxelY = value;
                    OnPropertyChanged("VoxelY");
                }
            }
        }

        [DataMember(Name = "uXE")]
        public int VoxelZ
        {
            get => voxelZ;
            set
            {
                if ((ReferenceEquals(voxelZ, value) != true))
                {
                    voxelZ = value;
                    OnPropertyChanged("VoxelZ");
                }
            }
        }

        [DataMember(Name = "vby")]
        public int SolarSystemIndex
        {
            get => solarSystemIndex;
            set
            {
                if ((ReferenceEquals(solarSystemIndex, value) != true))
                {
                    solarSystemIndex = value;
                    OnPropertyChanged("SolarSystemIndex");
                }
            }
        }

        [DataMember(Name = "jsv")]
        public short PlanetIndex
        {
            get => planetIndex;
            set
            {
                if ((ReferenceEquals(planetIndex, value) != true))
                {
                    planetIndex = value;
                    OnPropertyChanged("PlanetIndex");
                }
            }
        }
    }
}