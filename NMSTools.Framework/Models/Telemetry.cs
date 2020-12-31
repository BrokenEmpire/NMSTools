using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class Telemetry : ModelBase
    {
        private string id;
        private string telemetryType;
        private int telemetryValue;

        [JsonProperty("b2n")]
        public string Id
        {
            get => id;
            set
            {
                if (ReferenceEquals(id, value) != true)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        [JsonProperty("Vn8")]
        public string TelemetryType
        {
            get => telemetryType;
            set
            {
                if (ReferenceEquals(telemetryType, value) != true)
                {
                    telemetryType = value;
                    OnPropertyChanged("TelemetryType");
                }
            }
        }

        [JsonProperty(">MX")]
        public int TelemetryValue
        {
            get => telemetryValue;
            set
            {
                if (ReferenceEquals(telemetryValue, value) != true)
                {
                    telemetryValue = value;
                    OnPropertyChanged("TelemetryValue");
                }
            }
        }
    }
}