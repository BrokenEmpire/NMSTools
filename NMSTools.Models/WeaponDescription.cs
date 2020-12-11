using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;
    
    public class WeaponDescription : ModelBase
    {
        private string weaponMode;

        [JsonProperty("Rfw")]
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