using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Race : ModelBase
    {
        private string alienRace;

        [DataMember(Name = "0Hi")]
        public string AlienRace
        {
            get => alienRace;
            set
            {
                if ((ReferenceEquals(alienRace, value) != true))
                {
                    alienRace = value;
                    OnPropertyChanged("AlienRace");
                }
            }
        }
    }
}