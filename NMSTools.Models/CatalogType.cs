using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class CatalogType : ModelBase
    {
        private string inventoryClass;

        [JsonProperty("1o6")]
        public string InventoryClass
        {
            get => inventoryClass;
            set
            {
                if ((ReferenceEquals(inventoryClass, value) != true))
                {
                    inventoryClass = value;
                    OnPropertyChanged("InventoryClass");
                }
            }
        }
    }
}