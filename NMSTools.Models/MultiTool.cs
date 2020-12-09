using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class MultiTool : ModelBase
    {
        private CatalogLayout layout;
        private Catalog store;
        private object[] seed;
        private string name;
        private bool isLarge;
        private long primaryMode;
        private long secondaryMode;

        [DataMember(Name = "CA4")]
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

        [DataMember(Name = "OsQ")]
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

        [DataMember(Name = "@EL")]
        public object[] Seed
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

        [DataMember(Name = "NKm")]
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

        [DataMember(Name = "OGV")]
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

        [DataMember(Name = "qVG")]
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

        [DataMember(Name = "jl;")]
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