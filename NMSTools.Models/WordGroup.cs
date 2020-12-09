using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class WordGroup : ModelBase
    {
        private string group;
        private bool[] races;

        [DataMember(Name = "MYl")]
        public string Group
        {
            get => group;
            set
            {
                if ((ReferenceEquals(group, value) != true))
                {
                    group = value;
                    OnPropertyChanged("Group");
                }
            }
        }

        [DataMember(Name = "D;o")]
        public bool[] Races
        {
            get => races;
            set
            {
                if ((ReferenceEquals(races, value) != true))
                {
                    races = value;
                    OnPropertyChanged("Races");
                }
            }
        }
    }
}