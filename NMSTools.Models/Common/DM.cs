using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models.Common
{
	using Base;
	using Common;

    public class DM : ModelBase
	{
		private string cN;

        [JsonProperty("q5u")]
		public string CN
		{
			get => cN;
			set
			{
				if ((ReferenceEquals(cN, value) != true))
				{
					cN = value;
					OnPropertyChanged("CN");
				}
			}
		}

	}
}
