using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class ProceduralObjectTexture : ModelBase
	{
		private ObservableCollection<object> samplers;

        [JsonProperty("bnT")]
		public ObservableCollection<object> Samplers
		{
			get => samplers;
			set
			{
				if ((ReferenceEquals(samplers, value) != true))
				{
					samplers = value;
					OnPropertyChanged("Samplers");
				}
			}
		}

	}
}
