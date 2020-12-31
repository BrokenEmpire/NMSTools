using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    
    [JsonObject]
    public class BuildingType : ModelBase
    {
        private string buildingClass;

        [JsonProperty("iqv")]
        public string BuildingClass
        {
            get => buildingClass;
            set
            {
                if (ReferenceEquals(buildingClass, value) != true)
                {
                    buildingClass = value;
                    OnPropertyChanged("BuildingClass");
                }
            }
        }
    }
}