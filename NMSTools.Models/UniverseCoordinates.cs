using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class UniverseCoordinates : ModelBase
	{
		private int realityIndex;
		private GalaxyCoordinates galacticAddress;

        [JsonProperty("Iis")]
		public int RealityIndex
		{
			get => realityIndex;
			set
			{
				if ((ReferenceEquals(realityIndex, value) != true))
				{
					realityIndex = value;
					OnPropertyChanged("RealityIndex");
				}
			}
		}

        [JsonProperty("oZw")]
		public GalaxyCoordinates GalacticAddress
		{
			get => galacticAddress;
			set
			{
				if ((ReferenceEquals(galacticAddress, value) != true))
				{
					galacticAddress = value;
					OnPropertyChanged("GalacticAddress");
				}
			}
		}

	}
}
