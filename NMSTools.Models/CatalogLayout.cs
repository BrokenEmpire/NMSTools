using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class CatalogLayout : ModelBase
	{
		private long slots;
		private ObservableCollection<object> seed;
		private long level;

        [JsonProperty(":No")]
		public long Slots
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

        [JsonProperty("@EL")]
		public ObservableCollection<object> Seed
		{
			get => seed;
			set
			{
				if ((ReferenceEquals(seed, value) != true))
				{
					seed = value;
					OnPropertyChanged("Seed");
				}
			}
		}

        [JsonProperty("9;o")]
		public long Level
		{
			get => level;
			set
			{
				if ((ReferenceEquals(level, value) != true))
				{
					level = value;
					OnPropertyChanged("Level");
				}
			}
		}

	}
}
