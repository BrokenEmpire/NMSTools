using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class GamePreset : ModelBase
	{
		private string presetGameMode;

        [JsonProperty("pwt")]
		public string PresetGameMode
		{
			get => presetGameMode;
			set
			{
				if ((ReferenceEquals(presetGameMode, value) != true))
				{
					presetGameMode = value;
					OnPropertyChanged("PresetGameMode");
				}
			}
		}

	}
}
