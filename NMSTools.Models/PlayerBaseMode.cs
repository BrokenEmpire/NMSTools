using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class PlayerBaseMode : ModelBase
	{
		private string persistentBaseTypes;

        [JsonProperty("pwt")]
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
