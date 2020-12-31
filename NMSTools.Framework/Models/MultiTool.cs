using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class MultiTool : ModelBase
    {
        private CatalogLayout layout;
        private Catalog store;
        private object[] seed;  //todo: replace with strong type
        private string name;
        private bool isLarge;
        private int primaryMode;
        private int secondaryMode;

        [JsonProperty("CA4")]
        public CatalogLayout Layout
        {
            get => layout;
            set
            {
                if (ReferenceEquals(layout, value) != true)
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
                if (ReferenceEquals(store, value) != true)
                {
                    store = value;
                    OnPropertyChanged("Store");
                }
            }
        }

        [JsonProperty("@EL")]
        public object[] Seed
        {
            get => seed;
            set
            {
                if (ReferenceEquals(seed, value) != true)
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
                if (ReferenceEquals(name, value) != true)
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
                if (ReferenceEquals(isLarge, value) != true)
                {
                    isLarge = value;
                    OnPropertyChanged("IsLarge");
                }
            }
        }

        [JsonProperty("qVG")]
        public int PrimaryMode
        {
            get => primaryMode;
            set
            {
                if (ReferenceEquals(primaryMode, value) != true)
                {
                    primaryMode = value;
                    OnPropertyChanged("PrimaryMode");
                }
            }
        }

        [JsonProperty("jl;")]
        public int SecondaryMode
        {
            get => secondaryMode;
            set
            {
                if (ReferenceEquals(secondaryMode, value) != true)
                {
                    secondaryMode = value;
                    OnPropertyChanged("SecondaryMode");
                }
            }
        }
    }
}