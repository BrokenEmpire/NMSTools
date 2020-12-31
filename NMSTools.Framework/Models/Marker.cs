using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class Marker : ModelBase
    {
        private int table;
        private string markerEvent;
        private object galacticAddress;  //todo: strong type
        private object[] buildingSeed;  //todo: strong type
        private Vector3 buildingLocation;
        private BuildingType buildingClass;
        private double time;
        private string missionID;
        private int missionSeed;
        private ParticipantType participantType;

        [JsonProperty("9@i")]
        public int Table
        {
            get => table;
            set
            {
                if (ReferenceEquals(table, value) != true)
                {
                    table = value;
                    OnPropertyChanged("Table");
                }
            }
        }

        [JsonProperty("FN5")]
        public string MarkerEvent
        {
            get => markerEvent;
            set
            {
                if (ReferenceEquals(markerEvent, value) != true)
                {
                    markerEvent = value;
                    OnPropertyChanged("MarkerEvent");
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

        [JsonProperty("5bU")]
        public object[] BuildingSeed
        {
            get => buildingSeed;
            set
            {
                if (ReferenceEquals(buildingSeed, value) != true)
                {
                    buildingSeed = value;
                    OnPropertyChanged("BuildingSeed");
                }
            }
        }

        [JsonProperty("TWn")]
        public Vector3 BuildingLocation
        {
            get => buildingLocation;
            set
            {
                if (ReferenceEquals(buildingLocation, value) != true)
                {
                    buildingLocation = value;
                    OnPropertyChanged("BuildingLocation");
                }
            }
        }

        [JsonProperty("iqv")]
        public BuildingType BuildingClass
        {
            get => buildingClass;
            set
            {
                if (ReferenceEquals(buildingClass, value) != true)
                {
                    buildingClass = value;
                    OnPropertyChanged("BuildingClass");
                }
            }
        }

        [JsonProperty("ADw")]
        public double Time
        {
            get => time;
            set
            {
                if (ReferenceEquals(time, value) != true)
                {
                    time = value;
                    OnPropertyChanged("Time");
                }
            }
        }

        [JsonProperty("jGk")]
        public string MissionID
        {
            get => missionID;
            set
            {
                if (ReferenceEquals(missionID, value) != true)
                {
                    missionID = value;
                    OnPropertyChanged("MissionID");
                }
            }
        }

        [JsonProperty("1JW")]
        public int MissionSeed
        {
            get => missionSeed;
            set
            {
                if (ReferenceEquals(missionSeed, value) != true)
                {
                    missionSeed = value;
                    OnPropertyChanged("MissionSeed");
                }
            }
        }

        [JsonProperty("M?f")]
        public ParticipantType ParticipantType
        {
            get => participantType;
            set
            {
                if (ReferenceEquals(participantType, value) != true)
                {
                    participantType = value;
                    OnPropertyChanged("ParticipantType");
                }
            }
        }
    }
}