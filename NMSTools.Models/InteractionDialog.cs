using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class InteractionDialog : ModelBase
    {
        private string hash;
        private string dialog;

        [DataMember(Name = "E=X")]
        public string Hash
        {
            get => hash;
            set
            {
                if ((ReferenceEquals(hash, value) != true))
                {
                    hash = value;
                    OnPropertyChanged("Hash");
                }
            }
        }

        [DataMember(Name = "2Fk")]
        public string Dialog
        {
            get => dialog;
            set
            {
                if ((ReferenceEquals(dialog, value) != true))
                {
                    dialog = value;
                    OnPropertyChanged("Dialog");
                }
            }
        }
    }
}