using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class GalaxyCoordinates : ModelBase
	{
		private int voxelX;
		private int voxelY;
		private int voxelZ;
		private int solarSystemIndex;
		private short planetIndex;

        [JsonProperty("dZj")]
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

        [JsonProperty("IyE")]
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

        [JsonProperty("uXE")]
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

        [JsonProperty("vby")]
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

        [JsonProperty("jsv")]
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
