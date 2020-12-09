using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StoredInteraction : ModelBase
    {
        private Interaction[] interactions;
        private int currentPos;

        [DataMember(Name = "O49")]
        public Interaction[] Interactions
        {
            get => interactions;
            set
            {
                if ((ReferenceEquals(interactions, value) != true))
                {
                    interactions = value;
                    OnPropertyChanged("Interactions");
                }
            }
        }

        [DataMember(Name = "Xf4")]
        public int CurrentPos
        {
            get => currentPos;
            set
            {
                if ((ReferenceEquals(currentPos, value) != true))
                {
                    currentPos = value;
                    OnPropertyChanged("CurrentPos");
                }
            }
        }
    }
}