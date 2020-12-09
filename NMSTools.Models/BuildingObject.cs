using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class BuildingObject : ModelBase
    {
        private int timestamp;
        private string objectID;
        private string galacticAddress;
        private string regionSeed;
        private int userData;
        private decimal[] position;
        private decimal[] up;
        private decimal[] at;

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

        [DataMember(Name = "r<7")]
        public string ObjectID
        {
            get => objectID;
            set
            {
                if ((ReferenceEquals(objectID, value) != true))
                {
                    objectID = value;
                    OnPropertyChanged("ObjectID");
                }
            }
        }

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

        [DataMember(Name = "ofi")]
        public string RegionSeed
        {
            get => regionSeed;
            set
            {
                if ((ReferenceEquals(regionSeed, value) != true))
                {
                    regionSeed = value;
                    OnPropertyChanged("RegionSeed");
                }
            }
        }

        [DataMember(Name = "CVX")]
        public int UserData
        {
            get => userData;
            set
            {
                if ((ReferenceEquals(userData, value) != true))
                {
                    userData = value;
                    OnPropertyChanged("UserData");
                }
            }
        }

        [DataMember(Name = "wMC")]
        public decimal[] Position
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

        [DataMember(Name = "wJ0")]
        public decimal[] Up
        {
            get => up; set
            {
                if ((ReferenceEquals(up, value) != true))
                {
                    up = value;
                    OnPropertyChanged("Up");
                }
            }
        }

        [DataMember(Name = "aNu")]
        public decimal[] At
        {
            get => at;
            set
            {
                if ((ReferenceEquals(at, value) != true))
                {
                    at = value;
                    OnPropertyChanged("At");
                }
            }
        }
    }
}