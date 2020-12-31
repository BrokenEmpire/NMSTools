using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class StoreRecord : ModelBase
    {
        private RecordData[] records;

        [JsonProperty("?fB")]
        public RecordData[] Records
        {
            get => records;
            set
            {
                if (ReferenceEquals(records, value) != true)
                {
                    records = value;
                    OnPropertyChanged("Records");
                }
            }
        }
    }
}