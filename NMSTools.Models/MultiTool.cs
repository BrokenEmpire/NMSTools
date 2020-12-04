using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class MultiTool : ModelBase
	{
		private CatalogLayout layout;
		private Catalog store;
		private ObservableCollection<object> seed;
		private string name;
		private bool isLarge;
		private long primaryMode;
		private long secondaryMode;

        [JsonProperty("CA4")]
		public CatalogLayout Layout
		{
			get => layout;
			set
			{
				if ((ReferenceEquals(layout, value) != true))
				{
					layout = value;
					OnPropertyChanged("Layout");
				}
			}
		}

        [JsonProperty("OsQ")]
		public Catalog Store
		{
			get => store;
			set
			{
				if ((ReferenceEquals(store, value) != true))
				{
					store = value;
					OnPropertyChanged("Store");
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

        [JsonProperty("OGV")]
		public bool IsLarge
		{
			get => isLarge;
			set
			{
				if ((ReferenceEquals(isLarge, value) != true))
				{
					isLarge = value;
					OnPropertyChanged("IsLarge");
				}
			}
		}

        [JsonProperty("qVG")]
		public long PrimaryMode
		{
			get => primaryMode;
			set
			{
				if ((ReferenceEquals(primaryMode, value) != true))
				{
					primaryMode = value;
					OnPropertyChanged("PrimaryMode");
				}
			}
		}

        [JsonProperty("jl;")]
		public long SecondaryMode
		{
			get => secondaryMode;
			set
			{
				if ((ReferenceEquals(secondaryMode, value) != true))
				{
					secondaryMode = value;
					OnPropertyChanged("SecondaryMode");
				}
			}
		}

	}
}
