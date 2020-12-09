using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class GamePreset : ModelBase
    {
        private string presetGameMode;

        [DataMember(Name = "pwt")]
        public string PresetGameMode
        {
            get => presetGameMode;
            set
            {
                if ((ReferenceEquals(presetGameMode, value) != true))
                {
                    presetGameMode = value;
                    OnPropertyChanged("PresetGameMode");
                }
            }
        }
    }
}