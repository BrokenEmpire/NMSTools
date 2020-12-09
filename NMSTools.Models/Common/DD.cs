using System.Runtime.Serialization;

namespace NMSTools.Models.Common
{
    using Base;

    [DataContract]
    public class DD : ModelBase
    {
        private object uA;
        private string dT;
        private object[] vP;

        [DataMember(Name = "5L6")]
        public object UA
        {
            get => uA;
            set
            {
                if ((ReferenceEquals(uA, value) != true))
                {
                    uA = value;
                    OnPropertyChanged("UA");
                }
            }
        }

        [DataMember(Name = "<Dn")]
        public string DT
        {
            get => dT;
            set
            {
                if ((ReferenceEquals(dT, value) != true))
                {
                    dT = value;
                    OnPropertyChanged("DT");
                }
            }
        }

        [DataMember(Name = "bEr")]
        public object[] VP
        {
            get => vP;
            set
            {
                if ((ReferenceEquals(vP, value) != true))
                {
                    vP = value;
                    OnPropertyChanged("VP");
                }
            }
        }
    }
}