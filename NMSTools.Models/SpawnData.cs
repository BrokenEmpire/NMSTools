using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class SpawnData : ModelBase
	{
		private float[] playerPositionInSystem;
		private float[] playerTransformAt;
		private float[] shipPositionInSystem;
		private float[] shipTransformAt;
		private string lastKnownPlayerState;
		private float[] freighterPositionInSystem;
		private float[] freighterTransformAt;
		private float[] freighterTransformUp;
		private float[] abandonedFreighterPositionInSystem;
		private float[] abandonedFreighterTransformAt;
		private float[] abandonedFreighterTransformUp;

        [JsonProperty("mEH")]
		public float[] PlayerPositionInSystem
		{
			get => playerPositionInSystem;
			set
			{
				if ((ReferenceEquals(playerPositionInSystem, value) != true))
				{
					playerPositionInSystem = value;
					OnPropertyChanged("PlayerPositionInSystem");
				}
			}
		}

        [JsonProperty("l2U")]
		public float[] PlayerTransformAt
		{
			get => playerTransformAt;
			set
			{
				if ((ReferenceEquals(playerTransformAt, value) != true))
				{
					playerTransformAt = value;
					OnPropertyChanged("PlayerTransformAt");
				}
			}
		}

        [JsonProperty("tnP")]
		public float[] ShipPositionInSystem
		{
			get => shipPositionInSystem;
			set
			{
				if ((ReferenceEquals(shipPositionInSystem, value) != true))
				{
					shipPositionInSystem = value;
					OnPropertyChanged("ShipPositionInSystem");
				}
			}
		}

        [JsonProperty("l4H")]
		public float[] ShipTransformAt
		{
			get => shipTransformAt;
			set
			{
				if ((ReferenceEquals(shipTransformAt, value) != true))
				{
					shipTransformAt = value;
					OnPropertyChanged("ShipTransformAt");
				}
			}
		}

        [JsonProperty("jk4")]
		public string LastKnownPlayerState
		{
			get => lastKnownPlayerState;
			set
			{
				if ((ReferenceEquals(lastKnownPlayerState, value) != true))
				{
					lastKnownPlayerState = value;
					OnPropertyChanged("LastKnownPlayerState");
				}
			}
		}

        [JsonProperty("NGn")]
		public float[] FreighterPositionInSystem
		{
			get => freighterPositionInSystem;
			set
			{
				if ((ReferenceEquals(freighterPositionInSystem, value) != true))
				{
					freighterPositionInSystem = value;
					OnPropertyChanged("FreighterPositionInSystem");
				}
			}
		}

        [JsonProperty("uAt")]
		public float[] FreighterTransformAt
		{
			get => freighterTransformAt;
			set
			{
				if ((ReferenceEquals(freighterTransformAt, value) != true))
				{
					freighterTransformAt = value;
					OnPropertyChanged("FreighterTransformAt");
				}
			}
		}

        [JsonProperty("5Sg")]
		public float[] FreighterTransformUp
		{
			get => freighterTransformUp;
			set
			{
				if ((ReferenceEquals(freighterTransformUp, value) != true))
				{
					freighterTransformUp = value;
					OnPropertyChanged("FreighterTransformUp");
				}
			}
		}

        [JsonProperty("Ovv")]
		public float[] AbandonedFreighterPositionInSystem
		{
			get => abandonedFreighterPositionInSystem;
			set
			{
				if ((ReferenceEquals(abandonedFreighterPositionInSystem, value) != true))
				{
					abandonedFreighterPositionInSystem = value;
					OnPropertyChanged("AbandonedFreighterPositionInSystem");
				}
			}
		}

        [JsonProperty("EkX")]
		public float[] AbandonedFreighterTransformAt
		{
			get => abandonedFreighterTransformAt;
			set
			{
				if ((ReferenceEquals(abandonedFreighterTransformAt, value) != true))
				{
					abandonedFreighterTransformAt = value;
					OnPropertyChanged("AbandonedFreighterTransformAt");
				}
			}
		}

        [JsonProperty("Bg3")]
		public float[] AbandonedFreighterTransformUp
		{
			get => abandonedFreighterTransformUp;
			set
			{
				if ((ReferenceEquals(abandonedFreighterTransformUp, value) != true))
				{
					abandonedFreighterTransformUp = value;
					OnPropertyChanged("AbandonedFreighterTransformUp");
				}
			}
		}

	}
}
