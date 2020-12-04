using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class ProceduralObjectTexture : ModelBase
	{
		private string[] samplers;

        [JsonProperty("bnT")]
		public string[] Samplers
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
