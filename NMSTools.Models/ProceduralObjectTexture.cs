using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class ProceduralObjectTexture : ModelBase
    {
        private string[] samplers;

        [DataMember(Name = "bnT")]
        public string[] Samplers
        {
            get => samplers;
            set
            {
                if ((ReferenceEquals(samplers, value) != true))
                {
                    samplers = value;
                    OnPropertyChanged("Samplers");
                }
            }
        }
    }
}