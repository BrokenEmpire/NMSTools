using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Discovery : ModelBase
    {
        private int reserveStore;
        private int reserveManaged;
        private StoreRecord store;
        private AvailableDiscovery[] available;
        private object[] enqueued;

        [DataMember(Name = "fgt")]
        public int ReserveStore
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

        [DataMember(Name = "xxK")]
        public int ReserveManaged
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

        [DataMember(Name = "OsQ")]
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

        [DataMember(Name = "brV")]
        public AvailableDiscovery[] Available
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

        [DataMember(Name = ";FZ")]
        public object[] Enqueued
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