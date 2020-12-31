using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class Waypoint : ModelBase
    {
        private GalaxyCoordinates address;
        private WaypointType type;
        private string eventId;

        [JsonProperty("2Ak")]
        public GalaxyCoordinates Address
        {
            get => address;
            set
            {
                if (ReferenceEquals(address, value) != true)
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        [JsonProperty("Vn8")]
        public WaypointType Type
        {
            get => type;
            set
            {
                if (ReferenceEquals(type, value) != true)
                {
                    type = value;
                    OnPropertyChanged("Type");
                }
            }
        }

        [JsonProperty("SSo")]
        public string EventId
        {
            get => eventId;
            set
            {
                if (ReferenceEquals(eventId, value) != true)
                {
                    eventId = value;
                    OnPropertyChanged("EventId");
                }
            }
        }
    }
}