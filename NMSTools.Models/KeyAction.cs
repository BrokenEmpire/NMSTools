using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class KeyAction : ModelBase
    {
        private Action action;
        private string id;
        private int number;
        private SlotIndex inventoryIndex;

        [DataMember(Name = "TD8")]
        public Action Action
        {
            get => action;
            set
            {
                if ((ReferenceEquals(action, value) != true))
                {
                    action = value;
                    OnPropertyChanged("Action");
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

        [DataMember(Name = "Y5p")]
        public int Number
        {
            get => number;
            set
            {
                if ((ReferenceEquals(number, value) != true))
                {
                    number = value;
                    OnPropertyChanged("Number");
                }
            }
        }

        [DataMember(Name = "WX8")]
        public SlotIndex InventoryIndex
        {
            get => inventoryIndex;
            set
            {
                if ((ReferenceEquals(inventoryIndex, value) != true))
                {
                    inventoryIndex = value;
                    OnPropertyChanged("InventoryIndex");
                }
            }
        }
    }
}