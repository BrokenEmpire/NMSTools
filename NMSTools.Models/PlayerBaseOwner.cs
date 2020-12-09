using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class PlayerBaseOwner : ModelBase
    {
        private string lID;
        private string uID;
        private string uSN;
        private string pTK;
        private long tS;

        [DataMember(Name = "f5Q")]
        public string LID
        {
            get => lID;
            set
            {
                if ((ReferenceEquals(lID, value) != true))
                {
                    lID = value;
                    OnPropertyChanged("LID");
                }
            }
        }

        [DataMember(Name = "K7E")]
        public string UID
        {
            get => uID;
            set
            {
                if ((ReferenceEquals(uID, value) != true))
                {
                    uID = value;
                    OnPropertyChanged("UID");
                }
            }
        }

        [DataMember(Name = "V?:")]
        public string USN
        {
            get => uSN;
            set
            {
                if ((ReferenceEquals(uSN, value) != true))
                {
                    uSN = value;
                    OnPropertyChanged("USN");
                }
            }
        }

        [DataMember(Name = "D6b")]
        public string PTK
        {
            get => pTK;
            set
            {
                if ((ReferenceEquals(pTK, value) != true))
                {
                    pTK = value;
                    OnPropertyChanged("PTK");
                }
            }
        }

        [DataMember(Name = "3I1")]
        public long TS
        {
            get => tS;
            set
            {
                if ((ReferenceEquals(tS, value) != true))
                {
                    tS = value;
                    OnPropertyChanged("TS");
                }
            }
        }
    }
}