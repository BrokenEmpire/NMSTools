using Newtonsoft.Json;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
        
    public class NMSRoot : ModelBase
    {
        private int version;
        private string platform;
        private PlayerState playerStateData;
        private SpawnData spawnStateData;
        private KnowledgetData gameKnowledgeData;
        private DiscoveryData discoveryManagerData;

        [JsonProperty("F2P")]
        public int Version
        {
            get => version;
            set
            {
                if (ReferenceEquals(version, value) != true)
                {
                    version = value;
                    OnPropertyChanged("Version");
                }
            }
        }

        [JsonProperty("8>q")]
        public string Platform
        {
            get => platform;
            set
            {
                if (ReferenceEquals(platform, value) != true)
                {
                    platform = value;
                    OnPropertyChanged("Platform");
                }
            }
        }

        [JsonProperty("6f=")]
        public PlayerState PlayerStateData
        {
            get => playerStateData;
            set
            {
                if (ReferenceEquals(playerStateData, value) != true)
                {
                    playerStateData = value;
                    OnPropertyChanged("PlayerStateData");
                }
            }
        }

        [JsonProperty("rnc")]
        public SpawnData SpawnStateData
        {
            get => spawnStateData;
            set
            {
                if (ReferenceEquals(spawnStateData, value) != true)
                {
                    spawnStateData = value;
                    OnPropertyChanged("SpawnStateData");
                }
            }
        }

        [JsonProperty("VuQ")]
        public KnowledgetData GameKnowledgeData
        {
            get => gameKnowledgeData;
            set
            {
                if (ReferenceEquals(gameKnowledgeData, value) != true)
                {
                    gameKnowledgeData = value;
                    OnPropertyChanged("GameKnowledgeData");
                }
            }
        }

        [JsonProperty("fDu")]
        public DiscoveryData DiscoveryManagerData
        {
            get => discoveryManagerData;
            set
            {
                if (ReferenceEquals(discoveryManagerData, value) != true)
                {
                    discoveryManagerData = value;
                    OnPropertyChanged("DiscoveryManagerData");
                }
            }
        }
    }
}