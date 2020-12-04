using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class StoreRecord : ModelBase
	{
		private RecordData[] records;

        [JsonProperty("?fB")]
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
