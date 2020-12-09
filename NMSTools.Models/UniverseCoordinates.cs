using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class UniverseCoordinates : ModelBase
    {
        private int realityIndex;
        private GalaxyCoordinates galacticAddress;

        [DataMember(Name = "Iis")]
        public int RealityIndex
        {
            get => realityIndex;
            set
            {
                if ((ReferenceEquals(realityIndex, value) != true))
                {
                    realityIndex = value;
                    OnPropertyChanged("RealityIndex");
                }
            }
        }

        [DataMember(Name = "oZw")]
        public GalaxyCoordinates GalacticAddress
        {
            get => galacticAddress;
            set
            {
                if ((ReferenceEquals(galacticAddress, value) != true))
                {
                    galacticAddress = value;
                    OnPropertyChanged("GalacticAddress");
                }
            }
        }
    }
}