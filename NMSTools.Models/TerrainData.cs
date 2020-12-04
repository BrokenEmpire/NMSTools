using Newtonsoft.Json;

using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;

    public class TerrainData : ModelBase
	{
		private ObservableCollection<object> galacticAddresses;
		private ObservableCollection<object> bufferSizes;
		private ObservableCollection<object> bufferAges;
		private ObservableCollection<object> bufferAnchors;
		private ObservableCollection<object> bufferProtected;
		private ObservableCollection<object> edits;

        [JsonProperty("r:j")]
		public ObservableCollection<object> GalacticAddresses
		{
			get => galacticAddresses;
			set
			{
				if ((ReferenceEquals(galacticAddresses, value) != true))
				{
					galacticAddresses = value;
					OnPropertyChanged("GalacticAddresses");
				}
			}
		}

        [JsonProperty("eiy")]
		public ObservableCollection<object> BufferSizes
		{
			get => bufferSizes;
			set
			{
				if ((ReferenceEquals(bufferSizes, value) != true))
				{
					bufferSizes = value;
					OnPropertyChanged("BufferSizes");
				}
			}
		}

        [JsonProperty("w0G")]
		public ObservableCollection<object> BufferAges
		{
			get => bufferAges;
			set
			{
				if ((ReferenceEquals(bufferAges, value) != true))
				{
					bufferAges = value;
					OnPropertyChanged("BufferAges");
				}
			}
		}

        [JsonProperty("cL6")]
		public ObservableCollection<object> BufferAnchors
		{
			get => bufferAnchors;
			set
			{
				if ((ReferenceEquals(bufferAnchors, value) != true))
				{
					bufferAnchors = value;
					OnPropertyChanged("BufferAnchors");
				}
			}
		}

        [JsonProperty("deQ")]
		public ObservableCollection<object> BufferProtected
		{
			get => bufferProtected;
			set
			{
				if ((ReferenceEquals(bufferProtected, value) != true))
				{
					bufferProtected = value;
					OnPropertyChanged("BufferProtected");
				}
			}
		}

        [JsonProperty("Mes")]
		public ObservableCollection<object> Edits
		{
			get => edits;
			set
			{
				if ((ReferenceEquals(edits, value) != true))
				{
					edits = value;
					OnPropertyChanged("Edits");
				}
			}
		}

	}
}
