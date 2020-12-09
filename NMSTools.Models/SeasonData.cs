using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class SeasonData : ModelBase
    {
        private long startTimeUTC;
        private long endTimeUTC;
        private string title;
        private string subTitle;
        private string description;
        private GamePreset gameMode;
        private string seasonalUAOverride;
        private long uAOverrideValue;
        private object[] weaponSeed;
        private object[] shipSeed;
        private ShipTypeDescription shipType;
        private bool startNextToShip;
        private bool shipStartsDamaged;
        private bool allowMissionDetailMessages;
        private object[] milestones;
        private object[] secondaryStats;

        [DataMember(Name = "hyA")]
        public long StartTimeUTC
        {
            get => startTimeUTC;
            set
            {
                if ((ReferenceEquals(startTimeUTC, value) != true))
                {
                    startTimeUTC = value;
                    OnPropertyChanged("StartTimeUTC");
                }
            }
        }

        [DataMember(Name = "jqx")]
        public long EndTimeUTC
        {
            get => endTimeUTC;
            set
            {
                if ((ReferenceEquals(endTimeUTC, value) != true))
                {
                    endTimeUTC = value;
                    OnPropertyChanged("EndTimeUTC");
                }
            }
        }

        [DataMember(Name = "8wT")]
        public string Title
        {
            get => title;
            set
            {
                if ((ReferenceEquals(title, value) != true))
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        [DataMember(Name = "GLf")]
        public string SubTitle
        {
            get => subTitle;
            set
            {
                if ((ReferenceEquals(subTitle, value) != true))
                {
                    subTitle = value;
                    OnPropertyChanged("SubTitle");
                }
            }
        }

        [DataMember(Name = "myI")]
        public string Description
        {
            get => description;
            set
            {
                if ((ReferenceEquals(description, value) != true))
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        [DataMember(Name = "idA")]
        public GamePreset GameMode
        {
            get => gameMode;
            set
            {
                if ((ReferenceEquals(gameMode, value) != true))
                {
                    gameMode = value;
                    OnPropertyChanged("GameMode");
                }
            }
        }

        [DataMember(Name = "8sY")]
        public string SeasonalUAOverride
        {
            get => seasonalUAOverride;
            set
            {
                if ((ReferenceEquals(seasonalUAOverride, value) != true))
                {
                    seasonalUAOverride = value;
                    OnPropertyChanged("SeasonalUAOverride");
                }
            }
        }

        [DataMember(Name = "GPe")]
        public long UAOverrideValue
        {
            get => uAOverrideValue;
            set
            {
                if ((ReferenceEquals(uAOverrideValue, value) != true))
                {
                    uAOverrideValue = value;
                    OnPropertyChanged("UAOverrideValue");
                }
            }
        }

        [DataMember(Name = "@lX")]
        public object[] WeaponSeed
        {
            get => weaponSeed;
            set
            {
                if ((ReferenceEquals(weaponSeed, value) != true))
                {
                    weaponSeed = value;
                    OnPropertyChanged("WeaponSeed");
                }
            }
        }

        [DataMember(Name = "3R<")]
        public object[] ShipSeed
        {
            get => shipSeed;
            set
            {
                if ((ReferenceEquals(shipSeed, value) != true))
                {
                    shipSeed = value;
                    OnPropertyChanged("ShipSeed");
                }
            }
        }

        [DataMember(Name = "bLP")]
        public ShipTypeDescription ShipType
        {
            get => shipType;
            set
            {
                if ((ReferenceEquals(shipType, value) != true))
                {
                    shipType = value;
                    OnPropertyChanged("ShipType");
                }
            }
        }

        [DataMember(Name = "bnC")]
        public bool StartNextToShip
        {
            get => startNextToShip;
            set
            {
                if ((ReferenceEquals(startNextToShip, value) != true))
                {
                    startNextToShip = value;
                    OnPropertyChanged("StartNextToShip");
                }
            }
        }

        [DataMember(Name = "jA9")]
        public bool ShipStartsDamaged
        {
            get => shipStartsDamaged;
            set
            {
                if ((ReferenceEquals(shipStartsDamaged, value) != true))
                {
                    shipStartsDamaged = value;
                    OnPropertyChanged("ShipStartsDamaged");
                }
            }
        }

        [DataMember(Name = "5XZ")]
        public bool AllowMissionDetailMessages
        {
            get => allowMissionDetailMessages;
            set
            {
                if ((ReferenceEquals(allowMissionDetailMessages, value) != true))
                {
                    allowMissionDetailMessages = value;
                    OnPropertyChanged("AllowMissionDetailMessages");
                }
            }
        }

        [DataMember(Name = "kr6")]
        public object[] Milestones
        {
            get => milestones;
            set
            {
                if ((ReferenceEquals(milestones, value) != true))
                {
                    milestones = value;
                    OnPropertyChanged("Milestones");
                }
            }
        }

        [DataMember(Name = ":Je")]
        public object[] SecondaryStats
        {
            get => secondaryStats;
            set
            {
                if ((ReferenceEquals(secondaryStats, value) != true))
                {
                    secondaryStats = value;
                    OnPropertyChanged("SecondaryStats");
                }
            }
        }
    }
}