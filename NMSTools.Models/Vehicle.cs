using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Vehicle : ModelBase
    {
        private string name;
        private ProceduralObject resource;
        private Catalog inventory;
        private Catalog inventoryTech;
        private CatalogLayout inventoryLayout;
        private string location;
        private float[] position;
        private float[] direction;

        [DataMember(Name = "NKm")]
        public string Name
        {
            get => name;
            set
            {
                if ((ReferenceEquals(name, value) != true))
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [DataMember(Name = "NTx")]
        public ProceduralObject Resource
        {
            get => resource;
            set
            {
                if ((ReferenceEquals(resource, value) != true))
                {
                    resource = value;
                    OnPropertyChanged("Resource");
                }
            }
        }

        [DataMember(Name = ";l5")]
        public Catalog Inventory
        {
            get => inventory;
            set
            {
                if ((ReferenceEquals(inventory, value) != true))
                {
                    inventory = value;
                    OnPropertyChanged("Inventory");
                }
            }
        }

        [DataMember(Name = "PMT")]
        public Catalog InventoryTech
        {
            get => inventoryTech;
            set
            {
                if ((ReferenceEquals(inventoryTech, value) != true))
                {
                    inventoryTech = value;
                    OnPropertyChanged("InventoryTech");
                }
            }
        }

        [DataMember(Name = "pMa")]
        public CatalogLayout InventoryLayout
        {
            get => inventoryLayout;
            set
            {
                if ((ReferenceEquals(inventoryLayout, value) != true))
                {
                    inventoryLayout = value;
                    OnPropertyChanged("CatalogLayout");
                }
            }
        }

        [DataMember(Name = "YTa")]
        public string Location
        {
            get => location;
            set
            {
                if ((ReferenceEquals(location, value) != true))
                {
                    location = value;
                    OnPropertyChanged("Location");
                }
            }
        }

        [DataMember(Name = "wMC")]
        public float[] Position
        {
            get => position;
            set
            {
                if ((ReferenceEquals(position, value) != true))
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        [DataMember(Name = "l?l")]
        public float[] Direction
        {
            get => direction;
            set
            {
                if ((ReferenceEquals(direction, value) != true))
                {
                    direction = value;
                    OnPropertyChanged("Direction");
                }
            }
        }
    }
}