using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class SlotDescription : ModelBase
    {
        private string inventoryType;

        [DataMember(Name = "elv")]
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