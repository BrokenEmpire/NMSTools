using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models.Common
{
	using Base;
	using Common;

    public class FL : ModelBase
	{
		private int c;
		private int unknown;

        [JsonProperty("bLr")]
		public int C
		{
			get => c;
			set
			{
				if ((ReferenceEquals(c, value) != true))
				{
					c = value;
					OnPropertyChanged("C");
				}
			}
		}

        [JsonProperty("tiH")]
		public int Unknown
		{
			get => unknown;
			set
			{
				if ((ReferenceEquals(unknown, value) != true))
				{
					unknown = value;
					OnPropertyChanged("Unknown");
				}
			}
		}

	}
}
