using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class Participant : ModelBase
    {
        private object uA;
        private object[] buildingSeed;  //todo: strong type
        private Vector3 buildingLocation;
        private ParticipantType participantMode;

        [JsonProperty("5L6")]
        public object UA
        {
            get => uA;
            set
            {
                if (ReferenceEquals(uA, value) != true)
                {
                    uA = value;
                    OnPropertyChanged("UA");
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

        [JsonProperty("M?f")]
        public ParticipantType ParticipantMode
        {
            get => participantMode;
            set
            {
                if (ReferenceEquals(participantMode, value) != true)
                {
                    participantMode = value;
                    OnPropertyChanged("ParticipantMode");
                }
            }
        }
    }
}