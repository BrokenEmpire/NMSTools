using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class HotAction : ModelBase
    {
        private KeyAction[] keyActions;

        [DataMember(Name = "sM@")]
        public KeyAction[] KeyActions
        {
            get => keyActions;
            set
            {
                if ((ReferenceEquals(keyActions, value) != true))
                {
                    keyActions = value;
                    OnPropertyChanged("KeyActions");
                }
            }
        }
    }
}