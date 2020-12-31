using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class StoredInteraction : ModelBase
    {
        private Interaction[] interactions;
        private int currentPos;

        [JsonProperty("O49")]
        public Interaction[] Interactions
        {
            get => interactions;
            set
            {
                if (ReferenceEquals(interactions, value) != true)
                {
                    interactions = value;
                    OnPropertyChanged("Interactions");
                }
            }
        }

        [JsonProperty("Xf4")]
        public int CurrentPos
        {
            get => currentPos;
            set
            {
                if (ReferenceEquals(currentPos, value) != true)
                {
                    currentPos = value;
                    OnPropertyChanged("CurrentPos");
                }
            }
        }
    }
}