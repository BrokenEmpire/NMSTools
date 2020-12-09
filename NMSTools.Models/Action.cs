using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract(Name = "Action")]
    public class Action : ModelBase
    {
        private string quickMenuActions;

        [DataMember(Name = "<6x")]
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