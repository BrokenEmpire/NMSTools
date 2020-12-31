using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;
        
    public class NPCWorker : ModelBase
    {
        private ProceduralObject resourceElement;
        private object[] interactionSeed;   //todo: strong type
        private bool hiredWorker;
        private bool freighterBase;
        private string baseUA;
        private Vector4 baseOffset;

        [JsonProperty("q08")]
        public ProceduralObject ResourceElement
        {
            get => resourceElement;
            set
            {
                if (ReferenceEquals(resourceElement, value) != true)
                {
                    resourceElement = value;
                    OnPropertyChanged("ResourceElement");
                }
            }
        }

        [JsonProperty("BKy")]
        public object[] InteractionSeed
        {
            get => interactionSeed;
            set
            {
                if (ReferenceEquals(interactionSeed, value) != true)
                {
                    interactionSeed = value;
                    OnPropertyChanged("InteractionSeed");
                }
            }
        }

        [JsonProperty("1wj")]
        public bool HiredWorker
        {
            get => hiredWorker;
            set
            {
                if (ReferenceEquals(hiredWorker, value) != true)
                {
                    hiredWorker = value;
                    OnPropertyChanged("HiredWorker");
                }
            }
        }

        [JsonProperty("gNy")]
        public bool FreighterBase
        {
            get => freighterBase;
            set
            {
                if (ReferenceEquals(freighterBase, value) != true)
                {
                    freighterBase = value;
                    OnPropertyChanged("FreighterBase");
                }
            }
        }

        [JsonProperty("pNt")]
        public string BaseUA
        {
            get => baseUA;
            set
            {
                if (ReferenceEquals(baseUA, value) != true)
                {
                    baseUA = value;
                    OnPropertyChanged("BaseUA");
                }
            }
        }

        [JsonProperty("TJx")]
        public Vector4 BaseOffset
        {
            get => baseOffset;
            set
            {
                if (ReferenceEquals(baseOffset, value) != true)
                {
                    baseOffset = value;
                    OnPropertyChanged("GalaBaseOffsetcticAddress");
                }
            }
        }
    }
}