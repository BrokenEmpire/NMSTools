using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class Action : ModelBase
    {
        private string quickMenuActions;

        [JsonProperty("<6x")]
        public string QuickMenuActions
        {
            get => quickMenuActions;
            set
            {
                if ((ReferenceEquals(quickMenuActions, value) != true))
                {
                    quickMenuActions = value;
                    OnPropertyChanged("QuickMenuActions");
                }
            }
        }
    }
}
