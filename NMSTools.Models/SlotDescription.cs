using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class SlotDescription : ModelBase
    {
        private string inventoryType;

        [JsonProperty("elv")]
        public string InventoryType
        {
            get => inventoryType;
            set
            {
                if ((ReferenceEquals(inventoryType, value) != true))
                {
                    inventoryType = value;
                    OnPropertyChanged("InventoryType");
                }
            }
        }
    }
}