using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class StatData : ModelBase
	{
		private string baseStatID;
		private float statValue;

        [JsonProperty("@bB")]
		public string BaseStatID
		{
			get => baseStatID;
			set
			{
				if ((ReferenceEquals(baseStatID, value) != true))
				{
					baseStatID = value;
					OnPropertyChanged("BaseStatID");
				}
			}
		}

        [JsonProperty(">MX")]
		public float StatValue
		{
			get => statValue;
			set
			{
				if ((ReferenceEquals(statValue, value) != true))
				{
					statValue = value;
					OnPropertyChanged("StatValue");
				}
			}
		}

	}
}
