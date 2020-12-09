using System.Runtime.Serialization;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class NMSRoot : ModelBase
    {
        private int version;
        private string platform;
        private StateData playerStateData;
        private SpawnData spawnStateData;
        private KnowledgetData gameKnowledgeData;
        private DiscoveryData discoveryManagerData;

        [DataMember(Name = "F2P")]
        public int Version
        {
            get => version;
            set
            {
                if ((ReferenceEquals(version, value) != true))
                {
                    version = value;
                    OnPropertyChanged("Version");
                }
            }
        }

        [DataMember(Name = "8>q")]
        public string Platform
        {
            get => platform;
            set
            {
                if ((ReferenceEquals(platform, value) != true))
                {
                    platform = value;
                    OnPropertyChanged("Platform");
                }
            }
        }

        [DataMember(Name = "6f=")]
        public StateData PlayerStateData
        {
            get => playerStateData;
            set
            {
                if ((ReferenceEquals(playerStateData, value) != true))
                {
                    playerStateData = value;
                    OnPropertyChanged("PlayerStateData");
                }
            }
        }

        [DataMember(Name = "rnc")]
        public SpawnData SpawnStateData
        {
            get => spawnStateData;
            set
            {
                if ((ReferenceEquals(spawnStateData, value) != true))
                {
                    spawnStateData = value;
                    OnPropertyChanged("SpawnStateData");
                }
            }
        }

        [DataMember(Name = "VuQ")]
        public KnowledgetData GameKnowledgeData
        {
            get => gameKnowledgeData;
            set
            {
                if ((ReferenceEquals(gameKnowledgeData, value) != true))
                {
                    gameKnowledgeData = value;
                    OnPropertyChanged("GameKnowledgeData");
                }
            }
        }

        [DataMember(Name = "fDu")]
        public DiscoveryData DiscoveryManagerData
        {
            get => discoveryManagerData;
            set
            {
                if ((ReferenceEquals(discoveryManagerData, value) != true))
                {
                    discoveryManagerData = value;
                    OnPropertyChanged("DiscoveryManagerData");
                }
            }
        }
    }
}