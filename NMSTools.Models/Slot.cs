using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Slot : ModelBase
    {
        private SlotDescription slotType;
        private string id;
        private long amount;
        private long maxAmount;
        private long damageFactor;
        private bool fullyInstalled;
        private SlotIndex index;

        [JsonProperty("Vn8")]
        public SlotDescription SlotType
        {
            get => slotType;
            set
            {
                if ((ReferenceEquals(slotType, value) != true))
                {
                    slotType = value;
                    OnPropertyChanged("SlotType");
                }
            }
        }

        [JsonProperty("b2n")]
        public string Id
        {
            get => id;
            set
            {
                if ((ReferenceEquals(id, value) != true))
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        [JsonProperty("1o9")]
        public long Amount
        {
            get => amount;
            set
            {
                if ((ReferenceEquals(amount, value) != true))
                {
                    amount = value;
                    OnPropertyChanged("Amount");
                }
            }
        }

        [JsonProperty("F9q")]
        public long MaxAmount
        {
            get => maxAmount;
            set
            {
                if ((ReferenceEquals(maxAmount, value) != true))
                {
                    maxAmount = value;
                    OnPropertyChanged("MaxAmount");
                }
            }
        }

        [JsonProperty("eVk")]
        public long DamageFactor
        {
            get => damageFactor;
            set
            {
                if ((ReferenceEquals(damageFactor, value) != true))
                {
                    damageFactor = value;
                    OnPropertyChanged("DamageFactor");
                }
            }
        }

        [JsonProperty("b76")]
        public bool FullyInstalled
        {
            get => fullyInstalled;
            set
            {
                if ((ReferenceEquals(fullyInstalled, value) != true))
                {
                    fullyInstalled = value;
                    OnPropertyChanged("FullyInstalled");
                }
            }
        }

        [JsonProperty("3ZH")]
        public SlotIndex Index
        {
            get => index;
            set
            {
                if ((ReferenceEquals(index, value) != true))
                {
                    index = value;
                    OnPropertyChanged("Index");
                }
            }
        }
    }
}