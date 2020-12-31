using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class MissionRecurrence : ModelBase
    {
        private string missionID;
        private int recurrenceDeadline;

        [JsonProperty("jGk")]
        public string MissionID
        {
            get => missionID;
            set
            {
                if (ReferenceEquals(missionID, value) != true)
                {
                    missionID = value;
                    OnPropertyChanged("MissionID");
                }
            }
        }

        [JsonProperty("oF@")]
        public int RecurrenceDeadline
        {
            get => recurrenceDeadline;
            set
            {
                if (ReferenceEquals(recurrenceDeadline, value) != true)
                {
                    recurrenceDeadline = value;
                    OnPropertyChanged("RecurrenceDeadline");
                }
            }
        }
    }
}