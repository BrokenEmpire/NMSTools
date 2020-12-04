using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class ProceduralObjectTexture : ModelBase
	{
		private object[] samplers;

        [JsonProperty("bnT")]
		public object[] Samplers
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
