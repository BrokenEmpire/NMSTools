using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
   
    public class Vehicle : ModelBase
    {
        private string name;
        private ProceduralObject resource;
        private Catalog inventory;
        private Catalog inventoryTech;
        private CatalogLayout inventoryLayout;
        private object location;
        private float[] position;
        private float[] direction;

        [JsonProperty("NKm")]
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

        [JsonProperty("NTx")]
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

        [JsonProperty(";l5")]
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

        [JsonProperty("PMT")]
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

        [JsonProperty("pMa")]
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

        [JsonProperty("YTa")]
        public object Location
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

        [JsonProperty("wMC")]
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

        [JsonProperty("l?l")]
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