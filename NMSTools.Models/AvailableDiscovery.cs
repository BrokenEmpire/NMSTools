using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class AvailableDiscovery : ModelBase
	{
		private long tSrec;
		private DD dD;

        [JsonProperty("kVv")]
		public long TSrec
		{
			get => tSrec;
			set
			{
				if ((ReferenceEquals(tSrec, value) != true))
				{
					tSrec = value;
					OnPropertyChanged("TSrec");
				}
			}
		}

        [JsonProperty("8P3")]
		public DD DD
		{
			get => dD;
			set
			{
				if ((ReferenceEquals(dD, value) != true))
				{
					dD = value;
					OnPropertyChanged("DD");
				}
			}
		}
	}
}
