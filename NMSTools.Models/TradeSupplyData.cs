using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class TradeSupplyData : ModelBase
    {
        private string galacticAddress;
        private float supply;
        private float demand;
        private string product;
        private int timestamp;

        [JsonProperty("oZw")]
        public string GalacticAddress
        {
            get => galacticAddress; 
            set
            {
                if ((ReferenceEquals(galacticAddress, value) != true))
                {
                    galacticAddress = value;
                    OnPropertyChanged("GalacticAddress");
                }
            }
        }

        [JsonProperty("Iu7")]
        public float Supply
        {
            get => supply; 
            set
            {
                if ((ReferenceEquals(supply, value) != true))
                {
                    supply = value;
                    OnPropertyChanged("Supply");
                }
            }
        }

        [JsonProperty("pfp")]
        public float Demand
        {
            get => demand;
            set
            {
                if ((ReferenceEquals(demand, value) != true))
                {
                    demand = value;
                    OnPropertyChanged("Demand");
                }
            }
        }

        [JsonProperty("JWK")]
        public string Product
        {
            get => product;
            set
            {
                if ((ReferenceEquals(product, value) != true))
                {
                    product = value;
                    OnPropertyChanged("Product");
                }
            }
        }

        [JsonProperty("b1:")]
        public int Timestamp
        {
            get => timestamp;
            set
            {
                if ((ReferenceEquals(timestamp, value) != true))
                {
                    timestamp = value;
                    OnPropertyChanged("Timestamp");
                }
            }
        }
    }
}
