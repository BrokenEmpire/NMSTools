using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class OutfitPreset : ModelBase
    {
        private string selectedPreset;
        private Outfit presetData;

        [JsonProperty("VFd")]
        public string SelectedPreset
        {
            get => selectedPreset;
            set
            {
                if (ReferenceEquals(selectedPreset, value) != true)
                {
                    selectedPreset = value;
                    OnPropertyChanged("SelectedPreset");
                }
            }
        }

        [JsonProperty("wnR")]
        public Outfit PresetData
        {
            get => presetData;
            set
            {
                if (ReferenceEquals(presetData, value) != true)
                {
                    presetData = value;
                    OnPropertyChanged("PresetData");
                }
            }
        }
    }
}