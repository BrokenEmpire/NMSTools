using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class SlotIndex : ModelBase
	{
		private short x;
		private short y;

        [JsonProperty(">Qh")]
		public short X
		{
			get => x;
			set
			{
				if ((ReferenceEquals(x, value) != true))
				{
					x = value;
					OnPropertyChanged("X");
				}
			}
		}

        [JsonProperty("XJ>")]
		public short Y
		{
			get => y;
			set
			{
				if ((ReferenceEquals(y, value) != true))
				{
					y = value;
					OnPropertyChanged("Y");
				}
			}
		}

	}
}
