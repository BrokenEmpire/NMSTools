using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Slot : ModelBase
    {
        private SlotDescription slotType;
        private string id;
        private int amount;
        private int maxAmount;
        private float damageFactor;
        private bool fullyInstalled;
        private SlotIndex index;

        [DataMember(Name = "Vn8")]
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

        [DataMember(Name = "b2n")]
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

        [DataMember(Name = "1o9")]
        public int Amount
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

        [DataMember(Name = "F9q")]
        public int MaxAmount
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

        [DataMember(Name = "eVk")]
        public float DamageFactor
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

        [DataMember(Name = "b76")]
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

        [DataMember(Name = "3ZH")]
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