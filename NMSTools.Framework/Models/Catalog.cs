using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    public class Catalog : ModelBase
    {
        private Slot[] slots;
        private SlotIndex[] validSlotIndices;
        private CatalogType classType;
        private int substanceMaxStorageMultiplier;
        private int productMaxStorageMultiplier;
        private StatData[] baseStatValues;
        private bool[] specialSlots;
        private int width;
        private int height;
        private bool isCool;
        private string name;
        private int version;

        [JsonProperty(":No")]
        public Slot[] Slots
        {
            get => slots;
            set
            {
                if (ReferenceEquals(slots, value) != true)
                {
                    slots = value;
                    OnPropertyChanged("Slots");
                }
            }
        }

        [JsonProperty("hl?")]
        public SlotIndex[] ValidSlotIndices
        {
            get => validSlotIndices;
            set
            {
                if (ReferenceEquals(validSlotIndices, value) != true)
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
                if (ReferenceEquals(classType, value) != true)
                {
                    classType = value;
                    OnPropertyChanged("ClassType");
                }
            }
        }

        [JsonProperty("0H2")]
        public int SubstanceMaxStorageMultiplier
        {
            get => substanceMaxStorageMultiplier;
            set
            {
                if (ReferenceEquals(substanceMaxStorageMultiplier, value) != true)
                {
                    substanceMaxStorageMultiplier = value;
                    OnPropertyChanged("SubstanceMaxStorageMultiplier");
                }
            }
        }

        [JsonProperty("cTY")]
        public int ProductMaxStorageMultiplier
        {
            get => productMaxStorageMultiplier;
            set
            {
                if (ReferenceEquals(productMaxStorageMultiplier, value) != true)
                {
                    productMaxStorageMultiplier = value;
                    OnPropertyChanged("ProductMaxStorageMultiplier");
                }
            }
        }

        [JsonProperty("@bB")]
        public StatData[] BaseStatValues
        {
            get => baseStatValues;
            set
            {
                if (ReferenceEquals(baseStatValues, value) != true)
                {
                    baseStatValues = value;
                    OnPropertyChanged("BaseStatValues");
                }
            }
        }

        [JsonProperty("MMm")]
        public bool[] SpecialSlots
        {
            get => specialSlots;
            set
            {
                if (ReferenceEquals(specialSlots, value) != true)
                {
                    specialSlots = value;
                    OnPropertyChanged("SpecialSlots");
                }
            }
        }

        [JsonProperty("=Tb")]
        public int Width
        {
            get => width;
            set
            {
                if (ReferenceEquals(width, value) != true)
                {
                    width = value;
                    OnPropertyChanged("Width");
                }
            }
        }

        [JsonProperty("N9>")]
        public int Height
        {
            get => height;
            set
            {
                if (ReferenceEquals(height, value) != true)
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
                if (ReferenceEquals(isCool, value) != true)
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
                if (ReferenceEquals(name, value) != true)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [JsonProperty("F2P")]
        public int Version
        {
            get => version;
            set
            {
                if (ReferenceEquals(version, value) != true)
                {
                    version = value;
                    OnPropertyChanged("Version");
                }
            }
        }
    }
}