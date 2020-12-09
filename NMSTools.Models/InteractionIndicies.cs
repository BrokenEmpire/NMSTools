using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class InteractionIndicies : ModelBase
    {
        private int[] savedRaceIndicies;

        [DataMember(Name = "SEK")]
        public int[] SavedRaceIndicies
        {
            get => savedRaceIndicies;
            set
            {
                if ((ReferenceEquals(savedRaceIndicies, value) != true))
                {
                    savedRaceIndicies = value;
                    OnPropertyChanged("SavedRaceIndicies");
                }
            }
        }
    }
}