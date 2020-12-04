using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class PortalReturnAddress : ModelBase
	{
		private UniverseCoordinates universeAddress;
		private ObservableCollection<object> position;
		private ObservableCollection<object> facing;
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
				if ((ReferenceEquals(universeAddress, value) != true))
				{
					universeAddress = value;
					OnPropertyChanged("UniverseAddress");
				}
			}
		}

        [JsonProperty("wMC")]
		public ObservableCollection<object> Position
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

        [JsonProperty("gk4")]
		public ObservableCollection<object> Facing
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

        [JsonProperty("iAF")]
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

        [JsonProperty("NKm")]
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

        [JsonProperty("a>;")]
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

        [JsonProperty("tww")]
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
