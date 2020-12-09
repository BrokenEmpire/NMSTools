using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class TerrainData : ModelBase
    {
        private string[] galacticAddresses;
        private int[] bufferSizes;
        private int[] bufferAges;
        private float[][] bufferAnchors;
        private bool[] bufferProtected;
        private TerrainEdit[] edits;

        [DataMember(Name = "r:j")]
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

        [DataMember(Name = "eiy")]
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

        [DataMember(Name = "w0G")]
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

        [DataMember(Name = "cL6")]
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

        [DataMember(Name = "deQ")]
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

        [DataMember(Name = "Mes")]
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