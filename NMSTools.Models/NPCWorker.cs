using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class NPCWorker : ModelBase
    {
        private ProceduralObject resourceElement;
        private string[] interactionSeed;
        private bool hiredWorker;
        private bool freighterBase;
        private string baseUA;
        private float[] baseOffset;

        [DataMember(Name = "q08")]
        public ProceduralObject ResourceElement
        {
            get => resourceElement;
            set
            {
                if ((ReferenceEquals(resourceElement, value) != true))
                {
                    resourceElement = value;
                    OnPropertyChanged("ResourceElement");
                }
            }
        }

        [DataMember(Name = "BKy")]
        public string[] InteractionSeed
        {
            get => interactionSeed;
            set
            {
                if ((ReferenceEquals(interactionSeed, value) != true))
                {
                    interactionSeed = value;
                    OnPropertyChanged("InteractionSeed");
                }
            }
        }

        [DataMember(Name = "1wj")]
        public bool HiredWorker
        {
            get => hiredWorker;
            set
            {
                if ((ReferenceEquals(hiredWorker, value) != true))
                {
                    hiredWorker = value;
                    OnPropertyChanged("HiredWorker");
                }
            }
        }

        [DataMember(Name = "gNy")]
        public bool FreighterBase
        {
            get => freighterBase;
            set
            {
                if ((ReferenceEquals(freighterBase, value) != true))
                {
                    freighterBase = value;
                    OnPropertyChanged("FreighterBase");
                }
            }
        }

        [DataMember(Name = "pNt")]
        public string BaseUA
        {
            get => baseUA;
            set
            {
                if ((ReferenceEquals(baseUA, value) != true))
                {
                    baseUA = value;
                    OnPropertyChanged("BaseUA");
                }
            }
        }

        [DataMember(Name = "TJx")]
        public float[] BaseOffset
        {
            get => baseOffset;
            set
            {
                if ((ReferenceEquals(baseOffset, value) != true))
                {
                    baseOffset = value;
                    OnPropertyChanged("GalaBaseOffsetcticAddress");
                }
            }
        }
    }
}