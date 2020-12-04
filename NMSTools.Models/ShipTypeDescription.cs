using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

    public class ShipTypeDescription : ModelBase
	{
		private string shipClass;

        [JsonProperty("eEU")]
		public string ShipClass
		{
			get => shipClass;
			set
			{
				if ((ReferenceEquals(shipClass, value) != true))
				{
					shipClass = value;
					OnPropertyChanged("ShipClass");
				}
			}
		}
	}
}
