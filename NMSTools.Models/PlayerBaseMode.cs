using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PlayerBaseMode : ModelBase
    {
        private string persistentBaseTypes;

        [DataMember(Name = "pwt")]
        public string PersistentBaseTypes
        {
            get => persistentBaseTypes;
            set
            {
                if ((ReferenceEquals(persistentBaseTypes, value) != true))
                {
                    persistentBaseTypes = value;
                    OnPropertyChanged("PersistentBaseTypes");
                }
            }
        }
    }
}