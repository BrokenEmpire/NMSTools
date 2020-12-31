using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    [JsonObject]
    public class InteractionDialog : ModelBase
    {
        private string hash;
        private string dialog;

        [JsonProperty("E=X")]
        public string Hash
        {
            get => hash;
            set
            {
                if (ReferenceEquals(hash, value) != true)
                {
                    hash = value;
                    OnPropertyChanged("Hash");
                }
            }
        }

        [JsonProperty("2Fk")]
        public string Dialog
        {
            get => dialog;
            set
            {
                if (ReferenceEquals(dialog, value) != true)
                {
                    dialog = value;
                    OnPropertyChanged("Dialog");
                }
            }
        }
    }
}