﻿using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class BuildingObject : ModelBase
    {
        private int timestamp;
        private string objectID;
        private object galacticAddress;
        private string regionSeed;
        private int userData;
        private decimal[] position;
        private decimal[] up;
        private decimal[] at;

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

        [JsonProperty("r<7")]
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

        [JsonProperty("oZw")]
        public object GalacticAddress
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

        [JsonProperty("ofi")]
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

        [JsonProperty("CVX")]
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

        [JsonProperty("wMC")]
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

        [JsonProperty("wJ0")]
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

        [JsonProperty("aNu")]
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