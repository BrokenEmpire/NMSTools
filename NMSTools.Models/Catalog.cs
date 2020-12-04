using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class Catalog : ModelBase
	{
		private ObservableCollection<Slot> slots;
		private ObservableCollection<SlotIndex> validSlotIndices;
		private CatalogType classType;
		private long substanceMaxStorageMultiplier;
		private long productMaxStorageMultiplier;
		private ObservableCollection<StatData> baseStatValues;
		private ObservableCollection<object> specialSlots;
		private long width;
		private long height;
		private bool isCool;
		private string name;
		private long version;

        [JsonProperty(":No")]
		public ObservableCollection<Slot> Slots
		{
			get => slots;
			set
			{
				if ((ReferenceEquals(slots, value) != true))
				{
					slots = value;
					OnPropertyChanged("Slots");
				}
			}
		}

        [JsonProperty("hl?")]
		public ObservableCollection<SlotIndex> ValidSlotIndices
		{
			get => validSlotIndices;
			set
			{
				if ((ReferenceEquals(validSlotIndices, value) != true))
				{
					validSlotIndices = value;
					OnPropertyChanged("ValidSlotIndices");
				}
			}
		}

        [JsonProperty("B@N")]
		public CatalogType ClassType
		{
			get => classType;
			set
			{
				if ((ReferenceEquals(classType, value) != true))
				{
					classType = value;
					OnPropertyChanged("ClassType");
				}
			}
		}

        [JsonProperty("0H2")]
		public long SubstanceMaxStorageMultiplier
		{
			get => substanceMaxStorageMultiplier;
			set
			{
				if ((ReferenceEquals(substanceMaxStorageMultiplier, value) != true))
				{
					substanceMaxStorageMultiplier = value;
					OnPropertyChanged("SubstanceMaxStorageMultiplier");
				}
			}
		}

        [JsonProperty("cTY")]
		public long ProductMaxStorageMultiplier
		{
			get => productMaxStorageMultiplier;
			set
			{
				if ((ReferenceEquals(productMaxStorageMultiplier, value) != true))
				{
					productMaxStorageMultiplier = value;
					OnPropertyChanged("ProductMaxStorageMultiplier");
				}
			}
		}

        [JsonProperty("@bB")]
		public ObservableCollection<StatData> BaseStatValues
		{
			get => baseStatValues;
			set
			{
				if ((ReferenceEquals(baseStatValues, value) != true))
				{
					baseStatValues = value;
					OnPropertyChanged("BaseStatValues");
				}
			}
		}

        [JsonProperty("MMm")]
		public ObservableCollection<object> SpecialSlots
		{
			get => specialSlots;
			set
			{
				if ((ReferenceEquals(specialSlots, value) != true))
				{
					specialSlots = value;
					OnPropertyChanged("SpecialSlots");
				}
			}
		}

        [JsonProperty("=Tb")]
		public long Width
		{
			get => width;
			set
			{
				if ((ReferenceEquals(width, value) != true))
				{
					width = value;
					OnPropertyChanged("Width");
				}
			}
		}

        [JsonProperty("N9>")]
		public long Height
		{
			get => height;
			set
			{
				if ((ReferenceEquals(height, value) != true))
				{
					height = value;
					OnPropertyChanged("Height");
				}
			}
		}

        [JsonProperty("iF:")]
		public bool IsCool
		{
			get => isCool;
			set
			{
				if ((ReferenceEquals(isCool, value) != true))
				{
					isCool = value;
					OnPropertyChanged("IsCool");
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

        [JsonProperty("F2P")]
		public long Version
		{
			get => version;
			set
			{
				if ((ReferenceEquals(version, value) != true))
				{
					version = value;
					OnPropertyChanged("Version");
				}
			}
		}

	}
}
