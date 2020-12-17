using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    public class SpawnData : ModelBase
    {
        private double[] playerPositionInSystem;
        private double[] playerTransformAt;
        private double[] shipPositionInSystem;
        private double[] shipTransformAt;
        private string lastKnownPlayerState;
        private double[] freighterPositionInSystem;
        private double[] freighterTransformAt;
        private double[] freighterTransformUp;
        private double[] abandonedFreighterPositionInSystem;
        private double[] abandonedFreighterTransformAt;
        private double[] abandonedFreighterTransformUp;

        [JsonProperty("mEH")]
        public double[] PlayerPositionInSystem
        {
            get => playerPositionInSystem;
            set
            {
                if ((ReferenceEquals(playerPositionInSystem, value) != true))
                {
                    playerPositionInSystem = value;
                    OnPropertyChanged("PlayerPositionInSystem");
                }
            }
        }

        [JsonProperty("l2U")]
        public double[] PlayerTransformAt
        {
            get => playerTransformAt;
            set
            {
                if ((ReferenceEquals(playerTransformAt, value) != true))
                {
                    playerTransformAt = value;
                    OnPropertyChanged("PlayerTransformAt");
                }
            }
        }

        [JsonProperty("tnP")]
        public double[] ShipPositionInSystem
        {
            get => shipPositionInSystem;
            set
            {
                if ((ReferenceEquals(shipPositionInSystem, value) != true))
                {
                    shipPositionInSystem = value;
                    OnPropertyChanged("ShipPositionInSystem");
                }
            }
        }

        [JsonProperty("l4H")]
        public double[] ShipTransformAt
        {
            get => shipTransformAt;
            set
            {
                if ((ReferenceEquals(shipTransformAt, value) != true))
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
                if ((ReferenceEquals(lastKnownPlayerState, value) != true))
                {
                    lastKnownPlayerState = value;
                    OnPropertyChanged("LastKnownPlayerState");
                }
            }
        }

        [JsonProperty("NGn")]
        public double[] FreighterPositionInSystem
        {
            get => freighterPositionInSystem;
            set
            {
                if ((ReferenceEquals(freighterPositionInSystem, value) != true))
                {
                    freighterPositionInSystem = value;
                    OnPropertyChanged("FreighterPositionInSystem");
                }
            }
        }

        [JsonProperty("uAt")]
        public double[] FreighterTransformAt
        {
            get => freighterTransformAt;
            set
            {
                if ((ReferenceEquals(freighterTransformAt, value) != true))
                {
                    freighterTransformAt = value;
                    OnPropertyChanged("FreighterTransformAt");
                }
            }
        }

        [JsonProperty("5Sg")]
        public double[] FreighterTransformUp
        {
            get => freighterTransformUp;
            set
            {
                if ((ReferenceEquals(freighterTransformUp, value) != true))
                {
                    freighterTransformUp = value;
                    OnPropertyChanged("FreighterTransformUp");
                }
            }
        }

        [JsonProperty("Ovv")]
        public double[] AbandonedFreighterPositionInSystem
        {
            get => abandonedFreighterPositionInSystem;
            set
            {
                if ((ReferenceEquals(abandonedFreighterPositionInSystem, value) != true))
                {
                    abandonedFreighterPositionInSystem = value;
                    OnPropertyChanged("AbandonedFreighterPositionInSystem");
                }
            }
        }

        [JsonProperty("EkX")]
        public double[] AbandonedFreighterTransformAt
        {
            get => abandonedFreighterTransformAt;
            set
            {
                if ((ReferenceEquals(abandonedFreighterTransformAt, value) != true))
                {
                    abandonedFreighterTransformAt = value;
                    OnPropertyChanged("AbandonedFreighterTransformAt");
                }
            }
        }

        [JsonProperty("Bg3")]
        public double[] AbandonedFreighterTransformUp
        {
            get => abandonedFreighterTransformUp;
            set
            {
                if ((ReferenceEquals(abandonedFreighterTransformUp, value) != true))
                {
                    abandonedFreighterTransformUp = value;
                    OnPropertyChanged("AbandonedFreighterTransformUp");
                }
            }
        }
    }
}