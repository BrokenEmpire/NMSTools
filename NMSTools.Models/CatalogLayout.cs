using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class CatalogLayout : ModelBase
    {
        private int slots;
        private object[] seed;
        private int level;

        [DataMember(Name = ":No")]
        public int Slots
        {
            get => slots;
            set
            {
                if ((ReferenceEquals(slots, value) != true))
                {
                    slots = value;
                    OnPropertyChanged("Slots");
                }
            }
        }

        [DataMember(Name = "@EL")]
        public object[] Seed
        {
            get => seed;
            set
            {
                if ((ReferenceEquals(seed, value) != true))
                {
                    seed = value;
                    OnPropertyChanged("Seed");
                }
            }
        }

        [DataMember(Name = "9;o")]
        public int Level
        {
            get => level;
            set
            {
                if ((ReferenceEquals(level, value) != true))
                {
                    level = value;
                    OnPropertyChanged("Level");
                }
            }
        }
    }
}