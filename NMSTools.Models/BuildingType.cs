using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
    public class BuildingType : ModelBase
    {
        private string buildingClass;

        [JsonProperty("iqv")]
        public string BuildingClass 
        { 
            get => buildingClass; 
            set
            {
                if ((ReferenceEquals(buildingClass, value) != true))
                {
                    buildingClass = value;
                    OnPropertyChanged("BuildingClass");
                }
            }
        }
    }
}