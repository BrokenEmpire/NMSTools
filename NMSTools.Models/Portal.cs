using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class Portal : ModelBase
	{
		private ObservableCollection<object> portalSeed;
		private string lastPortalUA;

        [JsonProperty("3fO")]
		public ObservableCollection<object> PortalSeed
		{
			get => portalSeed;
			set
			{
				if ((ReferenceEquals(portalSeed, value) != true))
				{
					portalSeed = value;
					OnPropertyChanged("PortalSeed");
				}
			}
		}

        [JsonProperty("K:U")]
		public string LastPortalUA
		{
			get => lastPortalUA;
			set
			{
				if ((ReferenceEquals(lastPortalUA, value) != true))
				{
					lastPortalUA = value;
					OnPropertyChanged("LastPortalUA");
				}
			}
		}

	}
}
