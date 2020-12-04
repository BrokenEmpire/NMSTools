using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

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
