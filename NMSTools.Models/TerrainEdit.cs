using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class TerrainEdit : ModelBase
    {
        private int data;
        private int position;

        [DataMember(Name = "8?J")]
        public int Data
        {
            get => data;
            set
            {
                if ((ReferenceEquals(data, value) != true))
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        [DataMember(Name = "wMC")]
        public int Position
        {
            get => position;
            set
            {
                if ((ReferenceEquals(position, value) != true))
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }
    }
}