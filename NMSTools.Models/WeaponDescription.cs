using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class WeaponDescription : ModelBase
    {
        private string weaponMode;

        [DataMember(Name = "Rfw")]
        public string WeaponMode
        {
            get => weaponMode;
            set
            {
                if ((ReferenceEquals(weaponMode, value) != true))
                {
                    weaponMode = value;
                    OnPropertyChanged("WeaponMode");
                }
            }
        }
    }
}