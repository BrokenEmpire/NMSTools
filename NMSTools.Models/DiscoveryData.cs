using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class DiscoveryData : ModelBase
	{
		private Discovery discoveryDataV1;

        [JsonProperty("ETO")]
		public Discovery DiscoveryDataV1
		{
			get => discoveryDataV1;
			set
			{
				if ((ReferenceEquals(discoveryDataV1, value) != true))
				{
					discoveryDataV1 = value;
					OnPropertyChanged("DiscoveryDataV1");
				}
			}
		}

	}
}
