using Newtonsoft.Json;

namespace NMSTools.Models.Common
{
    using Base;

    public class DD : ModelBase
    {
        private object uA;
        private string dT;
        private object[] vP;

        [JsonProperty("5L6")]
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

        [JsonProperty("<Dn")]
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

        [JsonProperty("bEr")]
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