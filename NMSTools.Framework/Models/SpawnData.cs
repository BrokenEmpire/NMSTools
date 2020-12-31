using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class SpawnData : ModelBase
    {
        private Vector4 playerPositionInSystem;
        private Vector4 playerTransformAt;
        private Vector4 shipPositionInSystem;
        private Vector4 shipTransformAt;
        private string lastKnownPlayerState;
        private Vector4 freighterPositionInSystem;
        private Vector4 freighterTransformAt;
        private Vector4 freighterTransformUp;
        private Vector4 abandonedFreighterPositionInSystem;
        private Vector4 abandonedFreighterTransformAt;
        private Vector4 abandonedFreighterTransformUp;

        [JsonProperty("mEH")]
        public Vector4 PlayerPositionInSystem
        {
            get => playerPositionInSystem;
            set
            {
                if (ReferenceEquals(playerPositionInSystem, value) != true)
                {
                    playerPositionInSystem = value;
                    OnPropertyChanged("PlayerPositionInSystem");
                }
            }
        }

        [JsonProperty("l2U")]
        public Vector4 PlayerTransformAt
        {
            get => playerTransformAt;
            set
            {
                if (ReferenceEquals(playerTransformAt, value) != true)
                {
                    playerTransformAt = value;
                    OnPropertyChanged("PlayerTransformAt");
                }
            }
        }

        [JsonProperty("tnP")]
        public Vector4 ShipPositionInSystem
        {
            get => shipPositionInSystem;
            set
            {
                if (ReferenceEquals(shipPositionInSystem, value) != true)
                {
                    shipPositionInSystem = value;
                    OnPropertyChanged("ShipPositionInSystem");
                }
            }
        }

        [JsonProperty("l4H")]
        public Vector4 ShipTransformAt
        {
            get => shipTransformAt;
            set
            {
                if (ReferenceEquals(shipTransformAt, value) != true)
                {
                    shipTransformAt = value;
                    OnPropertyChanged("ShipTransformAt");
                }
            }
        }

        [JsonProperty("jk4")]
        public string LastKnownPlayerState
        {
            get => lastKnownPlayerState;
            set
            {
                if (ReferenceEquals(lastKnownPlayerState, value) != true)
                {
                    lastKnownPlayerState = value;
                    OnPropertyChanged("LastKnownPlayerState");
                }
            }
        }

        [JsonProperty("NGn")]
        public Vector4 FreighterPositionInSystem
        {
            get => freighterPositionInSystem;
            set
            {
                if (ReferenceEquals(freighterPositionInSystem, value) != true)
                {
                    freighterPositionInSystem = value;
                    OnPropertyChanged("FreighterPositionInSystem");
                }
            }
        }

        [JsonProperty("uAt")]
        public Vector4 FreighterTransformAt
        {
            get => freighterTransformAt;
            set
            {
                if (ReferenceEquals(freighterTransformAt, value) != true)
                {
                    freighterTransformAt = value;
                    OnPropertyChanged("FreighterTransformAt");
                }
            }
        }

        [JsonProperty("5Sg")]
        public Vector4 FreighterTransformUp
        {
            get => freighterTransformUp;
            set
            {
                if (ReferenceEquals(freighterTransformUp, value) != true)
                {
                    freighterTransformUp = value;
                    OnPropertyChanged("FreighterTransformUp");
                }
            }
        }

        [JsonProperty("Ovv")]
        public Vector4 AbandonedFreighterPositionInSystem
        {
            get => abandonedFreighterPositionInSystem;
            set
            {
                if (ReferenceEquals(abandonedFreighterPositionInSystem, value) != true)
                {
                    abandonedFreighterPositionInSystem = value;
                    OnPropertyChanged("AbandonedFreighterPositionInSystem");
                }
            }
        }

        [JsonProperty("EkX")]
        public Vector4 AbandonedFreighterTransformAt
        {
            get => abandonedFreighterTransformAt;
            set
            {
                if (ReferenceEquals(abandonedFreighterTransformAt, value) != true)
                {
                    abandonedFreighterTransformAt = value;
                    OnPropertyChanged("AbandonedFreighterTransformAt");
                }
            }
        }

        [JsonProperty("Bg3")]
        public Vector4 AbandonedFreighterTransformUp
        {
            get => abandonedFreighterTransformUp;
            set
            {
                if (ReferenceEquals(abandonedFreighterTransformUp, value) != true)
                {
                    abandonedFreighterTransformUp = value;
                    OnPropertyChanged("AbandonedFreighterTransformUp");
                }
            }
        }
    }
}