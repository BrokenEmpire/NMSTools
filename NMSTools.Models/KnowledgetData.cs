using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class KnowledgetData : ModelBase
    {
        private Waypoint[] waypoints;

        [DataMember(Name = "yRy")]
        public Waypoint[] Waypoints
        {
            get => waypoints;
            set
            {
                if ((ReferenceEquals(waypoints, value) != true))
                {
                    waypoints = value;
                    OnPropertyChanged("Waypoints");
                }
            }
        }
    }
}