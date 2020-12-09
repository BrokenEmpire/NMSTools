using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Telemetry : ModelBase
    {
        private string id;
        private string telemetryType;
        private int telemetryValue;

        [DataMember(Name = "b2n")]
        public string Id
        {
            get => id;
            set
            {
                if ((ReferenceEquals(id, value) != true))
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        [DataMember(Name = "Vn8")]
        public string TelemetryType
        {
            get => telemetryType;
            set
            {
                if ((ReferenceEquals(telemetryType, value) != true))
                {
                    telemetryType = value;
                    OnPropertyChanged("TelemetryType");
                }
            }
        }

        [DataMember(Name = ">MX")]
        public int TelemetryValue
        {
            get => telemetryValue;
            set
            {
                if ((ReferenceEquals(telemetryValue, value) != true))
                {
                    telemetryValue = value;
                    OnPropertyChanged("TelemetryValue");
                }
            }
        }
    }
}