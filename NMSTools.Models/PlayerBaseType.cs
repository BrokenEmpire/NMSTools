using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class PlayerBaseType : ModelBase
	{
		private string persistentBaseTypes;

        [JsonProperty("DPp")]
		public string PersistentBaseTypes
		{
			get => persistentBaseTypes;
			set
			{
				if ((ReferenceEquals(persistentBaseTypes, value) != true))
				{
					persistentBaseTypes = value;
					OnPropertyChanged("PersistentBaseTypes");
				}
			}
		}

	}
}
