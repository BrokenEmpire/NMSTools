using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class Interaction : ModelBase
    {
        private object galacticAddress;
        private int interactionValue;
        private decimal[] position;

        [JsonProperty("oZw")]
        public object GalacticAddress
        {
            get => galacticAddress;
            set
            {
                if ((ReferenceEquals(galacticAddress, value) != true))
                {
                    galacticAddress = value;
                    OnPropertyChanged("GalacticAddress");
                }
            }
        }

        [JsonProperty(">MX")]
        public int InteractionValue
        {
            get => interactionValue;
            set
            {
                if ((ReferenceEquals(interactionValue, value) != true))
                {
                    interactionValue = value;
                    OnPropertyChanged("InteractionValue");
                }
            }
        }

        [JsonProperty("wMC")]
        public decimal[] Position
        {
            get => position;
            set
            {
                if ((ReferenceEquals(position, value) != true))
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }
    }
}