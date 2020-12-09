using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class ShipTypeDescription : ModelBase
    {
        private string shipClass;

        [DataMember(Name = "eEU")]
        public string ShipClass
        {
            get => shipClass;
            set
            {
                if ((ReferenceEquals(shipClass, value) != true))
                {
                    shipClass = value;
                    OnPropertyChanged("ShipClass");
                }
            }
        }
    }
}