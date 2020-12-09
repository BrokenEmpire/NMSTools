using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Frigate : ModelBase
    {
        private object[] resourceSeed;
        private object[] homeSystemSeed;
        private int timeOfLastIncomeCollection;
        private string customName;
        private FrigateClass frigateType;
        private Race race;
        private int totalNumberOfExpeditions;
        private int totalNumberOfSuccessfulEvents;
        private int totalNumberOfFailedEvents;
        private int numberOfTimesDamaged;
        private string[] traitIDs;
        private int[] stats;
        private int repairsMade;
        private int damageTaken;

        [DataMember(Name = "SLc")]
        public object[] ResourceSeed
        {
            get => resourceSeed;
            set
            {
                if ((ReferenceEquals(resourceSeed, value) != true))
                {
                    resourceSeed = value;
                    OnPropertyChanged("ResourceSeed");
                }
            }
        }

        [DataMember(Name = "@ui")]
        public object[] HomeSystemSeed
        {
            get => homeSystemSeed;
            set
            {
                if ((ReferenceEquals(homeSystemSeed, value) != true))
                {
                    homeSystemSeed = value;
                    OnPropertyChanged("HomeSystemSeed");
                }
            }
        }

        [DataMember(Name = "4kx")]
        public int TimeOfLastIncomeCollection
        {
            get => timeOfLastIncomeCollection;
            set
            {
                if ((ReferenceEquals(timeOfLastIncomeCollection, value) != true))
                {
                    timeOfLastIncomeCollection = value;
                    OnPropertyChanged("TimeOfLastIncomeCollection");
                }
            }
        }

        [DataMember(Name = "fH8")]
        public string CustomName
        {
            get => customName;
            set
            {
                if ((ReferenceEquals(customName, value) != true))
                {
                    customName = value;
                    OnPropertyChanged("CustomName");
                }
            }
        }

        [DataMember(Name = "uw7")]
        public FrigateClass FrigateType
        {
            get => frigateType;
            set
            {
                if ((ReferenceEquals(frigateType, value) != true))
                {
                    frigateType = value;
                    OnPropertyChanged("FrigateType");
                }
            }
        }

        [DataMember(Name = "SS2")]
        public Race Race
        {
            get => race;
            set
            {
                if ((ReferenceEquals(race, value) != true))
                {
                    race = value;
                    OnPropertyChanged("Race");
                }
            }
        }

        [DataMember(Name = "5es")]
        public int TotalNumberOfExpeditions
        {
            get => totalNumberOfExpeditions;
            set
            {
                if ((ReferenceEquals(totalNumberOfExpeditions, value) != true))
                {
                    totalNumberOfExpeditions = value;
                    OnPropertyChanged("TotalNumberOfExpeditions");
                }
            }
        }

        [DataMember(Name = "v=L")]
        public int TotalNumberOfSuccessfulEvents
        {
            get => totalNumberOfSuccessfulEvents;
            set
            {
                if ((ReferenceEquals(totalNumberOfSuccessfulEvents, value) != true))
                {
                    totalNumberOfSuccessfulEvents = value;
                    OnPropertyChanged("TotalNumberOfSuccessfulEvents");
                }
            }
        }

        [DataMember(Name = "5VG")]
        public int TotalNumberOfFailedEvents
        {
            get => totalNumberOfFailedEvents;
            set
            {
                if ((ReferenceEquals(totalNumberOfFailedEvents, value) != true))
                {
                    totalNumberOfFailedEvents = value;
                    OnPropertyChanged("TotalNumberOfFailedEvents");
                }
            }
        }

        [DataMember(Name = "MuL")]
        public int NumberOfTimesDamaged
        {
            get => numberOfTimesDamaged;
            set
            {
                if ((ReferenceEquals(numberOfTimesDamaged, value) != true))
                {
                    numberOfTimesDamaged = value;
                    OnPropertyChanged("NumberOfTimesDamaged");
                }
            }
        }

        [DataMember(Name = "Mjm")]
        public string[] TraitIDs
        {
            get => traitIDs;
            set
            {
                if ((ReferenceEquals(traitIDs, value) != true))
                {
                    traitIDs = value;
                    OnPropertyChanged("TraitIDs");
                }
            }
        }

        [DataMember(Name = "gUR")]
        public int[] Stats
        {
            get => stats;
            set
            {
                if ((ReferenceEquals(stats, value) != true))
                {
                    stats = value;
                    OnPropertyChanged("Stats");
                }
            }
        }

        [DataMember(Name = "yJC")]
        public int RepairsMade
        {
            get => repairsMade;
            set
            {
                if ((ReferenceEquals(repairsMade, value) != true))
                {
                    repairsMade = value;
                    OnPropertyChanged("RepairsMade");
                }
            }
        }

        [DataMember(Name = "7hK")]
        public int DamageTaken
        {
            get => damageTaken;
            set
            {
                if ((ReferenceEquals(damageTaken, value) != true))
                {
                    damageTaken = value;
                    OnPropertyChanged("DamageTaken");
                }
            }
        }
    }
}