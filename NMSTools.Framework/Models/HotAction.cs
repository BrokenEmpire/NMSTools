using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]       
    public class HotAction : ModelBase
    {
        private KeyAction[] keyActions;

        [JsonProperty("sM@")]
        public KeyAction[] KeyActions
        {
            get => keyActions;
            set
            {
                if (ReferenceEquals(keyActions, value) != true)
                {
                    keyActions = value;
                    OnPropertyChanged("KeyActions");
                }
            }
        }
    }
}