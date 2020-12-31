using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class WeaponDescription : ModelBase
    {
        private string weaponMode;

        [JsonProperty("Rfw")]
        public string WeaponMode
        {
            get => weaponMode;
            set
            {
                if (ReferenceEquals(weaponMode, value) != true)
                {
                    weaponMode = value;
                    OnPropertyChanged("WeaponMode");
                }
            }
        }
    }
}