using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
    using Base;
        
    public class PlayerBase : ModelBase
    {
        private long baseVersion;
        private long originalBaseVersion;
        private object galacticAddress;
        private decimal[] position;
        private decimal[] forward;
        private long userData;
        private long lastUpdateTimestamp;
        private ObservableCollection<PlayerBaseItem> objects;
        private string rID;
        private PlayerBaseOwner owner;
        private string name;
        private PlayerBaseType baseType;
        private string lastEditedById;
        private string lastEditedByUsername;
        private decimal[] screenshotAt;
        private decimal[] screenshotPos;
        private PlayerBaseMode gameMode;
        private string platformToken;
        private bool isReported;
        private bool isFeatured;

        [JsonProperty("h4X")]
        public long BaseVersion
        {
            get => baseVersion;
            set
            {
                if ((ReferenceEquals(baseVersion, value) != true))
                {
                    baseVersion = value;
                    OnPropertyChanged("BaseVersion");
                }
            }
        }

        [JsonProperty("BpT")]
        public long OriginalBaseVersion
        {
            get => originalBaseVersion;
            set
            {
                if ((ReferenceEquals(originalBaseVersion, value) != true))
                {
                    originalBaseVersion = value;
                    OnPropertyChanged("OriginalBaseVersion");
                }
            }
        }

        [JsonProperty("oZw")]
        public object GalacticAddress
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

        [JsonProperty("wMC")]
        public decimal[] Position
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

        [JsonProperty("oHw")]
        public decimal[] Forward
        {
            get => forward;
            set
            {
                if ((ReferenceEquals(forward, value) != true))
                {
                    forward = value;
                    OnPropertyChanged("Forward");
                }
            }
        }

        [JsonProperty("CVX")]
        public long UserData
        {
            get => userData;
            set
            {
                if ((ReferenceEquals(userData, value) != true))
                {
                    userData = value;
                    OnPropertyChanged("UserData");
                }
            }
        }

        [JsonProperty("wx7")]
        public long LastUpdateTimestamp
        {
            get => lastUpdateTimestamp;
            set
            {
                if ((ReferenceEquals(lastUpdateTimestamp, value) != true))
                {
                    lastUpdateTimestamp = value;
                    OnPropertyChanged("LastUpdateTimestamp");
                }
            }
        }

        [JsonProperty("@ZJ")]
        public ObservableCollection<PlayerBaseItem> Objects
        {
            get => objects;
            set
            {
                if ((ReferenceEquals(objects, value) != true))
                {
                    objects = value;
                    OnPropertyChanged("Objects");
                }
            }
        }

        [JsonProperty("B2h")]
        public string RID
        {
            get => rID;
            set
            {
                if ((ReferenceEquals(rID, value) != true))
                {
                    rID = value;
                    OnPropertyChanged("RID");
                }
            }
        }

        [JsonProperty("3?K")]
        public PlayerBaseOwner Owner
        {
            get => owner;
            set
            {
                if ((ReferenceEquals(owner, value) != true))
                {
                    owner = value;
                    OnPropertyChanged("Owner");
                }
            }
        }

        [JsonProperty("NKm")]
        public string Name
        {
            get => name;
            set
            {
                if ((ReferenceEquals(name, value) != true))
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        [JsonProperty("peI")]
        public PlayerBaseType BaseType
        {
            get => baseType;
            set
            {
                if ((ReferenceEquals(baseType, value) != true))
                {
                    baseType = value;
                    OnPropertyChanged("BaseType");
                }
            }
        }

        [JsonProperty("J=S")]
        public string LastEditedById
        {
            get => lastEditedById;
            set
            {
                if ((ReferenceEquals(lastEditedById, value) != true))
                {
                    lastEditedById = value;
                    OnPropertyChanged("LastEditedById");
                }
            }
        }

        [JsonProperty("vyN")]
        public string LastEditedByUsername
        {
            get => lastEditedByUsername;
            set
            {
                if ((ReferenceEquals(lastEditedByUsername, value) != true))
                {
                    lastEditedByUsername = value;
                    OnPropertyChanged("LastEditedByUsername");
                }
            }
        }

        [JsonProperty("D9@")]
        public decimal[] ScreenshotAt
        {
            get => screenshotAt;
            set
            {
                if ((ReferenceEquals(screenshotAt, value) != true))
                {
                    screenshotAt = value;
                    OnPropertyChanged("ScreenshotAt");
                }
            }
        }

        [JsonProperty("rIR")]
        public decimal[] ScreenshotPos
        {
            get => screenshotPos;
            set
            {
                if ((ReferenceEquals(screenshotPos, value) != true))
                {
                    screenshotPos = value;
                    OnPropertyChanged("ScreenshotPos");
                }
            }
        }

        [JsonProperty("idA")]
        public PlayerBaseMode GameMode
        {
            get => gameMode;
            set
            {
                if ((ReferenceEquals(gameMode, value) != true))
                {
                    gameMode = value;
                    OnPropertyChanged("GameMode");
                }
            }
        }

        [JsonProperty("C0j")]
        public string PlatformToken
        {
            get => platformToken;
            set
            {
                if ((ReferenceEquals(platformToken, value) != true))
                {
                    platformToken = value;
                    OnPropertyChanged("PlatformToken");
                }
            }
        }

        [JsonProperty("i4g")]
        public bool IsReported
        {
            get => isReported;
            set
            {
                if ((ReferenceEquals(isReported, value) != true))
                {
                    isReported = value;
                    OnPropertyChanged("IsReported");
                }
            }
        }

        [JsonProperty("tww")]
        public bool IsFeatured
        {
            get => isFeatured;
            set
            {
                if ((ReferenceEquals(isFeatured, value) != true))
                {
                    isFeatured = value;
                    OnPropertyChanged("IsFeatured");
                }
            }
        }
    }
}