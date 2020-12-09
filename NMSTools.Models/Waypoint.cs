using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Waypoint : ModelBase
    {
        private GalaxyCoordinates address;
        private WaypointType type;
        private string eventId;

        [DataMember(Name = "2Ak")]
        public GalaxyCoordinates Address
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

        [DataMember(Name = "Vn8")]
        public WaypointType Type
        {
            get => type;
            set
            {
                if ((ReferenceEquals(type, value) != true))
                {
                    type = value;
                    OnPropertyChanged("Type");
                }
            }
        }

        [DataMember(Name = "SSo")]
        public string EventId
        {
            get => eventId;
            set
            {
                if ((ReferenceEquals(eventId, value) != true))
                {
                    eventId = value;
                    OnPropertyChanged("EventId");
                }
            }
        }
    }
}