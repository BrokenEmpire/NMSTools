using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class ParticipantType : ModelBase
    {
        private string participantMode;

        [DataMember(Name = "M?f")]
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