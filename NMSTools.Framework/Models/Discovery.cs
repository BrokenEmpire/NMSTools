using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class Discovery : ModelBase
    {
        private int reserveStore;
        private int reserveManaged;
        private StoreRecord store;
        private AvailableDiscovery[] available;
        private object[] enqueued;  //todo: strong type

        [JsonProperty("fgt")]
        public int ReserveStore
        {
            get => reserveStore;
            set
            {
                if (ReferenceEquals(reserveStore, value) != true)
                {
                    reserveStore = value;
                    OnPropertyChanged("ReserveStore");
                }
            }
        }

        [JsonProperty("xxK")]
        public int ReserveManaged
        {
            get => reserveManaged;
            set
            {
                if (ReferenceEquals(reserveManaged, value) != true)
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
                if (ReferenceEquals(store, value) != true)
                {
                    store = value;
                    OnPropertyChanged("Store");
                }
            }
        }

        [JsonProperty("brV")]
        public AvailableDiscovery[] Available
        {
            get => available;
            set
            {
                if (ReferenceEquals(available, value) != true)
                {
                    available = value;
                    OnPropertyChanged("Available");
                }
            }
        }

        [JsonProperty(";FZ")]
        public object[] Enqueued
        {
            get => enqueued;
            set
            {
                if (ReferenceEquals(enqueued, value) != true)
                {
                    enqueued = value;
                    OnPropertyChanged("Enqueued");
                }
            }
        }
    }
}