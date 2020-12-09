using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class TradeSupplyData : ModelBase
    {
        private string galacticAddress;
        private float supply;
        private float demand;
        private string product;
        private int timestamp;

        [DataMember(Name = "oZw")]
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

        [DataMember(Name = "Iu7")]
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

        [DataMember(Name = "pfp")]
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

        [DataMember(Name = "JWK")]
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

        [DataMember(Name = "b1:")]
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