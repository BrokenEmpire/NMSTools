using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Interaction : ModelBase
    {
        private object galacticAddress;
        private int interactionValue;
        private decimal[] position;

        [DataMember(Name = "oZw")]
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

        [DataMember(Name = ">MX")]
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

        [DataMember(Name = "wMC")]
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