using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class ShipTypeDescription : ModelBase
	{
		private string shipClass;

        [JsonProperty("eEU")]
		public string ShipClass
		{
			get => shipClass;
			set
			{
				if ((ReferenceEquals(shipClass, value) != true))
				{
					shipClass = value;
					OnPropertyChanged("ShipClass");
				}
			}
		}

	}
}
