using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class UniverseCoordinates : ModelBase
    {
        private int realityIndex;
        private GalaxyCoordinates galacticAddress;

        [JsonProperty("Iis")]
        public int RealityIndex
        {
            get => realityIndex;
            set
            {
                if (ReferenceEquals(realityIndex, value) != true)
                {
                    realityIndex = value;
                    OnPropertyChanged("RealityIndex");
                }
            }
        }

        [JsonProperty("oZw")]
        public GalaxyCoordinates GalacticAddress
        {
            get => galacticAddress;
            set
            {
                if (ReferenceEquals(galacticAddress, value) != true)
                {
                    galacticAddress = value;
                    OnPropertyChanged("GalacticAddress");
                }
            }
        }
    }
}