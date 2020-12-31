using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class RecordData : ModelBase
    {
        private DD dD;
        private DM dM;
        private OWS oWS;
        private FL fL;
        private string rID;
        private string pTK;

        [JsonProperty("8P3")]
        public DD DD
        {
            get => dD;
            set
            {
                if (ReferenceEquals(dD, value) != true)
                {
                    dD = value;
                    OnPropertyChanged("DD");
                }
            }
        }

        [JsonProperty("q9a")]
        public DM DM
        {
            get => dM;
            set
            {
                if (ReferenceEquals(dM, value) != true)
                {
                    dM = value;
                    OnPropertyChanged("DM");
                }
            }
        }

        [JsonProperty("ksu")]
        public OWS OWS
        {
            get => oWS;
            set
            {
                if (ReferenceEquals(oWS, value) != true)
                {
                    oWS = value;
                    OnPropertyChanged("OWS");
                }
            }
        }

        [JsonProperty("=wD", NullValueHandling = NullValueHandling.Ignore)]
        public FL FL
        {
            get => fL;
            set
            {
                if (ReferenceEquals(fL, value) != true)
                {
                    fL = value;
                    OnPropertyChanged("FL");
                }
            }
        }

        [JsonProperty("B2h", NullValueHandling = NullValueHandling.Ignore)]
        public string RID
        {
            get => rID;
            set
            {
                if (ReferenceEquals(rID, value) != true)
                {
                    rID = value;
                    OnPropertyChanged("RID");
                }
            }
        }

        [JsonProperty("D6b", NullValueHandling = NullValueHandling.Ignore)]
        public string PTK
        {
            get => pTK;
            set
            {
                if (ReferenceEquals(pTK, value) != true)
                {
                    pTK = value;
                    OnPropertyChanged("PTK");
                }
            }
        }
    }
}