using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Participant : ModelBase
    {
        private object uA;
        private object[] buildingSeed;
        private decimal[] buildingLocation;
        private ParticipantType participantMode;

        [DataMember(Name = "5L6")]
        public object UA
        {
            get => uA;
            set
            {
                if ((ReferenceEquals(uA, value) != true))
                {
                    uA = value;
                    OnPropertyChanged("UA");
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
        public decimal[] BuildingLocation
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

        [DataMember(Name = "M?f")]
        public ParticipantType ParticipantMode
        {
            get => participantMode;
            set
            {
                if ((ReferenceEquals(participantMode, value) != true))
                {
                    participantMode = value;
                    OnPropertyChanged("ParticipantMode");
                }
            }
        }
    }
}