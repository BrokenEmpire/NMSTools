using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Catalog : ModelBase
    {
        private Slot[] slots;
        private SlotIndex[] validSlotIndices;
        private CatalogType classType;
        private int substanceMaxStorageMultiplier;
        private int productMaxStorageMultiplier;
        private StatData[] baseStatValues;
        private object[] specialSlots;
        private int width;
        private int height;
        private bool isCool;
        private string name;
        private int version;

        [DataMember(Name = ":No")]
        public Slot[] Slots
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

        [DataMember(Name = "hl?")]
        public SlotIndex[] ValidSlotIndices
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

        [DataMember(Name = "B@N")]
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

        [DataMember(Name = "0H2")]
        public int SubstanceMaxStorageMultiplier
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

        [DataMember(Name = "cTY")]
        public int ProductMaxStorageMultiplier
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

        [DataMember(Name = "@bB")]
        public StatData[] BaseStatValues
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

        [DataMember(Name = "MMm")]
        public object[] SpecialSlots
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

        [DataMember(Name = "=Tb")]
        public int Width
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

        [DataMember(Name = "N9>")]
        public int Height
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

        [DataMember(Name = "iF:")]
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

        [DataMember(Name = "F2P")]
        public int Version
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