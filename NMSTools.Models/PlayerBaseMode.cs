using Newtonsoft.Json;

namespace NMSTools.Models
{
	using Base;

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
