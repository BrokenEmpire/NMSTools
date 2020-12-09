using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class SlotIndex : ModelBase
    {
        private short x;
        private short y;

        [DataMember(Name = ">Qh")]
        public short X
        {
            get => x;
            set
            {
                if ((ReferenceEquals(x, value) != true))
                {
                    x = value;
                    OnPropertyChanged("X");
                }
            }
        }

        [DataMember(Name = "XJ>")]
        public short Y
        {
            get => y;
            set
            {
                if ((ReferenceEquals(y, value) != true))
                {
                    y = value;
                    OnPropertyChanged("Y");
                }
            }
        }
    }
}