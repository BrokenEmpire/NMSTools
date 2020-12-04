using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class Interaction : ModelBase
	{
		private long galacticAddress;
		private long interactionValue;
		private ObservableCollection<object> position;

        [JsonProperty("oZw")]
		public long GalacticAddress
		{
			get => galacticAddress;
			set
			{
				if ((ReferenceEquals(galacticAddress, value) != true))
				{
					galacticAddress = value;
					OnPropertyChanged("GalacticAddress");
				}
			}
		}

        [JsonProperty(">MX")]
		public long InteractionValue
		{
			get => interactionValue;
			set
			{
				if ((ReferenceEquals(interactionValue, value) != true))
				{
					interactionValue = value;
					OnPropertyChanged("InteractionValue");
				}
			}
		}

        [JsonProperty("wMC")]
		public ObservableCollection<object> Position
		{
			get => position;
			set
			{
				if ((ReferenceEquals(position, value) != true))
				{
					position = value;
					OnPropertyChanged("Position");
				}
			}
		}

	}
}
