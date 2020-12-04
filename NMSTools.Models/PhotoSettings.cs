using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
	using Base;
	using Common;

    public class PhotoSettings : ModelBase
	{
		private float fog;
		private long cloudAmount;
		private ObservableCollection<object> sunDir;
		private bool sunDirSet;
		private long foV;
		private bool foVSet;
		private string depthOfField;
		private long depthOfFieldStrengthSetting;
		private long depthOfFieldDistance;
		private long depthOfFieldDistanceSpace;
		private long halfFocalPlaneDepth;
		private long halfFocalPlaneDepthSpace;
		private float vignette;
		private long filter;

        [JsonProperty("qAx")]
		public float Fog
		{
			get => fog;
			set
			{
				if ((ReferenceEquals(fog, value) != true))
				{
					fog = value;
					OnPropertyChanged("Fog");
				}
			}
		}

        [JsonProperty("22a")]
		public long CloudAmount
		{
			get => cloudAmount;
			set
			{
				if ((ReferenceEquals(cloudAmount, value) != true))
				{
					cloudAmount = value;
					OnPropertyChanged("CloudAmount");
				}
			}
		}

        [JsonProperty("qLk")]
		public ObservableCollection<object> SunDir
		{
			get => sunDir;
			set
			{
				if ((ReferenceEquals(sunDir, value) != true))
				{
					sunDir = value;
					OnPropertyChanged("SunDir");
				}
			}
		}

        [JsonProperty("OCG")]
		public bool SunDirSet
		{
			get => sunDirSet;
			set
			{
				if ((ReferenceEquals(sunDirSet, value) != true))
				{
					sunDirSet = value;
					OnPropertyChanged("SunDirSet");
				}
			}
		}

        [JsonProperty("yGF")]
		public long FoV
		{
			get => foV;
			set
			{
				if ((ReferenceEquals(foV, value) != true))
				{
					foV = value;
					OnPropertyChanged("FoV");
				}
			}
		}

        [JsonProperty("ARP")]
		public bool FoVSet
		{
			get => foVSet;
			set
			{
				if ((ReferenceEquals(foVSet, value) != true))
				{
					foVSet = value;
					OnPropertyChanged("FoVSet");
				}
			}
		}

        [JsonProperty("?sW")]
		public string DepthOfField
		{
			get => depthOfField;
			set
			{
				if ((ReferenceEquals(depthOfField, value) != true))
				{
					depthOfField = value;
					OnPropertyChanged("DepthOfField");
				}
			}
		}

        [JsonProperty("wKU")]
		public long DepthOfFieldStrengthSetting
		{
			get => depthOfFieldStrengthSetting;
			set
			{
				if ((ReferenceEquals(depthOfFieldStrengthSetting, value) != true))
				{
					depthOfFieldStrengthSetting = value;
					OnPropertyChanged("DepthOfFieldStrengthSetting");
				}
			}
		}

        [JsonProperty("RUO")]
		public long DepthOfFieldDistance
		{
			get => depthOfFieldDistance;
			set
			{
				if ((ReferenceEquals(depthOfFieldDistance, value) != true))
				{
					depthOfFieldDistance = value;
					OnPropertyChanged("DepthOfFieldDistance");
				}
			}
		}

        [JsonProperty("yuu")]
		public long DepthOfFieldDistanceSpace
		{
			get => depthOfFieldDistanceSpace;
			set
			{
				if ((ReferenceEquals(depthOfFieldDistanceSpace, value) != true))
				{
					depthOfFieldDistanceSpace = value;
					OnPropertyChanged("DepthOfFieldDistanceSpace");
				}
			}
		}

        [JsonProperty("n0h")]
		public long HalfFocalPlaneDepth
		{
			get => halfFocalPlaneDepth;
			set
			{
				if ((ReferenceEquals(halfFocalPlaneDepth, value) != true))
				{
					halfFocalPlaneDepth = value;
					OnPropertyChanged("HalfFocalPlaneDepth");
				}
			}
		}

        [JsonProperty(">xF")]
		public long HalfFocalPlaneDepthSpace
		{
			get => halfFocalPlaneDepthSpace;
			set
			{
				if ((ReferenceEquals(halfFocalPlaneDepthSpace, value) != true))
				{
					halfFocalPlaneDepthSpace = value;
					OnPropertyChanged("HalfFocalPlaneDepthSpace");
				}
			}
		}

        [JsonProperty("L85")]
		public float Vignette
		{
			get => vignette;
			set
			{
				if ((ReferenceEquals(vignette, value) != true))
				{
					vignette = value;
					OnPropertyChanged("Vignette");
				}
			}
		}

        [JsonProperty("HJQ")]
		public long Filter
		{
			get => filter;
			set
			{
				if ((ReferenceEquals(filter, value) != true))
				{
					filter = value;
					OnPropertyChanged("Filter");
				}
			}
		}

	}
}
