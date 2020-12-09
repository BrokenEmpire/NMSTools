using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class SpawnData : ModelBase
    {
        private float[] playerPositionInSystem;
        private float[] playerTransformAt;
        private float[] shipPositionInSystem;
        private float[] shipTransformAt;
        private string lastKnownPlayerState;
        private float[] freighterPositionInSystem;
        private float[] freighterTransformAt;
        private float[] freighterTransformUp;
        private float[] abandonedFreighterPositionInSystem;
        private float[] abandonedFreighterTransformAt;
        private float[] abandonedFreighterTransformUp;

        [DataMember(Name = "mEH")]
        public float[] PlayerPositionInSystem
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

        [DataMember(Name = "l2U")]
        public float[] PlayerTransformAt
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

        [DataMember(Name = "tnP")]
        public float[] ShipPositionInSystem
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

        [DataMember(Name = "l4H")]
        public float[] ShipTransformAt
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

        [DataMember(Name = "jk4")]
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

        [DataMember(Name = "NGn")]
        public float[] FreighterPositionInSystem
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

        [DataMember(Name = "uAt")]
        public float[] FreighterTransformAt
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

        [DataMember(Name = "5Sg")]
        public float[] FreighterTransformUp
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

        [DataMember(Name = "Ovv")]
        public float[] AbandonedFreighterPositionInSystem
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

        [DataMember(Name = "EkX")]
        public float[] AbandonedFreighterTransformAt
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

        [DataMember(Name = "Bg3")]
        public float[] AbandonedFreighterTransformUp
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