using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class SeasonData : ModelBase
	{
		private long startTimeUTC;
		private long endTimeUTC;
		private string title;
		private string subTitle;
		private string description;
		private GamePreset gameMode;
		private string seasonalUAOverride;
		private long uAOverrideValue;
		private ObservableCollection<object> weaponSeed;
		private ObservableCollection<object> shipSeed;
		private ShipTypeDescription shipType;
		private bool startNextToShip;
		private bool shipStartsDamaged;
		private bool allowMissionDetailMessages;
		private ObservableCollection<object> milestones;
		private ObservableCollection<object> secondaryStats;

        [JsonProperty("hyA")]
		public long StartTimeUTC
		{
			get => startTimeUTC;
			set
			{
				if ((ReferenceEquals(startTimeUTC, value) != true))
				{
					startTimeUTC = value;
					OnPropertyChanged("StartTimeUTC");
				}
			}
		}

        [JsonProperty("jqx")]
		public long EndTimeUTC
		{
			get => endTimeUTC;
			set
			{
				if ((ReferenceEquals(endTimeUTC, value) != true))
				{
					endTimeUTC = value;
					OnPropertyChanged("EndTimeUTC");
				}
			}
		}

        [JsonProperty("8wT")]
		public string Title
		{
			get => title;
			set
			{
				if ((ReferenceEquals(title, value) != true))
				{
					title = value;
					OnPropertyChanged("Title");
				}
			}
		}

        [JsonProperty("GLf")]
		public string SubTitle
		{
			get => subTitle;
			set
			{
				if ((ReferenceEquals(subTitle, value) != true))
				{
					subTitle = value;
					OnPropertyChanged("SubTitle");
				}
			}
		}

        [JsonProperty("myI")]
		public string Description
		{
			get => description;
			set
			{
				if ((ReferenceEquals(description, value) != true))
				{
					description = value;
					OnPropertyChanged("Description");
				}
			}
		}

        [JsonProperty("idA")]
		public GamePreset GameMode
		{
			get => gameMode;
			set
			{
				if ((ReferenceEquals(gameMode, value) != true))
				{
					gameMode = value;
					OnPropertyChanged("GameMode");
				}
			}
		}

        [JsonProperty("8sY")]
		public string SeasonalUAOverride
		{
			get => seasonalUAOverride;
			set
			{
				if ((ReferenceEquals(seasonalUAOverride, value) != true))
				{
					seasonalUAOverride = value;
					OnPropertyChanged("SeasonalUAOverride");
				}
			}
		}

        [JsonProperty("GPe")]
		public long UAOverrideValue
		{
			get => uAOverrideValue;
			set
			{
				if ((ReferenceEquals(uAOverrideValue, value) != true))
				{
					uAOverrideValue = value;
					OnPropertyChanged("UAOverrideValue");
				}
			}
		}

        [JsonProperty("@lX")]
		public ObservableCollection<object> WeaponSeed
		{
			get => weaponSeed;
			set
			{
				if ((ReferenceEquals(weaponSeed, value) != true))
				{
					weaponSeed = value;
					OnPropertyChanged("WeaponSeed");
				}
			}
		}

        [JsonProperty("3R<")]
		public ObservableCollection<object> ShipSeed
		{
			get => shipSeed;
			set
			{
				if ((ReferenceEquals(shipSeed, value) != true))
				{
					shipSeed = value;
					OnPropertyChanged("ShipSeed");
				}
			}
		}

        [JsonProperty("bLP")]
		public ShipTypeDescription ShipType
		{
			get => shipType;
			set
			{
				if ((ReferenceEquals(shipType, value) != true))
				{
					shipType = value;
					OnPropertyChanged("ShipType");
				}
			}
		}

        [JsonProperty("bnC")]
		public bool StartNextToShip
		{
			get => startNextToShip;
			set
			{
				if ((ReferenceEquals(startNextToShip, value) != true))
				{
					startNextToShip = value;
					OnPropertyChanged("StartNextToShip");
				}
			}
		}

        [JsonProperty("jA9")]
		public bool ShipStartsDamaged
		{
			get => shipStartsDamaged;
			set
			{
				if ((ReferenceEquals(shipStartsDamaged, value) != true))
				{
					shipStartsDamaged = value;
					OnPropertyChanged("ShipStartsDamaged");
				}
			}
		}

        [JsonProperty("5XZ")]
		public bool AllowMissionDetailMessages
		{
			get => allowMissionDetailMessages;
			set
			{
				if ((ReferenceEquals(allowMissionDetailMessages, value) != true))
				{
					allowMissionDetailMessages = value;
					OnPropertyChanged("AllowMissionDetailMessages");
				}
			}
		}

        [JsonProperty("kr6")]
		public ObservableCollection<object> Milestones
		{
			get => milestones;
			set
			{
				if ((ReferenceEquals(milestones, value) != true))
				{
					milestones = value;
					OnPropertyChanged("Milestones");
				}
			}
		}

        [JsonProperty(":Je")]
		public ObservableCollection<object> SecondaryStats
		{
			get => secondaryStats;
			set
			{
				if ((ReferenceEquals(secondaryStats, value) != true))
				{
					secondaryStats = value;
					OnPropertyChanged("SecondaryStats");
				}
			}
		}

	}
}
