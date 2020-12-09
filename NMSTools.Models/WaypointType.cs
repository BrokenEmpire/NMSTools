using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class WaypointType : ModelBase
    {
        private string galaxyWaypointType;

        [DataMember(Name = "S8b")]
        public string GalaxyWaypointType
        {
            get => galaxyWaypointType;
            set
            {
                if ((ReferenceEquals(galaxyWaypointType, value) != true))
                {
                    galaxyWaypointType = value;
                    OnPropertyChanged("GalaxyWaypointType");
                }
            }
        }
    }
}