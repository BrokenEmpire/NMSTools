using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class Discovery : ModelBase
	{
		private long reserveStore;
		private long reserveManaged;
		private StoreRecord store;
		private ObservableCollection<AvailableDiscovery> available;
		private ObservableCollection<object> enqueued;

        [JsonProperty("fgt")]
		public long ReserveStore
		{
			get => reserveStore;
			set
			{
				if ((ReferenceEquals(reserveStore, value) != true))
				{
					reserveStore = value;
					OnPropertyChanged("ReserveStore");
				}
			}
		}

        [JsonProperty("xxK")]
		public long ReserveManaged
		{
			get => reserveManaged;
			set
			{
				if ((ReferenceEquals(reserveManaged, value) != true))
				{
					reserveManaged = value;
					OnPropertyChanged("ReserveManaged");
				}
			}
		}

        [JsonProperty("OsQ")]
		public StoreRecord Store
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

        [JsonProperty("brV")]
		public ObservableCollection<AvailableDiscovery> Available
		{
			get => available;
			set
			{
				if ((ReferenceEquals(available, value) != true))
				{
					available = value;
					OnPropertyChanged("Available");
				}
			}
		}

        [JsonProperty(";FZ")]
		public ObservableCollection<object> Enqueued
		{
			get => enqueued;
			set
			{
				if ((ReferenceEquals(enqueued, value) != true))
				{
					enqueued = value;
					OnPropertyChanged("Enqueued");
				}
			}
		}

	}
}
