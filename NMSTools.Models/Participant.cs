using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Participant : ModelBase
    {
        [JsonProperty("5L6")]
        public string UA { get; set; }

        [JsonProperty("5bU")]
        public string[] BuildingSeed { get; set; }

        [JsonProperty("TWn")]
        public float[] BuildingLocation { get; set; }

        [JsonProperty("M?f")]
        public ParticipantType ParticipantMode { get; set; }
    }
}
