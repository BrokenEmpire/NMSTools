using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    [JsonObject]
    public class ParticipantType : ModelBase
    {
        private string participantMode;

        [JsonProperty("M?f")]
        public string ParticipantMode
        {
            get => participantMode;
            set
            {
                if (ReferenceEquals(participantMode, value) != true)
                {
                    participantMode = value;
                    OnPropertyChanged("ParticipantMode");
                }
            }
        }
    }
}