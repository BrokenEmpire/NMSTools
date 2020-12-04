using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Mission : ModelBase
    {
        [JsonProperty("p0c")]
        public string MissionName { get; set; }

        [JsonProperty("tW6")]
        public int Progress { get; set; }

        [JsonProperty("@EL")]
        public object Seed { get; set; }

        [JsonProperty("8?J")]
        public int Data { get; set; }

        [JsonProperty("eZ7")]
        public Participant[] Participants { get; set; }
    }
}
