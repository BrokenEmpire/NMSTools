using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
      
    [JsonObject]
    public class KeyAction : ModelBase
    {
        private Action action;
        private string id;
        private int number;
        private SlotIndex inventoryIndex;

        [JsonProperty("TD8")]
        public Action Action
        {
            get => action;
            set
            {
                if (ReferenceEquals(action, value) != true)
                {
                    action = value;
                    OnPropertyChanged("Action");
                }
            }
        }

        [JsonProperty("b2n")]
        public string Id
        {
            get => id;
            set
            {
                if (ReferenceEquals(id, value) != true)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        [JsonProperty("Y5p")]
        public int Number
        {
            get => number;
            set
            {
                if (ReferenceEquals(number, value) != true)
                {
                    number = value;
                    OnPropertyChanged("Number");
                }
            }
        }

        [JsonProperty("WX8")]
        public SlotIndex InventoryIndex
        {
            get => inventoryIndex;
            set
            {
                if (ReferenceEquals(inventoryIndex, value) != true)
                {
                    inventoryIndex = value;
                    OnPropertyChanged("InventoryIndex");
                }
            }
        }
    }
}