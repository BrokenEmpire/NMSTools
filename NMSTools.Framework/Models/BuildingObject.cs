using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class BuildingObject : ModelBase
    {
        private ulong timestamp;
        private string objectID;
        private object galacticAddress;  //todo: strong type
        private string regionSeed;
        private int userData;
        private Vector3 position;
        private Vector3 up;
        private Vector3 at;

        [JsonProperty("b1:")]
        public ulong Timestamp
        {
            get => timestamp;
            set
            {
                if (ReferenceEquals(timestamp, value) != true)
                {
                    timestamp = value;
                    OnPropertyChanged("Timestamp");
                }
            }
        }

        [JsonProperty("r<7")]
        public string ObjectID
        {
            get => objectID;
            set
            {
                if (ReferenceEquals(objectID, value) != true)
                {
                    objectID = value;
                    OnPropertyChanged("ObjectID");
                }
            }
        }

        [JsonProperty("oZw")]
        public object GalacticAddress
        {
            get => galacticAddress;
            set
            {
                if (ReferenceEquals(galacticAddress, value) != true)
                {
                    galacticAddress = value;
                    OnPropertyChanged("GalacticAddress");
                }
            }
        }

        [JsonProperty("ofi")]
        public string RegionSeed
        {
            get => regionSeed;
            set
            {
                if (ReferenceEquals(regionSeed, value) != true)
                {
                    regionSeed = value;
                    OnPropertyChanged("RegionSeed");
                }
            }
        }

        [JsonProperty("CVX")]
        public int UserData
        {
            get => userData;
            set
            {
                if (ReferenceEquals(userData, value) != true)
                {
                    userData = value;
                    OnPropertyChanged("UserData");
                }
            }
        }

        [JsonProperty("wMC")]
        public Vector3 Position
        {
            get => position;
            set
            {
                if (ReferenceEquals(position, value) != true)
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }

        [JsonProperty("wJ0")]
        public Vector3 Up
        {
            get => up; set
            {
                if (ReferenceEquals(up, value) != true)
                {
                    up = value;
                    OnPropertyChanged("Up");
                }
            }
        }

        [JsonProperty("aNu")]
        public Vector3 At
        {
            get => at;
            set
            {
                if (ReferenceEquals(at, value) != true)
                {
                    at = value;
                    OnPropertyChanged("At");
                }
            }
        }
    }
}