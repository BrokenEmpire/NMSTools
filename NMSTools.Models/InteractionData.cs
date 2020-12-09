using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class InteractionData : ModelBase
    {
        private Catalog inventoryContainer;
        private int lastUpdateTimestamp;
        private int lastCompletedTimestamp;
        private int lastBrokenTimestamp;
        private float[] damageTimers;
        private int flags;

        [DataMember(Name = "=yU")]
        public Catalog InventoryContainer
        {
            get => inventoryContainer;
            set
            {
                if ((ReferenceEquals(inventoryContainer, value) != true))
                {
                    inventoryContainer = value;
                    OnPropertyChanged("InventoryContainer");
                }
            }
        }

        [DataMember(Name = "wx7")]
        public int LastUpdateTimestamp
        {
            get => lastUpdateTimestamp;
            set
            {
                if ((ReferenceEquals(lastUpdateTimestamp, value) != true))
                {
                    lastUpdateTimestamp = value;
                    OnPropertyChanged("LastUpdateTimestamp");
                }
            }
        }

        [DataMember(Name = "eyv")]
        public int LastCompletedTimestamp
        {
            get => lastCompletedTimestamp;
            set
            {
                if ((ReferenceEquals(lastCompletedTimestamp, value) != true))
                {
                    lastCompletedTimestamp = value;
                    OnPropertyChanged("LastCompletedTimestamp");
                }
            }
        }

        [DataMember(Name = "FML")]
        public int LastBrokenTimestamp
        {
            get => lastBrokenTimestamp;
            set
            {
                if ((ReferenceEquals(lastBrokenTimestamp, value) != true))
                {
                    lastBrokenTimestamp = value;
                    OnPropertyChanged("LastBrokenTimestamp");
                }
            }
        }

        [DataMember(Name = "4>;")]
        public float[] DamageTimers
        {
            get => damageTimers;
            set
            {
                if ((ReferenceEquals(damageTimers, value) != true))
                {
                    damageTimers = value;
                    OnPropertyChanged("DamageTimers");
                }
            }
        }

        [DataMember(Name = "XV5")]
        public int Flags
        {
            get => flags;
            set
            {
                if ((ReferenceEquals(flags, value) != true))
                {
                    flags = value;
                    OnPropertyChanged("Flags");
                }
            }
        }
    }
}