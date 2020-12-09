using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Marker : ModelBase
    {
        private int table;
        private string markerEvent;
        private object galacticAddress;
        private object[] buildingSeed;
        private float[] buildingLocation;
        private BuildingType buildingClass;
        private float time;
        private string missionID;
        private int missionSeed;
        private ParticipantType participantType;

        [DataMember(Name = "9@i")]
        public int Table
        {
            get => table;
            set
            {
                if ((ReferenceEquals(table, value) != true))
                {
                    table = value;
                    OnPropertyChanged("Table");
                }
            }
        }

        [DataMember(Name = "FN5")]
        public string MarkerEvent
        {
            get => markerEvent;
            set
            {
                if ((ReferenceEquals(markerEvent, value) != true))
                {
                    markerEvent = value;
                    OnPropertyChanged("MarkerEvent");
                }
            }
        }

        [DataMember(Name = "oZw")]
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

        [DataMember(Name = "5bU")]
        public object[] BuildingSeed
        {
            get => buildingSeed;
            set
            {
                if ((ReferenceEquals(buildingSeed, value) != true))
                {
                    buildingSeed = value;
                    OnPropertyChanged("BuildingSeed");
                }
            }
        }

        [DataMember(Name = "TWn")]
        public float[] BuildingLocation
        {
            get => buildingLocation;
            set
            {
                if ((ReferenceEquals(buildingLocation, value) != true))
                {
                    buildingLocation = value;
                    OnPropertyChanged("BuildingLocation");
                }
            }
        }

        [DataMember(Name = "iqv")]
        public BuildingType BuildingClass
        {
            get => buildingClass;
            set
            {
                if ((ReferenceEquals(buildingClass, value) != true))
                {
                    buildingClass = value;
                    OnPropertyChanged("BuildingClass");
                }
            }
        }

        [DataMember(Name = "ADw")]
        public float Time
        {
            get => time;
            set
            {
                if ((ReferenceEquals(time, value) != true))
                {
                    time = value;
                    OnPropertyChanged("Time");
                }
            }
        }

        [DataMember(Name = "jGk")]
        public string MissionID
        {
            get => missionID;
            set
            {
                if ((ReferenceEquals(missionID, value) != true))
                {
                    missionID = value;
                    OnPropertyChanged("MissionID");
                }
            }
        }

        [DataMember(Name = "1JW")]
        public int MissionSeed
        {
            get => missionSeed;
            set
            {
                if ((ReferenceEquals(missionSeed, value) != true))
                {
                    missionSeed = value;
                    OnPropertyChanged("MissionSeed");
                }
            }
        }

        [DataMember(Name = "M?f")]
        public ParticipantType ParticipantType
        {
            get => participantType;
            set
            {
                if ((ReferenceEquals(participantType, value) != true))
                {
                    participantType = value;
                    OnPropertyChanged("ParticipantType");
                }
            }
        }
    }
}