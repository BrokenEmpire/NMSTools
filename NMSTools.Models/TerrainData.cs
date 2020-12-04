using Newtonsoft.Json;

namespace NMSTools.Models
{
    using Base;

    public class TerrainData : ModelBase
    {
        private string[] galacticAddresses;
        private int[] bufferSizes;
        private int[] bufferAges;
        private float[][] bufferAnchors;
        private bool[] bufferProtected;
        private TerrainEdit[] edits;

        [JsonProperty("r:j")]
        public string[] GalacticAddresses
        {
            get => galacticAddresses;
            set
            {
                if ((ReferenceEquals(galacticAddresses, value) != true))
                {
                    galacticAddresses = value;
                    OnPropertyChanged("GalacticAddresses");
                }
            }
        }

        [JsonProperty("eiy")]
        public int[] BufferSizes
        {
            get => bufferSizes;
            set
            {
                if ((ReferenceEquals(bufferSizes, value) != true))
                {
                    bufferSizes = value;
                    OnPropertyChanged("BufferSizes");
                }
            }
        }

        [JsonProperty("w0G")]
        public int[] BufferAges
        {
            get => bufferAges;
            set
            {
                if ((ReferenceEquals(bufferAges, value) != true))
                {
                    bufferAges = value;
                    OnPropertyChanged("BufferAges");
                }
            }
        }

        [JsonProperty("cL6")]
        public float[][] BufferAnchors
        {
            get => bufferAnchors;
            set
            {
                if ((ReferenceEquals(bufferAnchors, value) != true))
                {
                    bufferAnchors = value;
                    OnPropertyChanged("BufferAnchors");
                }
            }
        }

        [JsonProperty("deQ")]
        public bool[] BufferProtected
        {
            get => bufferProtected;
            set
            {
                if ((ReferenceEquals(bufferProtected, value) != true))
                {
                    bufferProtected = value;
                    OnPropertyChanged("BufferProtected");
                }
            }
        }

        [JsonProperty("Mes")]
        public TerrainEdit[] Edits
        {
            get => edits;
            set
            {
                if ((ReferenceEquals(edits, value) != true))
                {
                    edits = value;
                    OnPropertyChanged("Edits");
                }
            }
        }
    }
}