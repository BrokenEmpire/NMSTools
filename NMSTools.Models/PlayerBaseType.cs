using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
        
    public class PlayerBaseType : ModelBase
    {
        private string persistentBaseTypes;

        [JsonProperty("DPp")]
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