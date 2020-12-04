using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class WeaponDescription : ModelBase
	{
		private string weaponMode;

        [JsonProperty("Rfw")]
		public string WeaponMode
		{
			get => weaponMode;
			set
			{
				if ((ReferenceEquals(weaponMode, value) != true))
				{
					weaponMode = value;
					OnPropertyChanged("WeaponMode");
				}
			}
		}

	}
}
