using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;

    [JsonObject]
    public class TerrainEdit : ModelBase
    {
        private int data;
        private int position;

        [JsonProperty("8?J")]
        public int Data
        {
            get => data;
            set
            {
                if (ReferenceEquals(data, value) != true)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        [JsonProperty("wMC")]
        public int Position
        {
            get => position;
            set
            {
                if (ReferenceEquals(position, value) != true)
                {
                    position = value;
                    OnPropertyChanged("Position");
                }
            }
        }
    }
}