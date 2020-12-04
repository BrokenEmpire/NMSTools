﻿using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class NPCWorker : ModelBase
    {
        private ProceduralObject resourceElement;
        private string[] interactionSeed;
        private bool hiredWorker;
        private bool freighterBase;
        private string baseUA;
        private float[] baseOffset;

        [JsonProperty("q08")]
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

        [JsonProperty("BKy")]
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

        [JsonProperty("1wj")]
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

        [JsonProperty("gNy")]
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

        [JsonProperty("pNt")]
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

        [JsonProperty("TJx")]
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