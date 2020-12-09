using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class CatalogType : ModelBase
    {
        private string inventoryClass;

        [DataMember(Name = "1o6")]
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