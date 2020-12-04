using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMSTools.Models
{
    using Base;
    public class Marker : ModelBase
    {
        [JsonProperty("9@i")]
        public int Table { get; set; }

        [JsonProperty("FN5")]
        public string Event { get; set; }

        [JsonProperty("oZw")]
        public string GalacticAddress { get; set; }

        [JsonProperty("5bU")]
        public string[] BuildingSeed { get; set; }

        [JsonProperty("TWn")]
        public float[] BuildingLocation { get; set; }

        [JsonProperty("iqv")]
        public BuildingType BuildingClass { get; set; }

        [JsonProperty("ADw")]
        public float Time { get; set; }

        [JsonProperty("jGk")]
        public string MissionID { get; set; }

        [JsonProperty("1JW")]
        public int MissionSeed { get; set; }

        [JsonProperty("M?f")]
        public ParticipantType ParticipantType { get; set; }
    }
}
