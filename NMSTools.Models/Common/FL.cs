using System.Runtime.Serialization;

namespace NMSTools.Models.Common
{
    using Base;

    [DataContract]
    public class FL : ModelBase
    {
        private int c;
        private int unknown;

        [DataMember(Name = "bLr")]
        public int C
        {
            get => c;
            set
            {
                if ((ReferenceEquals(c, value) != true))
                {
                    c = value;
                    OnPropertyChanged("C");
                }
            }
        }

        [DataMember(Name = "tiH")]
        public int Unknown
        {
            get => unknown;
            set
            {
                if ((ReferenceEquals(unknown, value) != true))
                {
                    unknown = value;
                    OnPropertyChanged("Unknown");
                }
            }
        }
    }
}