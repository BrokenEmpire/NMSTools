using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    [JsonObject]
    public class PlayerBaseOwner : ModelBase
    {
        private string lID;
        private string uID;
        private string uSN;
        private string pTK;
        private long tS;

        [JsonProperty("f5Q")]
        public string LID
        {
            get => lID;
            set
            {
                if (ReferenceEquals(lID, value) != true)
                {
                    lID = value;
                    OnPropertyChanged("LID");
                }
            }
        }

        [JsonProperty("K7E")]
        public string UID
        {
            get => uID;
            set
            {
                if (ReferenceEquals(uID, value) != true)
                {
                    uID = value;
                    OnPropertyChanged("UID");
                }
            }
        }

        [JsonProperty("V?:")]
        public string USN
        {
            get => uSN;
            set
            {
                if (ReferenceEquals(uSN, value) != true)
                {
                    uSN = value;
                    OnPropertyChanged("USN");
                }
            }
        }

        [JsonProperty("D6b")]
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

        [JsonProperty("3I1")]
        public long TS
        {
            get => tS;
            set
            {
                if (ReferenceEquals(tS, value) != true)
                {
                    tS = value;
                    OnPropertyChanged("TS");
                }
            }
        }
    }
}