using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class ParticipantType : ModelBase
    {
        private string participantMode;

        [JsonProperty("M?f")]
        public string ParticipantMode
        {
            get => participantMode;
            set
            {
                if ((ReferenceEquals(participantMode, value) != true))
                {
                    participantMode = value;
                    OnPropertyChanged("ParticipantMode");
                }
            }
        }
    }
}