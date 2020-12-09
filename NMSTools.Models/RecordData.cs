using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;
    using Common;

    [DataContract]
    public class RecordData : ModelBase
    {
        private DD dD;
        private DM dM;
        private OWS oWS;
        private FL fL;
        private string rID;
        private string pTK;

        [DataMember(Name = "8P3")]
        public DD DD
        {
            get => dD;
            set
            {
                if ((ReferenceEquals(dD, value) != true))
                {
                    dD = value;
                    OnPropertyChanged("DD");
                }
            }
        }

        [DataMember(Name = "q9a")]
        public DM DM
        {
            get => dM;
            set
            {
                if ((ReferenceEquals(dM, value) != true))
                {
                    dM = value;
                    OnPropertyChanged("DM");
                }
            }
        }

        [DataMember(Name = "ksu")]
        public OWS OWS
        {
            get => oWS;
            set
            {
                if ((ReferenceEquals(oWS, value) != true))
                {
                    oWS = value;
                    OnPropertyChanged("OWS");
                }
            }
        }

        [DataMember(Name = "=wD")]
        public FL FL
        {
            get => fL;
            set
            {
                if ((ReferenceEquals(fL, value) != true))
                {
                    fL = value;
                    OnPropertyChanged("FL");
                }
            }
        }

        [DataMember(Name = "B2h")]
        public string RID
        {
            get => rID;
            set
            {
                if ((ReferenceEquals(rID, value) != true))
                {
                    rID = value;
                    OnPropertyChanged("RID");
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
    }
}