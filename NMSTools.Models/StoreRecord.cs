using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class StoreRecord : ModelBase
	{
		private ObservableCollection<RecordData> records;

        [JsonProperty("?fB")]
		public ObservableCollection<RecordData> Records
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
