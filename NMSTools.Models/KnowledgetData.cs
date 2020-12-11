using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class KnowledgetData : ModelBase
    {
        private Waypoint[] waypoints;

        [JsonProperty("yRy")]
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