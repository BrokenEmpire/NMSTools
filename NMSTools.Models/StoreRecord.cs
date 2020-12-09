using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StoreRecord : ModelBase
    {
        private RecordData[] records;

        [DataMember(Name = "?fB")]
        public RecordData[] Records
        {
            get => records;
            set
            {
                if ((ReferenceEquals(records, value) != true))
                {
                    records = value;
                    OnPropertyChanged("Records");
                }
            }
        }
    }
}