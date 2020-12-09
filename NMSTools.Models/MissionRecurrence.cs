using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class MissionRecurrence : ModelBase
    {
        private string missionID;
        private int recurrenceDeadline;

        [DataMember(Name = "jGk")]
        public string MissionID
        {
            get => missionID;
            set
            {
                if ((ReferenceEquals(missionID, value) != true))
                {
                    missionID = value;
                    OnPropertyChanged("MissionID");
                }
            }
        }

        [DataMember(Name = "oF@")]
        public int RecurrenceDeadline
        {
            get => recurrenceDeadline;
            set
            {
                if ((ReferenceEquals(recurrenceDeadline, value) != true))
                {
                    recurrenceDeadline = value;
                    OnPropertyChanged("RecurrenceDeadline");
                }
            }
        }
    }
}