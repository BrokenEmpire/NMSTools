using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
 
    [JsonObject]
    public class GamePreset : ModelBase
    {
        private string presetGameMode;

        [JsonProperty("pwt")]
        public string PresetGameMode
        {
            get => presetGameMode;
            set
            {
                if (ReferenceEquals(presetGameMode, value) != true)
                {
                    presetGameMode = value;
                    OnPropertyChanged("PresetGameMode");
                }
            }
        }
    }
}