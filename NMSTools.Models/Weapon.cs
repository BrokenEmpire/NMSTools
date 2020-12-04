using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class Weapon : ModelBase
	{
		private string filename;
		private ObservableCollection<object> generationSeed;

        [JsonProperty("93M")]
		public string Filename
		{
			get => filename;
			set
			{
				if ((ReferenceEquals(filename, value) != true))
				{
					filename = value;
					OnPropertyChanged("Filename");
				}
			}
		}

        [JsonProperty("NNR")]
		public ObservableCollection<object> GenerationSeed
		{
			get => generationSeed;
			set
			{
				if ((ReferenceEquals(generationSeed, value) != true))
				{
					generationSeed = value;
					OnPropertyChanged("GenerationSeed");
				}
			}
		}

	}
}
