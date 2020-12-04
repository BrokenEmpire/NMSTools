using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Participant : ModelBase
    {
        private string uA;
        private string[] buildingSeed;
        private float[] buildingLocation;
        private ParticipantType participantMode;

        [JsonProperty("5L6")]
        public string UA
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

        [JsonProperty("5bU")]
        public string[] BuildingSeed
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

        [JsonProperty("TWn")]
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

        [JsonProperty("M?f")]
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