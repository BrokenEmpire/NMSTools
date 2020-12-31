using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    [JsonObject]
    public class InteractionData : ModelBase
    {
        private Catalog inventoryContainer;
        private ulong lastUpdateTimestamp;
        private ulong lastCompletedTimestamp;
        private ulong lastBrokenTimestamp;
        private double[] damageTimers;
        private uint flags;

        [JsonProperty("=yU")]
        public Catalog InventoryContainer
        {
            get => inventoryContainer;
            set
            {
                if (ReferenceEquals(inventoryContainer, value) != true)
                {
                    inventoryContainer = value;
                    OnPropertyChanged("InventoryContainer");
                }
            }
        }

        [JsonProperty("wx7")]
        public ulong LastUpdateTimestamp
        {
            get => lastUpdateTimestamp;
            set
            {
                if (ReferenceEquals(lastUpdateTimestamp, value) != true)
                {
                    lastUpdateTimestamp = value;
                    OnPropertyChanged("LastUpdateTimestamp");
                }
            }
        }

        [JsonProperty("eyv")]
        public ulong LastCompletedTimestamp
        {
            get => lastCompletedTimestamp;
            set
            {
                if (ReferenceEquals(lastCompletedTimestamp, value) != true)
                {
                    lastCompletedTimestamp = value;
                    OnPropertyChanged("LastCompletedTimestamp");
                }
            }
        }

        [JsonProperty("FML")]
        public ulong LastBrokenTimestamp
        {
            get => lastBrokenTimestamp;
            set
            {
                if (ReferenceEquals(lastBrokenTimestamp, value) != true)
                {
                    lastBrokenTimestamp = value;
                    OnPropertyChanged("LastBrokenTimestamp");
                }
            }
        }

        [JsonProperty("4>;")]
        public double[] DamageTimers
        {
            get => damageTimers;
            set
            {
                if (ReferenceEquals(damageTimers, value) != true)
                {
                    damageTimers = value;
                    OnPropertyChanged("DamageTimers");
                }
            }
        }

        [JsonProperty("XV5")]
        public uint Flags
        {
            get => flags;
            set
            {
                if (ReferenceEquals(flags, value) != true)
                {
                    flags = value;
                    OnPropertyChanged("Flags");
                }
            }
        }
    }
}