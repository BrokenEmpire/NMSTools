using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PlayerBaseType : ModelBase
    {
        private string persistentBaseTypes;

        [DataMember(Name = "DPp")]
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