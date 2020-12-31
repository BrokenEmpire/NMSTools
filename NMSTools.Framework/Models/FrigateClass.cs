using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    [JsonObject]
    public class FrigateClass : ModelBase
    {
        private string className;

        [JsonProperty("uw7")]
        public string ClassName
        {
            get => className;
            set
            {
                if (ReferenceEquals(className, value) != true)
                {
                    className = value;
                    OnPropertyChanged("ClassName");
                }
            }
        }
    }
}