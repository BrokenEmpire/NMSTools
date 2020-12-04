using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class ProceduralObject : ModelBase
	{
		private string filename;
		private ObservableCollection<object> seed;
		private string altId;
		private ProceduralObjectTexture proceduralTexture;

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

        [JsonProperty("@EL")]
		public ObservableCollection<object> Seed
		{
			get => seed;
			set
			{
				if ((ReferenceEquals(seed, value) != true))
				{
					seed = value;
					OnPropertyChanged("Seed");
				}
			}
		}

        [JsonProperty("QlJ")]
		public string AltId
		{
			get => altId;
			set
			{
				if ((ReferenceEquals(altId, value) != true))
				{
					altId = value;
					OnPropertyChanged("AltId");
				}
			}
		}

        [JsonProperty("d2")]
		public ProceduralObjectTexture ProceduralTexture
		{
			get => proceduralTexture;
			set
			{
				if ((ReferenceEquals(proceduralTexture, value) != true))
				{
					proceduralTexture = value;
					OnPropertyChanged("ProceduralTexture");
				}
			}
		}

	}
}
