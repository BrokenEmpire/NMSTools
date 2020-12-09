using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class ProceduralObject : ModelBase
    {
        private string filename;
        private object[] seed;
        private string altId;
        private ProceduralObjectTexture proceduralTexture;

        [DataMember(Name = "93M")]
        public string Filename
        {
            get => filename;
            set
            {
                if ((ReferenceEquals(filename, value) != true))
                {
                    filename = value;
                    OnPropertyChanged("Filename");
                }
            }
        }

        [DataMember(Name = "@EL")]
        public object[] Seed
        {
            get => seed;
            set
            {
                if ((ReferenceEquals(seed, value) != true))
                {
                    seed = value;
                    OnPropertyChanged("Seed");
                }
            }
        }

        [DataMember(Name = "QlJ")]
        public string AltId
        {
            get => altId;
            set
            {
                if ((ReferenceEquals(altId, value) != true))
                {
                    altId = value;
                    OnPropertyChanged("AltId");
                }
            }
        }

        [DataMember(Name = "<d2")]
        public ProceduralObjectTexture ProceduralTexture
        {
            get => proceduralTexture;
            set
            {
                if ((ReferenceEquals(proceduralTexture, value) != true))
                {
                    proceduralTexture = value;
                    OnPropertyChanged("ProceduralTexture");
                }
            }
        }
    }
}