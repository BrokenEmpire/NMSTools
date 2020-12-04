using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class KnowledgetData : ModelBase
	{
		private ObservableCollection<Waypoint> waypoints;

        [JsonProperty("yRy")]
		public ObservableCollection<Waypoint> Waypoints
		{
			get => waypoints;
			set
			{
				if ((ReferenceEquals(waypoints, value) != true))
				{
					waypoints = value;
					OnPropertyChanged("Waypoints");
				}
			}
		}

	}
}
