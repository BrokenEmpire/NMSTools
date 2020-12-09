using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class Weapon : ModelBase
    {
        private string filename;
        private object[] generationSeed;

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

        [DataMember(Name = "NNR")]
        public object[] GenerationSeed
        {
            get => generationSeed;
            set
            {
                if ((ReferenceEquals(generationSeed, value) != true))
                {
                    generationSeed = value;
                    OnPropertyChanged("GenerationSeed");
                }
            }
        }
    }
}