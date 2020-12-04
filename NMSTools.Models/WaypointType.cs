using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class WaypointType : ModelBase
	{
		private string galaxyWaypointType;

        [JsonProperty("S8b")]
		public string GalaxyWaypointType
		{
			get => galaxyWaypointType;
			set
			{
				if ((ReferenceEquals(galaxyWaypointType, value) != true))
				{
					galaxyWaypointType = value;
					OnPropertyChanged("GalaxyWaypointType");
				}
			}
		}
	}
}
