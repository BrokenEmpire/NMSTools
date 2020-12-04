using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class SlotDescription : ModelBase
	{
		private string inventoryType;

        [JsonProperty("elv")]
		public string InventoryType
		{
			get => inventoryType;
			set
			{
				if ((ReferenceEquals(inventoryType, value) != true))
				{
					inventoryType = value;
					OnPropertyChanged("InventoryType");
				}
			}
		}

	}
}
