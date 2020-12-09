using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class OutfitPreset : ModelBase
    {
        private string selectedPreset;
        private Outfit presetData;

        [DataMember(Name = "VFd")]
        public string SelectedPreset
        {
            get => selectedPreset;
            set
            {
                if ((ReferenceEquals(selectedPreset, value) != true))
                {
                    selectedPreset = value;
                    OnPropertyChanged("SelectedPreset");
                }
            }
        }

        [DataMember(Name = "wnR")]
        public Outfit PresetData
        {
            get => presetData;
            set
            {
                if ((ReferenceEquals(presetData, value) != true))
                {
                    presetData = value;
                    OnPropertyChanged("PresetData");
                }
            }
        }
    }
}