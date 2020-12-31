using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class Mission : ModelBase
    {
        private string missionName;
        private int progress;
        private object seed;
        private int data;
        private Participant[] participants;

        [JsonProperty("p0c")]
        public string MissionName
        {
            get => missionName;
            set
            {
                if (ReferenceEquals(missionName, value) != true)
                {
                    missionName = value;
                    OnPropertyChanged("MissionName");
                }
            }
        }

        [JsonProperty("tW6")]
        public int Progress
        {
            get => progress;
            set
            {
                if (ReferenceEquals(progress, value) != true)
                {
                    progress = value;
                    OnPropertyChanged("Progress");
                }
            }
        }

        [JsonProperty("@EL")]
        public object Seed
        {
            get => seed;
            set
            {
                if (ReferenceEquals(seed, value) != true)
                {
                    seed = value;
                    OnPropertyChanged("Seed");
                }
            }
        }

        [JsonProperty("8?J")]
        public int Data
        {
            get => data;
            set
            {
                if (ReferenceEquals(data, value) != true)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        [JsonProperty("eZ7")]
        public Participant[] Participants
        {
            get => participants;
            set
            {
                if (ReferenceEquals(participants, value) != true)
                {
                    participants = value;
                    OnPropertyChanged("Participants");
                }
            }
        }
    }
}