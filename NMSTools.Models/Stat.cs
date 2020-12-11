﻿using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class Stat : ModelBase
    {
        private string groupId;
        private object address;
        private StatDetail[] stats;

        [JsonProperty(":rc")]
        public string GroupId
        {
            get => groupId;
            set
            {
                if ((ReferenceEquals(groupId, value) != true))
                {
                    groupId = value;
                    OnPropertyChanged("GroupId");
                }
            }
        }

        [JsonProperty("2Ak")]
        public object Address
        {
            get => address;
            set
            {
                if ((ReferenceEquals(address, value) != true))
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        [JsonProperty("gUR")]
        public StatDetail[] Stats
        {
            get => stats;
            set
            {
                if ((ReferenceEquals(stats, value) != true))
                {
                    stats = value;
                    OnPropertyChanged("Stats");
                }
            }
        }
    }
}