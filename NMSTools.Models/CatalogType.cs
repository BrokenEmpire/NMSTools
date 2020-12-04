using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class CatalogType : ModelBase
	{
		private string inventoryClass;

        [JsonProperty("1o6")]
		public string InventoryClass
		{
			get => inventoryClass;
			set
			{
				if ((ReferenceEquals(inventoryClass, value) != true))
				{
					inventoryClass = value;
					OnPropertyChanged("InventoryClass");
				}
			}
		}
	}
}
