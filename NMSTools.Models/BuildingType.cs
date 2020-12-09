using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class BuildingType : ModelBase
    {
        private string buildingClass;

        [DataMember(Name = "iqv")]
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