using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace NMSTools.Models
{
    using Base;

    [DataContract]
    public class StateData : ModelBase
    {
        private UniverseCoordinates universeAddress;
        private UniverseCoordinates previousUniverseAddress;
        private int homeRealityIteration;
        private Catalog inventory;
        private Catalog inventoryTech;
        private Catalog inventoryCargo;
        private Catalog inventoryShip;
        private Catalog inventoryWeapon;
        private ObservableCollection<MultiTool> multiTools;
        private short activeMultiTool;
        private Catalog inventoryGrave;
        private bool spawnGrave;
        private bool spaceGrave;
        private UniverseCoordinates graveUniverseAddress;
        private decimal[] gravePosition;
        private decimal[] graveMatrixLookAt;
        private decimal[] graveMatrixUp;
        private CatalogLayout shipLayout;
        private CatalogLayout weaponLayout;
        private ProceduralObject currentShip;
        private Weapon currentWeapon;
        private ObservableCollection<string> knownTech;
        private ObservableCollection<string> knownProducts;
        private ObservableCollection<string> knownSpecials;
        private ObservableCollection<string> knownRefinerRecipes;
        private ObservableCollection<string> knownWords;
        private WordGroup[] knownWordGroups;
        private Mission[] missionProgress;
        private int postMissionIndex;
        private string currentMissionID;
        private int currentMissionSeed;
        private string previousMissionID;
        private int previousMissionSeed;
        private int missionVersion;
        private MissionRecurrence[] missionRecurrences;
        private Interaction holoExplorerInteraction;
        private Interaction holoScepticInteraction;
        private Interaction holoNooneInteraction;
        private int health;
        private int shipHealth;
        private int shield;
        private int shipShield;
        private int energy;
        private int units;
        private int nanites;
        private int specials;
        private bool thirdPersonShip;
        private int timeAlive;
        private int totalPlayTime;
        private Marker[] markerStack;
        private object[] newMPMarkerStack;
        private object[] surveyedEventPositions;
        private int nextSurveyedEventPositionIndex;
        private Stat[] stats;
        private Telemetry[] telemetryStats;
        private StoredInteraction[] storedInteractions;
        private InteractionData[] maintenanceInteractions;
        private InteractionData[] personalMaintenanceInteractions;
        private long[] visitedSystems;
        private float[] hazard;
        private int boltAmmo;
        private int scatterAmmo;
        private int pulseAmmo;
        private int laserAmmo;
        private float[] firstSpawnPosition;
        private InteractionIndicies[] savedInteractionIndicies;
        private InteractionDialog[] savedInteractionDialogTable;
        private object[] interactionProgressTable;
        private UniverseCoordinates[] atlasStationAdressData;
        private UniverseCoordinates[] newAtlasStationAdressData;
        private UniverseCoordinates[] visitedAtlasStationsData;
        private bool firstAtlasStationDiscovered;
        private bool usesThirdPersonCharacterCam;
        private int progressionLevel;
        private int procTechIndex;
        private bool isNew;
        private bool useSmallerBlackholeJumps;
        private object[] usedEntitlements;
        private float[][] planetPositions;
        private object[][] planetSeeds;
        private int primaryPlanet;
        private int timeLastSpaceBattle;
        private int warpsLastSpaceBattle;
        private int activeSpaceBattleUA;
        private int timeLastMiniStation;
        private int warpsLastMiniStation;
        private string miniStationUA;
        private float[] anomalyPositionOverride;
        private UniverseCoordinates gameStartAddress1;
        private UniverseCoordinates gameStartAddress2;
        private bool[] galacticMapRequests;
        private float[] firstShipPosition;
        private int hazardTimeAlive;
        private bool revealBlackHoles;
        private object[] currentFreighterHomeSystemSeed;
        private ProceduralObject currentFreighter;
        private CatalogLayout freighterLayout;
        private Catalog freighterInventory;
        private Catalog freighterInventoryTech;
        private UniverseCoordinates freighterUniverseAddress;
        private float[] freighterMatrixAt;
        private float[] freighterMatrixUp;
        private float[] freighterMatrixPos;
        private ObservableCollection<BuildingObject> baseBuildingObjects;
        private TerrainData terrainEditData;
        private NPCWorker[] nPCWorkers;
        private ObservableCollection<PlayerBase> persistentPlayerBases;
        private PortalData[] teleportEndpoints;
        private CatalogLayout chest0Layout;
        private Catalog chest0Inventory;
        private CatalogLayout chest1Layout;
        private Catalog chest1Inventory;
        private CatalogLayout chest2Layout;
        private Catalog chest2Inventory;
        private CatalogLayout chest3Layout;
        private Catalog chest3Inventory;
        private CatalogLayout chest4Layout;
        private Catalog chest4Inventory;
        private CatalogLayout chest5Layout;
        private Catalog chest5Inventory;
        private CatalogLayout chest6Layout;
        private Catalog chest6Inventory;
        private CatalogLayout chest7Layout;
        private Catalog chest7Inventory;
        private CatalogLayout chest8Layout;
        private Catalog chest8Inventory;
        private CatalogLayout chest9Layout;
        private Catalog chest9Inventory;
        private CatalogLayout chestMagicLayout;
        private Catalog chestMagicInventory;
        private CatalogLayout chestMagic2Layout;
        private Catalog chestMagic2Inventory;
        private CatalogLayout cookingIngredientsLayout;
        private Catalog cookingIngredientsInventory;
        private ProceduralObject currentFreighterNPC;
        private Vehicle[] vehicleOwnership;
        private short primaryVehicle;
        private Vehicle[] shipOwnership;
        private short primaryShip;
        private bool multiShipEnabled;
        private string playerFreighterName;
        private float[] startGameShipPosition;
        private bool shipNeedsTerrainPositioning;
        private int tradingSupplyDataIndex;
        private TradeSupplyData[] tradingSupplyData;
        private object[] lastPortal;
        private Portal visitedPortal;
        private int knownPortalRunes;
        private bool onOtherSideOfPortal;
        private PortalData otherSideOfPortalReturnBase;
        private float[] portalMarkerPosition_Local;
        private float[] portalMarkerPosition_Offset;
        private WeaponDescription startingPrimaryWeapon;
        private WeaponDescription startingSecondaryWeapon;
        private OutfitPreset[] outfitPresets;
        private bool[] shipUsesLegacyColours;
        private Outfit[] outfits;
        private string jetpackEffect;
        private object[] fleetSeed;
        private ObservableCollection<Frigate> fleetFrigates;
        private object[] fleetExpeditions;
        private object[] expeditionSeedsSelectedToday;
        private long lastKnownDay;
        private long sunTimer;
        private long multiplayerLobbyID;
        private UniverseCoordinates multiplayerUA;
        private SpawnData multiplayerSpawn;
        private object[] repairTechBuffer;
        private long multiplayerPrivileges;
        private HotAction[] hotActions;
        private string lastUABeforePortalWarp;
        private int storyPortalSeed;
        private int shopNumber;
        private int shopTier;
        private bool hasAccessToNexus;
        private UniverseCoordinates nexusUniverseAddress;
        private float[] nexusMatrixAt;
        private float[] nexusMatrixUp;
        private float[] nexusMatrixPos;
        private PhotoSettings photoModeSettings;
        private int bannerIcon;
        private int bannerMainColour;
        private int bannerBackgroundColour;
        private string bannerTitleId;
        private long telemetryUploadVersion;
        private bool usesThirdPersonVehicleCam;
        private float vRCameraOffset;
        private SeasonData seasonalData;

        [DataMember(Name = "yhJ")]
        public UniverseCoordinates UniverseAddress
        {
            get => universeAddress;
            set
            {
                if ((ReferenceEquals(universeAddress, value) != true))
                {
                    universeAddress = value;
                    OnPropertyChanged("UniverseAddress");
                }
            }
        }

        [DataMember(Name = "ux@")]
        public UniverseCoordinates PreviousUniverseAddress
        {
            get => previousUniverseAddress;
            set
            {
                if ((ReferenceEquals(previousUniverseAddress, value) != true))
                {
                    previousUniverseAddress = value;
                    OnPropertyChanged("PreviousUniverseAddress");
                }
            }
        }

        [DataMember(Name = "QQp")]
        public int HomeRealityIteration
        {
            get => homeRealityIteration;
            set
            {
                if ((ReferenceEquals(homeRealityIteration, value) != true))
                {
                    homeRealityIteration = value;
                    OnPropertyChanged("HomeRealityIteration");
                }
            }
        }

        [DataMember(Name = ";l5")]
        public Catalog Inventory
        {
            get => inventory;
            set
            {
                if ((ReferenceEquals(inventory, value) != true))
                {
                    inventory = value;
                    OnPropertyChanged("Inventory");
                }
            }
        }

        [DataMember(Name = "PMT")]
        public Catalog InventoryTech
        {
            get => inventoryTech;
            set
            {
                if ((ReferenceEquals(inventoryTech, value) != true))
                {
                    inventoryTech = value;
                    OnPropertyChanged("InventoryTech");
                }
            }
        }

        [DataMember(Name = "gan")]
        public Catalog InventoryCargo
        {
            get => inventoryCargo;
            set
            {
                if ((ReferenceEquals(inventoryCargo, value) != true))
                {
                    inventoryCargo = value;
                    OnPropertyChanged("InventoryCargo");
                }
            }
        }

        [DataMember(Name = "6<E")]
        public Catalog InventoryShip
        {
            get => inventoryShip;
            set
            {
                if ((ReferenceEquals(inventoryShip, value) != true))
                {
                    inventoryShip = value;
                    OnPropertyChanged("InventoryShip");
                }
            }
        }

        [DataMember(Name = "Kgt")]
        public Catalog InventoryWeapon
        {
            get => inventoryWeapon;
            set
            {
                if ((ReferenceEquals(inventoryWeapon, value) != true))
                {
                    inventoryWeapon = value;
                    OnPropertyChanged("InventoryWeapon");
                }
            }
        }

        [DataMember(Name = "SuJ")]
        public ObservableCollection<MultiTool> MultiTools
        {
            get => multiTools;
            set
            {
                if ((ReferenceEquals(multiTools, value) != true))
                {
                    multiTools = value;
                    OnPropertyChanged("MultiTools");
                }
            }
        }

        [DataMember(Name = "j3E")]
        public short ActiveMultiTool
        {
            get => activeMultiTool;
            set
            {
                if ((ReferenceEquals(activeMultiTool, value) != true))
                {
                    activeMultiTool = value;
                    OnPropertyChanged("ActiveMultiTool");
                }
            }
        }

        [DataMember(Name = "4eu")]
        public Catalog InventoryGrave
        {
            get => inventoryGrave;
            set
            {
                if ((ReferenceEquals(inventoryGrave, value) != true))
                {
                    inventoryGrave = value;
                    OnPropertyChanged("InventoryGrave");
                }
            }
        }

        [DataMember(Name = "BGQ")]
        public bool SpawnGrave
        {
            get => spawnGrave;
            set
            {
                if ((ReferenceEquals(spawnGrave, value) != true))
                {
                    spawnGrave = value;
                    OnPropertyChanged("SpawnGrave");
                }
            }
        }

        [DataMember(Name = ";JQ")]
        public bool SpaceGrave
        {
            get => spaceGrave;
            set
            {
                if ((ReferenceEquals(spaceGrave, value) != true))
                {
                    spaceGrave = value;
                    OnPropertyChanged("SpaceGrave");
                }
            }
        }

        [DataMember(Name = "NFm")]
        public UniverseCoordinates GraveUniverseAddress
        {
            get => graveUniverseAddress;
            set
            {
                if ((ReferenceEquals(graveUniverseAddress, value) != true))
                {
                    graveUniverseAddress = value;
                    OnPropertyChanged("GraveUniverseAddress");
                }
            }
        }

        [DataMember(Name = "4ia")]
        public decimal[] GravePosition
        {
            get => gravePosition;
            set
            {
                if ((ReferenceEquals(gravePosition, value) != true))
                {
                    gravePosition = value;
                    OnPropertyChanged("GravePosition");
                }
            }
        }

        [DataMember(Name = "gIh")]
        public decimal[] GraveMatrixLookAt
        {
            get => graveMatrixLookAt;
            set
            {
                if ((ReferenceEquals(graveMatrixLookAt, value) != true))
                {
                    graveMatrixLookAt = value;
                    OnPropertyChanged("GraveMatrixLookAt");
                }
            }
        }

        [DataMember(Name = "YJU")]
        public decimal[] GraveMatrixUp
        {
            get => graveMatrixUp;
            set
            {
                if ((ReferenceEquals(graveMatrixUp, value) != true))
                {
                    graveMatrixUp = value;
                    OnPropertyChanged("GraveMatrixUp");
                }
            }
        }

        [DataMember(Name = "rj2")]
        public CatalogLayout ShipLayout
        {
            get => shipLayout;
            set
            {
                if ((ReferenceEquals(shipLayout, value) != true))
                {
                    shipLayout = value;
                    OnPropertyChanged("ShipLayout");
                }
            }
        }

        [DataMember(Name = "xbM")]
        public CatalogLayout WeaponLayout
        {
            get => weaponLayout;
            set
            {
                if ((ReferenceEquals(weaponLayout, value) != true))
                {
                    weaponLayout = value;
                    OnPropertyChanged("WeaponLayout");
                }
            }
        }

        [DataMember(Name = "oJJ")]
        public ProceduralObject CurrentShip
        {
            get => currentShip;
            set
            {
                if ((ReferenceEquals(currentShip, value) != true))
                {
                    currentShip = value;
                    OnPropertyChanged("CurrentShip");
                }
            }
        }

        [DataMember(Name = "e6e")]
        public Weapon CurrentWeapon
        {
            get => currentWeapon;
            set
            {
                if ((ReferenceEquals(currentWeapon, value) != true))
                {
                    currentWeapon = value;
                    OnPropertyChanged("CurrentWeapon");
                }
            }
        }

        [DataMember(Name = "4kj")]
        public ObservableCollection<string> KnownTech
        {
            get => knownTech;
            set
            {
                if ((ReferenceEquals(knownTech, value) != true))
                {
                    knownTech = value;
                    OnPropertyChanged("KnownTech");
                }
            }
        }

        [DataMember(Name = "eZ<")]
        public ObservableCollection<string> KnownProducts
        {
            get => knownProducts;
            set
            {
                if ((ReferenceEquals(knownProducts, value) != true))
                {
                    knownProducts = value;
                    OnPropertyChanged("KnownProducts");
                }
            }
        }

        [DataMember(Name = "24<")]
        public ObservableCollection<string> KnownSpecials
        {
            get => knownSpecials;
            set
            {
                if ((ReferenceEquals(knownSpecials, value) != true))
                {
                    knownSpecials = value;
                    OnPropertyChanged("KnownSpecials");
                }
            }
        }

        [DataMember(Name = "Ddk")]
        public ObservableCollection<string> KnownRefinerRecipes
        {
            get => knownRefinerRecipes;
            set
            {
                if ((ReferenceEquals(knownRefinerRecipes, value) != true))
                {
                    knownRefinerRecipes = value;
                    OnPropertyChanged("KnownRefinerRecipes");
                }
            }
        }

        [DataMember(Name = ":JX")]
        public ObservableCollection<string> KnownWords
        {
            get => knownWords;
            set
            {
                if ((ReferenceEquals(knownWords, value) != true))
                {
                    knownWords = value;
                    OnPropertyChanged("KnownWords");
                }
            }
        }

        [DataMember(Name = "MF2")]
        public WordGroup[] KnownWordGroups
        {
            get => knownWordGroups;
            set
            {
                if ((ReferenceEquals(knownWordGroups, value) != true))
                {
                    knownWordGroups = value;
                    OnPropertyChanged("KnownWordGroups");
                }
            }
        }

        [DataMember(Name = "dwb")]
        public Mission[] MissionProgress
        {
            get => missionProgress;
            set
            {
                if ((ReferenceEquals(missionProgress, value) != true))
                {
                    missionProgress = value;
                    OnPropertyChanged("MissionProgress");
                }
            }
        }

        [DataMember(Name = "?eS")]
        public int PostMissionIndex
        {
            get => postMissionIndex;
            set
            {
                if ((ReferenceEquals(postMissionIndex, value) != true))
                {
                    postMissionIndex = value;
                    OnPropertyChanged("PostMissionIndex");
                }
            }
        }

        [DataMember(Name = ";R7")]
        public string CurrentMissionID
        {
            get => currentMissionID;
            set
            {
                if ((ReferenceEquals(currentMissionID, value) != true))
                {
                    currentMissionID = value;
                    OnPropertyChanged("CurrentMissionID");
                }
            }
        }

        [DataMember(Name = "k?G")]
        public int CurrentMissionSeed
        {
            get => currentMissionSeed;
            set
            {
                if ((ReferenceEquals(currentMissionSeed, value) != true))
                {
                    currentMissionSeed = value;
                    OnPropertyChanged("CurrentMissionSeed");
                }
            }
        }

        [DataMember(Name = "Mg<")]
        public string PreviousMissionID
        {
            get => previousMissionID;
            set
            {
                if ((ReferenceEquals(previousMissionID, value) != true))
                {
                    previousMissionID = value;
                    OnPropertyChanged("PreviousMissionID");
                }
            }
        }

        [DataMember(Name = "rej")]
        public int PreviousMissionSeed
        {
            get => previousMissionSeed;
            set
            {
                if ((ReferenceEquals(previousMissionSeed, value) != true))
                {
                    previousMissionSeed = value;
                    OnPropertyChanged("PreviousMissionSeed");
                }
            }
        }

        [DataMember(Name = "yq:")]
        public int MissionVersion
        {
            get => missionVersion;
            set
            {
                if ((ReferenceEquals(missionVersion, value) != true))
                {
                    missionVersion = value;
                    OnPropertyChanged("MissionVersion");
                }
            }
        }

        [DataMember(Name = "EQt")]
        public MissionRecurrence[] MissionRecurrences
        {
            get => missionRecurrences;
            set
            {
                if ((ReferenceEquals(missionRecurrences, value) != true))
                {
                    missionRecurrences = value;
                    OnPropertyChanged("MissionRecurrences");
                }
            }
        }

        [DataMember(Name = "cmA")]
        public Interaction HoloExplorerInteraction
        {
            get => holoExplorerInteraction;
            set
            {
                if ((ReferenceEquals(holoExplorerInteraction, value) != true))
                {
                    holoExplorerInteraction = value;
                    OnPropertyChanged("HoloExplorerInteraction");
                }
            }
        }

        [DataMember(Name = "<>B")]
        public Interaction HoloScepticInteraction
        {
            get => holoScepticInteraction;
            set
            {
                if ((ReferenceEquals(holoScepticInteraction, value) != true))
                {
                    holoScepticInteraction = value;
                    OnPropertyChanged("HoloScepticInteraction");
                }
            }
        }

        [DataMember(Name = ":=:")]
        public Interaction HoloNooneInteraction
        {
            get => holoNooneInteraction;
            set
            {
                if ((ReferenceEquals(holoNooneInteraction, value) != true))
                {
                    holoNooneInteraction = value;
                    OnPropertyChanged("HoloNooneInteraction");
                }
            }
        }

        [DataMember(Name = "fSZ")]
        public int Health
        {
            get => health;
            set
            {
                if ((ReferenceEquals(health, value) != true))
                {
                    health = value;
                    OnPropertyChanged("Health");
                }
            }
        }

        [DataMember(Name = "KCM")]
        public int ShipHealth
        {
            get => shipHealth;
            set
            {
                if ((ReferenceEquals(shipHealth, value) != true))
                {
                    shipHealth = value;
                    OnPropertyChanged("ShipHealth");
                }
            }
        }

        [DataMember(Name = "kLc")]
        public int Shield
        {
            get => shield;
            set
            {
                if ((ReferenceEquals(shield, value) != true))
                {
                    shield = value;
                    OnPropertyChanged("Shield");
                }
            }
        }

        [DataMember(Name = "NE3")]
        public int ShipShield
        {
            get => shipShield;
            set
            {
                if ((ReferenceEquals(shipShield, value) != true))
                {
                    shipShield = value;
                    OnPropertyChanged("ShipShield");
                }
            }
        }

        [DataMember(Name = "dcK")]
        public int Energy
        {
            get => energy;
            set
            {
                if ((ReferenceEquals(energy, value) != true))
                {
                    energy = value;
                    OnPropertyChanged("Energy");
                }
            }
        }

        [DataMember(Name = "wGS")]
        public int Units
        {
            get => units;
            set
            {
                if ((ReferenceEquals(units, value) != true))
                {
                    units = value;
                    OnPropertyChanged("Units");
                }
            }
        }

        [DataMember(Name = "7QL")]
        public int Nanites
        {
            get => nanites;
            set
            {
                if ((ReferenceEquals(nanites, value) != true))
                {
                    nanites = value;
                    OnPropertyChanged("Nanites");
                }
            }
        }

        [DataMember(Name = "kN;")]
        public int Specials
        {
            get => specials;
            set
            {
                if ((ReferenceEquals(specials, value) != true))
                {
                    specials = value;
                    OnPropertyChanged("Specials");
                }
            }
        }

        [DataMember(Name = "cid")]
        public bool ThirdPersonShip
        {
            get => thirdPersonShip;
            set
            {
                if ((ReferenceEquals(thirdPersonShip, value) != true))
                {
                    thirdPersonShip = value;
                    OnPropertyChanged("ThirdPersonShip");
                }
            }
        }

        [DataMember(Name = "i8O")]
        public int TimeAlive
        {
            get => timeAlive;
            set
            {
                if ((ReferenceEquals(timeAlive, value) != true))
                {
                    timeAlive = value;
                    OnPropertyChanged("TimeAlive");
                }
            }
        }

        [DataMember(Name = "Lg8")]
        public int TotalPlayTime
        {
            get => totalPlayTime;
            set
            {
                if ((ReferenceEquals(totalPlayTime, value) != true))
                {
                    totalPlayTime = value;
                    OnPropertyChanged("TotalPlayTime");
                }
            }
        }

        [DataMember(Name = "A1f")]
        public Marker[] MarkerStack
        {
            get => markerStack;
            set
            {
                if ((ReferenceEquals(markerStack, value) != true))
                {
                    markerStack = value;
                    OnPropertyChanged("MarkerStack");
                }
            }
        }

        [DataMember(Name = "i;<")]
        public object[] NewMPMarkerStack
        {
            get => newMPMarkerStack;
            set
            {
                if ((ReferenceEquals(newMPMarkerStack, value) != true))
                {
                    newMPMarkerStack = value;
                    OnPropertyChanged("NewMPMarkerStack");
                }
            }
        }

        [DataMember(Name = "CYJ")]
        public object[] SurveyedEventPositions
        {
            get => surveyedEventPositions;
            set
            {
                if ((ReferenceEquals(surveyedEventPositions, value) != true))
                {
                    surveyedEventPositions = value;
                    OnPropertyChanged("SurveyedEventPositions");
                }
            }
        }

        [DataMember(Name = "6Ws")]
        public int NextSurveyedEventPositionIndex
        {
            get => nextSurveyedEventPositionIndex;
            set
            {
                if ((ReferenceEquals(nextSurveyedEventPositionIndex, value) != true))
                {
                    nextSurveyedEventPositionIndex = value;
                    OnPropertyChanged("NextSurveyedEventPositionIndex");
                }
            }
        }

        [DataMember(Name = "gUR")]
        public Stat[] Stats
        {
            get => stats;
            set
            {
                if ((ReferenceEquals(stats, value) != true))
                {
                    stats = value;
                    OnPropertyChanged("Stats");
                }
            }
        }

        [DataMember(Name = "m4I")]
        public Telemetry[] TelemetryStats
        {
            get => telemetryStats;
            set
            {
                if ((ReferenceEquals(telemetryStats, value) != true))
                {
                    telemetryStats = value;
                    OnPropertyChanged("TelemetryStats");
                }
            }
        }

        [DataMember(Name = "a6j")]
        public StoredInteraction[] StoredInteractions
        {
            get => storedInteractions;
            set
            {
                if ((ReferenceEquals(storedInteractions, value) != true))
                {
                    storedInteractions = value;
                    OnPropertyChanged("StoredInteractions");
                }
            }
        }

        [DataMember(Name = "RQA")]
        public InteractionData[] MaintenanceInteractions
        {
            get => maintenanceInteractions;
            set
            {
                if ((ReferenceEquals(maintenanceInteractions, value) != true))
                {
                    maintenanceInteractions = value;
                    OnPropertyChanged("MaintenanceInteractions");
                }
            }
        }

        [DataMember(Name = "VhC")]
        public InteractionData[] PersonalMaintenanceInteractions
        {
            get => personalMaintenanceInteractions;
            set
            {
                if ((ReferenceEquals(personalMaintenanceInteractions, value) != true))
                {
                    personalMaintenanceInteractions = value;
                    OnPropertyChanged("PersonalMaintenanceInteractions");
                }
            }
        }

        [DataMember(Name = "nwS")]
        public long[] VisitedSystems
        {
            get => visitedSystems;
            set
            {
                if ((ReferenceEquals(visitedSystems, value) != true))
                {
                    visitedSystems = value;
                    OnPropertyChanged("VisitedSystems");
                }
            }
        }

        [DataMember(Name = "seg")]
        public float[] Hazard
        {
            get => hazard;
            set
            {
                if ((ReferenceEquals(hazard, value) != true))
                {
                    hazard = value;
                    OnPropertyChanged("Hazard");
                }
            }
        }

        [DataMember(Name = "9Lm")]
        public int BoltAmmo
        {
            get => boltAmmo;
            set
            {
                if ((ReferenceEquals(boltAmmo, value) != true))
                {
                    boltAmmo = value;
                    OnPropertyChanged("BoltAmmo");
                }
            }
        }

        [DataMember(Name = "VPy")]
        public int ScatterAmmo
        {
            get => scatterAmmo;
            set
            {
                if ((ReferenceEquals(scatterAmmo, value) != true))
                {
                    scatterAmmo = value;
                    OnPropertyChanged("ScatterAmmo");
                }
            }
        }

        [DataMember(Name = ":ML")]
        public int PulseAmmo
        {
            get => pulseAmmo;
            set
            {
                if ((ReferenceEquals(pulseAmmo, value) != true))
                {
                    pulseAmmo = value;
                    OnPropertyChanged("PulseAmmo");
                }
            }
        }

        [DataMember(Name = "cO>")]
        public int LaserAmmo
        {
            get => laserAmmo;
            set
            {
                if ((ReferenceEquals(laserAmmo, value) != true))
                {
                    laserAmmo = value;
                    OnPropertyChanged("LaserAmmo");
                }
            }
        }

        [DataMember(Name = "vaP")]
        public float[] FirstSpawnPosition
        {
            get => firstSpawnPosition;
            set
            {
                if ((ReferenceEquals(firstSpawnPosition, value) != true))
                {
                    firstSpawnPosition = value;
                    OnPropertyChanged("FirstSpawnPosition");
                }
            }
        }

        [DataMember(Name = "E?v")]
        public InteractionIndicies[] SavedInteractionIndicies
        {
            get => savedInteractionIndicies;
            set
            {
                if ((ReferenceEquals(savedInteractionIndicies, value) != true))
                {
                    savedInteractionIndicies = value;
                    OnPropertyChanged("SavedInteractionIndicies");
                }
            }
        }

        [DataMember(Name = "Wu?")]
        public InteractionDialog[] SavedInteractionDialogTable
        {
            get => savedInteractionDialogTable;
            set
            {
                if ((ReferenceEquals(savedInteractionDialogTable, value) != true))
                {
                    savedInteractionDialogTable = value;
                    OnPropertyChanged("SavedInteractionDialogTable");
                }
            }
        }

        [DataMember(Name = "wHR")]
        public object[] InteractionProgressTable
        {
            get => interactionProgressTable;
            set
            {
                if ((ReferenceEquals(interactionProgressTable, value) != true))
                {
                    interactionProgressTable = value;
                    OnPropertyChanged("InteractionProgressTable");
                }
            }
        }

        [DataMember(Name = "vsV")]
        public UniverseCoordinates[] AtlasStationAdressData
        {
            get => atlasStationAdressData;
            set
            {
                if ((ReferenceEquals(atlasStationAdressData, value) != true))
                {
                    atlasStationAdressData = value;
                    OnPropertyChanged("AtlasStationAdressData");
                }
            }
        }

        [DataMember(Name = "B9>")]
        public UniverseCoordinates[] NewAtlasStationAdressData
        {
            get => newAtlasStationAdressData;
            set
            {
                if ((ReferenceEquals(newAtlasStationAdressData, value) != true))
                {
                    newAtlasStationAdressData = value;
                    OnPropertyChanged("NewAtlasStationAdressData");
                }
            }
        }

        [DataMember(Name = ":A3")]
        public UniverseCoordinates[] VisitedAtlasStationsData
        {
            get => visitedAtlasStationsData;
            set
            {
                if ((ReferenceEquals(visitedAtlasStationsData, value) != true))
                {
                    visitedAtlasStationsData = value;
                    OnPropertyChanged("VisitedAtlasStationsData");
                }
            }
        }

        [DataMember(Name = ":0x")]
        public bool FirstAtlasStationDiscovered
        {
            get => firstAtlasStationDiscovered;
            set
            {
                if ((ReferenceEquals(firstAtlasStationDiscovered, value) != true))
                {
                    firstAtlasStationDiscovered = value;
                    OnPropertyChanged("FirstAtlasStationDiscovered");
                }
            }
        }

        [DataMember(Name = "kPF")]
        public bool UsesThirdPersonCharacterCam
        {
            get => usesThirdPersonCharacterCam;
            set
            {
                if ((ReferenceEquals(usesThirdPersonCharacterCam, value) != true))
                {
                    usesThirdPersonCharacterCam = value;
                    OnPropertyChanged("UsesThirdPersonCharacterCam");
                }
            }
        }

        [DataMember(Name = "DtI")]
        public int ProgressionLevel
        {
            get => progressionLevel;
            set
            {
                if ((ReferenceEquals(progressionLevel, value) != true))
                {
                    progressionLevel = value;
                    OnPropertyChanged("ProgressionLevel");
                }
            }
        }

        [DataMember(Name = "QNH")]
        public int ProcTechIndex
        {
            get => procTechIndex;
            set
            {
                if ((ReferenceEquals(procTechIndex, value) != true))
                {
                    procTechIndex = value;
                    OnPropertyChanged("ProcTechIndex");
                }
            }
        }

        [DataMember(Name = "eV1")]
        public bool IsNew
        {
            get => isNew;
            set
            {
                if ((ReferenceEquals(isNew, value) != true))
                {
                    isNew = value;
                    OnPropertyChanged("IsNew");
                }
            }
        }

        [DataMember(Name = "wc3")]
        public bool UseSmallerBlackholeJumps
        {
            get => useSmallerBlackholeJumps;
            set
            {
                if ((ReferenceEquals(useSmallerBlackholeJumps, value) != true))
                {
                    useSmallerBlackholeJumps = value;
                    OnPropertyChanged("UseSmallerBlackholeJumps");
                }
            }
        }

        [DataMember(Name = "<dk")]
        public object[] UsedEntitlements
        {
            get => usedEntitlements;
            set
            {
                if ((ReferenceEquals(usedEntitlements, value) != true))
                {
                    usedEntitlements = value;
                    OnPropertyChanged("UsedEntitlements");
                }
            }
        }

        [DataMember(Name = "aHM")]
        public float[][] PlanetPositions
        {
            get => planetPositions;
            set
            {
                if ((ReferenceEquals(planetPositions, value) != true))
                {
                    planetPositions = value;
                    OnPropertyChanged("PlanetPositions");
                }
            }
        }

        [DataMember(Name = "?=a")]
        public object[][] PlanetSeeds
        {
            get => planetSeeds;
            set
            {
                if ((ReferenceEquals(planetSeeds, value) != true))
                {
                    planetSeeds = value;
                    OnPropertyChanged("PlanetSeeds");
                }
            }
        }

        [DataMember(Name = "7Mc")]
        public int PrimaryPlanet
        {
            get => primaryPlanet;
            set
            {
                if ((ReferenceEquals(primaryPlanet, value) != true))
                {
                    primaryPlanet = value;
                    OnPropertyChanged("PrimaryPlanet");
                }
            }
        }

        [DataMember(Name = "05J")]
        public int TimeLastSpaceBattle
        {
            get => timeLastSpaceBattle;
            set
            {
                if ((ReferenceEquals(timeLastSpaceBattle, value) != true))
                {
                    timeLastSpaceBattle = value;
                    OnPropertyChanged("TimeLastSpaceBattle");
                }
            }
        }

        [DataMember(Name = "8br")]
        public int WarpsLastSpaceBattle
        {
            get => warpsLastSpaceBattle;
            set
            {
                if ((ReferenceEquals(warpsLastSpaceBattle, value) != true))
                {
                    warpsLastSpaceBattle = value;
                    OnPropertyChanged("WarpsLastSpaceBattle");
                }
            }
        }

        [DataMember(Name = "8xx")]
        public int ActiveSpaceBattleUA
        {
            get => activeSpaceBattleUA;
            set
            {
                if ((ReferenceEquals(activeSpaceBattleUA, value) != true))
                {
                    activeSpaceBattleUA = value;
                    OnPropertyChanged("ActiveSpaceBattleUA");
                }
            }
        }

        [DataMember(Name = "IRi")]
        public int TimeLastMiniStation
        {
            get => timeLastMiniStation;
            set
            {
                if ((ReferenceEquals(timeLastMiniStation, value) != true))
                {
                    timeLastMiniStation = value;
                    OnPropertyChanged("TimeLastMiniStation");
                }
            }
        }

        [DataMember(Name = "x=M")]
        public int WarpsLastMiniStation
        {
            get => warpsLastMiniStation;
            set
            {
                if ((ReferenceEquals(warpsLastMiniStation, value) != true))
                {
                    warpsLastMiniStation = value;
                    OnPropertyChanged("WarpsLastMiniStation");
                }
            }
        }

        [DataMember(Name = "gpU")]
        public string MiniStationUA
        {
            get => miniStationUA;
            set
            {
                if ((ReferenceEquals(miniStationUA, value) != true))
                {
                    miniStationUA = value;
                    OnPropertyChanged("MiniStationUA");
                }
            }
        }

        [DataMember(Name = "JvI")]
        public float[] AnomalyPositionOverride
        {
            get => anomalyPositionOverride;
            set
            {
                if ((ReferenceEquals(anomalyPositionOverride, value) != true))
                {
                    anomalyPositionOverride = value;
                    OnPropertyChanged("AnomalyPositionOverride");
                }
            }
        }

        [DataMember(Name = "5ST")]
        public UniverseCoordinates GameStartAddress1
        {
            get => gameStartAddress1;
            set
            {
                if ((ReferenceEquals(gameStartAddress1, value) != true))
                {
                    gameStartAddress1 = value;
                    OnPropertyChanged("GameStartAddress1");
                }
            }
        }

        [DataMember(Name = "EeN")]
        public UniverseCoordinates GameStartAddress2
        {
            get => gameStartAddress2;
            set
            {
                if ((ReferenceEquals(gameStartAddress2, value) != true))
                {
                    gameStartAddress2 = value;
                    OnPropertyChanged("GameStartAddress2");
                }
            }
        }

        [DataMember(Name = "M2Z")]
        public bool[] GalacticMapRequests
        {
            get => galacticMapRequests;
            set
            {
                if ((ReferenceEquals(galacticMapRequests, value) != true))
                {
                    galacticMapRequests = value;
                    OnPropertyChanged("GalacticMapRequests");
                }
            }
        }

        [DataMember(Name = "nTB")]
        public float[] FirstShipPosition
        {
            get => firstShipPosition;
            set
            {
                if ((ReferenceEquals(firstShipPosition, value) != true))
                {
                    firstShipPosition = value;
                    OnPropertyChanged("FirstShipPosition");
                }
            }
        }

        [DataMember(Name = "G?:")]
        public int HazardTimeAlive
        {
            get => hazardTimeAlive;
            set
            {
                if ((ReferenceEquals(hazardTimeAlive, value) != true))
                {
                    hazardTimeAlive = value;
                    OnPropertyChanged("HazardTimeAlive");
                }
            }
        }

        [DataMember(Name = "tSD")]
        public bool RevealBlackHoles
        {
            get => revealBlackHoles;
            set
            {
                if ((ReferenceEquals(revealBlackHoles, value) != true))
                {
                    revealBlackHoles = value;
                    OnPropertyChanged("RevealBlackHoles");
                }
            }
        }

        [DataMember(Name = "kYq")]
        public object[] CurrentFreighterHomeSystemSeed
        {
            get => currentFreighterHomeSystemSeed;
            set
            {
                if ((ReferenceEquals(currentFreighterHomeSystemSeed, value) != true))
                {
                    currentFreighterHomeSystemSeed = value;
                    OnPropertyChanged("CurrentFreighterHomeSystemSeed");
                }
            }
        }

        [DataMember(Name = "bIR")]
        public ProceduralObject CurrentFreighter
        {
            get => currentFreighter;
            set
            {
                if ((ReferenceEquals(currentFreighter, value) != true))
                {
                    currentFreighter = value;
                    OnPropertyChanged("CurrentFreighter");
                }
            }
        }

        [DataMember(Name = ">Yh")]
        public CatalogLayout FreighterLayout
        {
            get => freighterLayout;
            set
            {
                if ((ReferenceEquals(freighterLayout, value) != true))
                {
                    freighterLayout = value;
                    OnPropertyChanged("FreighterLayout");
                }
            }
        }

        [DataMember(Name = "8ZP")]
        public Catalog FreighterInventory
        {
            get => freighterInventory;
            set
            {
                if ((ReferenceEquals(freighterInventory, value) != true))
                {
                    freighterInventory = value;
                    OnPropertyChanged("FreighterInventory");
                }
            }
        }

        [DataMember(Name = "0wS")]
        public Catalog FreighterInventoryTech
        {
            get => freighterInventoryTech;
            set
            {
                if ((ReferenceEquals(freighterInventoryTech, value) != true))
                {
                    freighterInventoryTech = value;
                    OnPropertyChanged("FreighterInventoryTech");
                }
            }
        }

        [DataMember(Name = "RB7")]
        public UniverseCoordinates FreighterUniverseAddress
        {
            get => freighterUniverseAddress;
            set
            {
                if ((ReferenceEquals(freighterUniverseAddress, value) != true))
                {
                    freighterUniverseAddress = value;
                    OnPropertyChanged("FreighterUniverseAddress");
                }
            }
        }

        [DataMember(Name = "9wg")]
        public float[] FreighterMatrixAt
        {
            get => freighterMatrixAt;
            set
            {
                if ((ReferenceEquals(freighterMatrixAt, value) != true))
                {
                    freighterMatrixAt = value;
                    OnPropertyChanged("FreighterMatrixAt");
                }
            }
        }

        [DataMember(Name = "fUl")]
        public float[] FreighterMatrixUp
        {
            get => freighterMatrixUp;
            set
            {
                if ((ReferenceEquals(freighterMatrixUp, value) != true))
                {
                    freighterMatrixUp = value;
                    OnPropertyChanged("FreighterMatrixUp");
                }
            }
        }

        [DataMember(Name = "lpm")]
        public float[] FreighterMatrixPos
        {
            get => freighterMatrixPos;
            set
            {
                if ((ReferenceEquals(freighterMatrixPos, value) != true))
                {
                    freighterMatrixPos = value;
                    OnPropertyChanged("FreighterMatrixPos");
                }
            }
        }

        [DataMember(Name = "c5s")]
        public ObservableCollection<BuildingObject> BaseBuildingObjects
        {
            get => baseBuildingObjects;
            set
            {
                if ((ReferenceEquals(baseBuildingObjects, value) != true))
                {
                    baseBuildingObjects = value;
                    OnPropertyChanged("BaseBuildingObjects");
                }
            }
        }

        [DataMember(Name = "=o:")]
        public TerrainData TerrainEditData
        {
            get => terrainEditData;
            set
            {
                if ((ReferenceEquals(terrainEditData, value) != true))
                {
                    terrainEditData = value;
                    OnPropertyChanged("TerrainEditData");
                }
            }
        }

        [DataMember(Name = "4Km")]
        public NPCWorker[] NPCWorkers
        {
            get => nPCWorkers;
            set
            {
                if ((ReferenceEquals(nPCWorkers, value) != true))
                {
                    nPCWorkers = value;
                    OnPropertyChanged("NPCWorkers");
                }
            }
        }

        [DataMember(Name = "F?0")]
        public ObservableCollection<PlayerBase> PersistentPlayerBases
        {
            get => persistentPlayerBases;
            set
            {
                if ((ReferenceEquals(persistentPlayerBases, value) != true))
                {
                    persistentPlayerBases = value;
                    OnPropertyChanged("PersistentPlayerBases");
                }
            }
        }

        [DataMember(Name = "nlG")]
        public PortalData[] TeleportEndpoints
        {
            get => teleportEndpoints;
            set
            {
                if ((ReferenceEquals(teleportEndpoints, value) != true))
                {
                    teleportEndpoints = value;
                    OnPropertyChanged("TeleportEndpoints");
                }
            }
        }

        [DataMember(Name = "=3B")]
        public CatalogLayout Chest0Layout
        {
            get => chest0Layout;
            set
            {
                if ((ReferenceEquals(chest0Layout, value) != true))
                {
                    chest0Layout = value;
                    OnPropertyChanged("Chest0Layout");
                }
            }
        }

        [DataMember(Name = "3Nc")]
        public Catalog Chest0Inventory
        {
            get => chest0Inventory;
            set
            {
                if ((ReferenceEquals(chest0Inventory, value) != true))
                {
                    chest0Inventory = value;
                    OnPropertyChanged("Chest0Inventory");
                }
            }
        }

        [DataMember(Name = "@ip")]
        public CatalogLayout Chest1Layout
        {
            get => chest1Layout;
            set
            {
                if ((ReferenceEquals(chest1Layout, value) != true))
                {
                    chest1Layout = value;
                    OnPropertyChanged("Chest1Layout");
                }
            }
        }

        [DataMember(Name = "IDc")]
        public Catalog Chest1Inventory
        {
            get => chest1Inventory;
            set
            {
                if ((ReferenceEquals(chest1Inventory, value) != true))
                {
                    chest1Inventory = value;
                    OnPropertyChanged("Chest1Inventory");
                }
            }
        }

        [DataMember(Name = "@Ik")]
        public CatalogLayout Chest2Layout
        {
            get => chest2Layout;
            set
            {
                if ((ReferenceEquals(chest2Layout, value) != true))
                {
                    chest2Layout = value;
                    OnPropertyChanged("Chest2Layout");
                }
            }
        }

        [DataMember(Name = "M=:")]
        public Catalog Chest2Inventory
        {
            get => chest2Inventory;
            set
            {
                if ((ReferenceEquals(chest2Inventory, value) != true))
                {
                    chest2Inventory = value;
                    OnPropertyChanged("Chest2Inventory");
                }
            }
        }

        [DataMember(Name = "@1E")]
        public CatalogLayout Chest3Layout
        {
            get => chest3Layout;
            set
            {
                if ((ReferenceEquals(chest3Layout, value) != true))
                {
                    chest3Layout = value;
                    OnPropertyChanged("Chest3Layout");
                }
            }
        }

        [DataMember(Name = "iYp")]
        public Catalog Chest3Inventory
        {
            get => chest3Inventory;
            set
            {
                if ((ReferenceEquals(chest3Inventory, value) != true))
                {
                    chest3Inventory = value;
                    OnPropertyChanged("Chest3Inventory");
                }
            }
        }

        [DataMember(Name = "XgV")]
        public CatalogLayout Chest4Layout
        {
            get => chest4Layout;
            set
            {
                if ((ReferenceEquals(chest4Layout, value) != true))
                {
                    chest4Layout = value;
                    OnPropertyChanged("Chest4Layout");
                }
            }
        }

        [DataMember(Name = "<IP")]
        public Catalog Chest4Inventory
        {
            get => chest4Inventory;
            set
            {
                if ((ReferenceEquals(chest4Inventory, value) != true))
                {
                    chest4Inventory = value;
                    OnPropertyChanged("Chest4Inventory");
                }
            }
        }

        [DataMember(Name = "nw5")]
        public CatalogLayout Chest5Layout
        {
            get => chest5Layout;
            set
            {
                if ((ReferenceEquals(chest5Layout, value) != true))
                {
                    chest5Layout = value;
                    OnPropertyChanged("Chest5Layout");
                }
            }
        }

        [DataMember(Name = "qYJ")]
        public Catalog Chest5Inventory
        {
            get => chest5Inventory;
            set
            {
                if ((ReferenceEquals(chest5Inventory, value) != true))
                {
                    chest5Inventory = value;
                    OnPropertyChanged("Chest5Inventory");
                }
            }
        }

        [DataMember(Name = "tLo")]
        public CatalogLayout Chest6Layout
        {
            get => chest6Layout;
            set
            {
                if ((ReferenceEquals(chest6Layout, value) != true))
                {
                    chest6Layout = value;
                    OnPropertyChanged("Chest6Layout");
                }
            }
        }

        [DataMember(Name = "@e5")]
        public Catalog Chest6Inventory
        {
            get => chest6Inventory;
            set
            {
                if ((ReferenceEquals(chest6Inventory, value) != true))
                {
                    chest6Inventory = value;
                    OnPropertyChanged("Chest6Inventory");
                }
            }
        }

        [DataMember(Name = "7b?")]
        public CatalogLayout Chest7Layout
        {
            get => chest7Layout;
            set
            {
                if ((ReferenceEquals(chest7Layout, value) != true))
                {
                    chest7Layout = value;
                    OnPropertyChanged("Chest7Layout");
                }
            }
        }

        [DataMember(Name = "5uh")]
        public Catalog Chest7Inventory
        {
            get => chest7Inventory;
            set
            {
                if ((ReferenceEquals(chest7Inventory, value) != true))
                {
                    chest7Inventory = value;
                    OnPropertyChanged("Chest7Inventory");
                }
            }
        }

        [DataMember(Name = "QBc")]
        public CatalogLayout Chest8Layout
        {
            get => chest8Layout;
            set
            {
                if ((ReferenceEquals(chest8Layout, value) != true))
                {
                    chest8Layout = value;
                    OnPropertyChanged("Chest8Layout");
                }
            }
        }

        [DataMember(Name = "5Tg")]
        public Catalog Chest8Inventory
        {
            get => chest8Inventory;
            set
            {
                if ((ReferenceEquals(chest8Inventory, value) != true))
                {
                    chest8Inventory = value;
                    OnPropertyChanged("Chest8Inventory");
                }
            }
        }

        [DataMember(Name = "wqf")]
        public CatalogLayout Chest9Layout
        {
            get => chest9Layout;
            set
            {
                if ((ReferenceEquals(chest9Layout, value) != true))
                {
                    chest9Layout = value;
                    OnPropertyChanged("Chest9Layout");
                }
            }
        }

        [DataMember(Name = "Bq<")]
        public Catalog Chest9Inventory
        {
            get => chest9Inventory;
            set
            {
                if ((ReferenceEquals(chest9Inventory, value) != true))
                {
                    chest9Inventory = value;
                    OnPropertyChanged("Chest9Inventory");
                }
            }
        }

        [DataMember(Name = "v8;")]
        public CatalogLayout ChestMagicLayout
        {
            get => chestMagicLayout;
            set
            {
                if ((ReferenceEquals(chestMagicLayout, value) != true))
                {
                    chestMagicLayout = value;
                    OnPropertyChanged("ChestMagicLayout");
                }
            }
        }

        [DataMember(Name = ";?C")]
        public Catalog ChestMagicInventory
        {
            get => chestMagicInventory;
            set
            {
                if ((ReferenceEquals(chestMagicInventory, value) != true))
                {
                    chestMagicInventory = value;
                    OnPropertyChanged("ChestMagicInventory");
                }
            }
        }

        [DataMember(Name = "wFm")]
        public CatalogLayout ChestMagic2Layout
        {
            get => chestMagic2Layout;
            set
            {
                if ((ReferenceEquals(chestMagic2Layout, value) != true))
                {
                    chestMagic2Layout = value;
                    OnPropertyChanged("ChestMagic2Layout");
                }
            }
        }

        [DataMember(Name = "fCh")]
        public Catalog ChestMagic2Inventory
        {
            get => chestMagic2Inventory;
            set
            {
                if ((ReferenceEquals(chestMagic2Inventory, value) != true))
                {
                    chestMagic2Inventory = value;
                    OnPropertyChanged("ChestMagic2Inventory");
                }
            }
        }

        [DataMember(Name = "RiP")]
        public CatalogLayout CookingIngredientsLayout
        {
            get => cookingIngredientsLayout;
            set
            {
                if ((ReferenceEquals(cookingIngredientsLayout, value) != true))
                {
                    cookingIngredientsLayout = value;
                    OnPropertyChanged("CookingIngredientsLayout");
                }
            }
        }

        [DataMember(Name = "Kha")]
        public Catalog CookingIngredientsInventory
        {
            get => cookingIngredientsInventory;
            set
            {
                if ((ReferenceEquals(cookingIngredientsInventory, value) != true))
                {
                    cookingIngredientsInventory = value;
                    OnPropertyChanged("CookingIngredientsInventory");
                }
            }
        }

        [DataMember(Name = "Sjw")]
        public ProceduralObject CurrentFreighterNPC
        {
            get => currentFreighterNPC;
            set
            {
                if ((ReferenceEquals(currentFreighterNPC, value) != true))
                {
                    currentFreighterNPC = value;
                    OnPropertyChanged("CurrentFreighterNPC");
                }
            }
        }

        [DataMember(Name = "P;m")]
        public Vehicle[] VehicleOwnership
        {
            get => vehicleOwnership;
            set
            {
                if ((ReferenceEquals(vehicleOwnership, value) != true))
                {
                    vehicleOwnership = value;
                    OnPropertyChanged("VehicleOwnership");
                }
            }
        }

        [DataMember(Name = "5sx")]
        public short PrimaryVehicle
        {
            get => primaryVehicle;
            set
            {
                if ((ReferenceEquals(primaryVehicle, value) != true))
                {
                    primaryVehicle = value;
                    OnPropertyChanged("PrimaryVehicle");
                }
            }
        }

        [DataMember(Name = "@Cs")]
        public Vehicle[] ShipOwnership
        {
            get => shipOwnership;
            set
            {
                if ((ReferenceEquals(shipOwnership, value) != true))
                {
                    shipOwnership = value;
                    OnPropertyChanged("ShipOwnership");
                }
            }
        }

        [DataMember(Name = "aBE")]
        public short PrimaryShip
        {
            get => primaryShip;
            set
            {
                if ((ReferenceEquals(primaryShip, value) != true))
                {
                    primaryShip = value;
                    OnPropertyChanged("PrimaryShip");
                }
            }
        }

        [DataMember(Name = "@Vn")]
        public bool MultiShipEnabled
        {
            get => multiShipEnabled;
            set
            {
                if ((ReferenceEquals(multiShipEnabled, value) != true))
                {
                    multiShipEnabled = value;
                    OnPropertyChanged("MultiShipEnabled");
                }
            }
        }

        [DataMember(Name = "vxi")]
        public string PlayerFreighterName
        {
            get => playerFreighterName;
            set
            {
                if ((ReferenceEquals(playerFreighterName, value) != true))
                {
                    playerFreighterName = value;
                    OnPropertyChanged("PlayerFreighterName");
                }
            }
        }

        [DataMember(Name = "h=c")]
        public float[] StartGameShipPosition
        {
            get => startGameShipPosition;
            set
            {
                if ((ReferenceEquals(startGameShipPosition, value) != true))
                {
                    startGameShipPosition = value;
                    OnPropertyChanged("StartGameShipPosition");
                }
            }
        }

        [DataMember(Name = "Bur")]
        public bool ShipNeedsTerrainPositioning
        {
            get => shipNeedsTerrainPositioning;
            set
            {
                if ((ReferenceEquals(shipNeedsTerrainPositioning, value) != true))
                {
                    shipNeedsTerrainPositioning = value;
                    OnPropertyChanged("ShipNeedsTerrainPositioning");
                }
            }
        }

        [DataMember(Name = "nkF")]
        public int TradingSupplyDataIndex
        {
            get => tradingSupplyDataIndex;
            set
            {
                if ((ReferenceEquals(tradingSupplyDataIndex, value) != true))
                {
                    tradingSupplyDataIndex = value;
                    OnPropertyChanged("TradingSupplyDataIndex");
                }
            }
        }

        [DataMember(Name = "b69")]
        public TradeSupplyData[] TradingSupplyData
        {
            get => tradingSupplyData;
            set
            {
                if ((ReferenceEquals(tradingSupplyData, value) != true))
                {
                    tradingSupplyData = value;
                    OnPropertyChanged("TradingSupplyData");
                }
            }
        }

        [DataMember(Name = "HbG")]
        public object[] LastPortal
        {
            get => lastPortal;
            set
            {
                if ((ReferenceEquals(lastPortal, value) != true))
                {
                    lastPortal = value;
                    OnPropertyChanged("LastPortal");
                }
            }
        }

        [DataMember(Name = "NQJ")]
        public Portal VisitedPortal
        {
            get => visitedPortal;
            set
            {
                if ((ReferenceEquals(visitedPortal, value) != true))
                {
                    visitedPortal = value;
                    OnPropertyChanged("VisitedPortal");
                }
            }
        }

        [DataMember(Name = "vrS")]
        public int KnownPortalRunes
        {
            get => knownPortalRunes;
            set
            {
                if ((ReferenceEquals(knownPortalRunes, value) != true))
                {
                    knownPortalRunes = value;
                    OnPropertyChanged("KnownPortalRunes");
                }
            }
        }

        [DataMember(Name = "DaC")]
        public bool OnOtherSideOfPortal
        {
            get => onOtherSideOfPortal;
            set
            {
                if ((ReferenceEquals(onOtherSideOfPortal, value) != true))
                {
                    onOtherSideOfPortal = value;
                    OnPropertyChanged("OnOtherSideOfPortal");
                }
            }
        }

        [DataMember(Name = "30s")]
        public PortalData OtherSideOfPortalReturnBase
        {
            get => otherSideOfPortalReturnBase;
            set
            {
                if ((ReferenceEquals(otherSideOfPortalReturnBase, value) != true))
                {
                    otherSideOfPortalReturnBase = value;
                    OnPropertyChanged("OtherSideOfPortalReturnBase");
                }
            }
        }

        [DataMember(Name = "LIR")]
        public float[] PortalMarkerPosition_Local
        {
            get => portalMarkerPosition_Local;
            set
            {
                if ((ReferenceEquals(portalMarkerPosition_Local, value) != true))
                {
                    portalMarkerPosition_Local = value;
                    OnPropertyChanged("PortalMarkerPosition_Local");
                }
            }
        }

        [DataMember(Name = "qW;")]
        public float[] PortalMarkerPosition_Offset
        {
            get => portalMarkerPosition_Offset;
            set
            {
                if ((ReferenceEquals(portalMarkerPosition_Offset, value) != true))
                {
                    portalMarkerPosition_Offset = value;
                    OnPropertyChanged("PortalMarkerPosition_Offset");
                }
            }
        }

        [DataMember(Name = ";DM")]
        public WeaponDescription StartingPrimaryWeapon
        {
            get => startingPrimaryWeapon;
            set
            {
                if ((ReferenceEquals(startingPrimaryWeapon, value) != true))
                {
                    startingPrimaryWeapon = value;
                    OnPropertyChanged("StartingPrimaryWeapon");
                }
            }
        }

        [DataMember(Name = "SYl")]
        public WeaponDescription StartingSecondaryWeapon
        {
            get => startingSecondaryWeapon;
            set
            {
                if ((ReferenceEquals(startingSecondaryWeapon, value) != true))
                {
                    startingSecondaryWeapon = value;
                    OnPropertyChanged("StartingSecondaryWeapon");
                }
            }
        }

        [DataMember(Name = "l:j")]
        public OutfitPreset[] OutfitPresets
        {
            get => outfitPresets;
            set
            {
                if ((ReferenceEquals(outfitPresets, value) != true))
                {
                    outfitPresets = value;
                    OnPropertyChanged("OutfitPresets");
                }
            }
        }

        [DataMember(Name = "4hl")]
        public bool[] ShipUsesLegacyColours
        {
            get => shipUsesLegacyColours;
            set
            {
                if ((ReferenceEquals(shipUsesLegacyColours, value) != true))
                {
                    shipUsesLegacyColours = value;
                    OnPropertyChanged("ShipUsesLegacyColours");
                }
            }
        }

        [DataMember(Name = "cf5")]
        public Outfit[] Outfits
        {
            get => outfits;
            set
            {
                if ((ReferenceEquals(outfits, value) != true))
                {
                    outfits = value;
                    OnPropertyChanged("Outfits");
                }
            }
        }

        [DataMember(Name = "5LX")]
        public string JetpackEffect
        {
            get => jetpackEffect;
            set
            {
                if ((ReferenceEquals(jetpackEffect, value) != true))
                {
                    jetpackEffect = value;
                    OnPropertyChanged("JetpackEffect");
                }
            }
        }

        [DataMember(Name = "3Z>")]
        public object[] FleetSeed
        {
            get => fleetSeed;
            set
            {
                if ((ReferenceEquals(fleetSeed, value) != true))
                {
                    fleetSeed = value;
                    OnPropertyChanged("FleetSeed");
                }
            }
        }

        [DataMember(Name = ";Du")]
        public ObservableCollection<Frigate> FleetFrigates
        {
            get => fleetFrigates;
            set
            {
                if ((ReferenceEquals(fleetFrigates, value) != true))
                {
                    fleetFrigates = value;
                    OnPropertyChanged("FleetFrigates");
                }
            }
        }

        [DataMember(Name = "kw:")]
        public object[] FleetExpeditions
        {
            get => fleetExpeditions;
            set
            {
                if ((ReferenceEquals(fleetExpeditions, value) != true))
                {
                    fleetExpeditions = value;
                    OnPropertyChanged("FleetExpeditions");
                }
            }
        }

        [DataMember(Name = "ieD")]
        public object[] ExpeditionSeedsSelectedToday
        {
            get => expeditionSeedsSelectedToday;
            set
            {
                if ((ReferenceEquals(expeditionSeedsSelectedToday, value) != true))
                {
                    expeditionSeedsSelectedToday = value;
                    OnPropertyChanged("ExpeditionSeedsSelectedToday");
                }
            }
        }

        [DataMember(Name = "nxr")]
        public long LastKnownDay
        {
            get => lastKnownDay;
            set
            {
                if ((ReferenceEquals(lastKnownDay, value) != true))
                {
                    lastKnownDay = value;
                    OnPropertyChanged("LastKnownDay");
                }
            }
        }

        [DataMember(Name = ">db")]
        public long SunTimer
        {
            get => sunTimer;
            set
            {
                if ((ReferenceEquals(sunTimer, value) != true))
                {
                    sunTimer = value;
                    OnPropertyChanged("SunTimer");
                }
            }
        }

        [DataMember(Name = "vXX")]
        public long MultiplayerLobbyID
        {
            get => multiplayerLobbyID;
            set
            {
                if ((ReferenceEquals(multiplayerLobbyID, value) != true))
                {
                    multiplayerLobbyID = value;
                    OnPropertyChanged("MultiplayerLobbyID");
                }
            }
        }

        [DataMember(Name = "YxD")]
        public UniverseCoordinates MultiplayerUA
        {
            get => multiplayerUA;
            set
            {
                if ((ReferenceEquals(multiplayerUA, value) != true))
                {
                    multiplayerUA = value;
                    OnPropertyChanged("MultiplayerUA");
                }
            }
        }

        [DataMember(Name = "x<b")]
        public SpawnData MultiplayerSpawn
        {
            get => multiplayerSpawn;
            set
            {
                if ((ReferenceEquals(multiplayerSpawn, value) != true))
                {
                    multiplayerSpawn = value;
                    OnPropertyChanged("MultiplayerSpawn");
                }
            }
        }

        [DataMember(Name = "wyZ")]
        public object[] RepairTechBuffer
        {
            get => repairTechBuffer;
            set
            {
                if ((ReferenceEquals(repairTechBuffer, value) != true))
                {
                    repairTechBuffer = value;
                    OnPropertyChanged("RepairTechBuffer");
                }
            }
        }

        [DataMember(Name = "kpg")]
        public long MultiplayerPrivileges
        {
            get => multiplayerPrivileges;
            set
            {
                if ((ReferenceEquals(multiplayerPrivileges, value) != true))
                {
                    multiplayerPrivileges = value;
                    OnPropertyChanged("MultiplayerPrivileges");
                }
            }
        }

        [DataMember(Name = "k8N")]
        public HotAction[] HotActions
        {
            get => hotActions;
            set
            {
                if ((ReferenceEquals(hotActions, value) != true))
                {
                    hotActions = value;
                    OnPropertyChanged("HotActions");
                }
            }
        }

        [DataMember(Name = "8GF")]
        public string LastUABeforePortalWarp
        {
            get => lastUABeforePortalWarp;
            set
            {
                if ((ReferenceEquals(lastUABeforePortalWarp, value) != true))
                {
                    lastUABeforePortalWarp = value;
                    OnPropertyChanged("LastUABeforePortalWarp");
                }
            }
        }

        [DataMember(Name = "7Un")]
        public int StoryPortalSeed
        {
            get => storyPortalSeed;
            set
            {
                if ((ReferenceEquals(storyPortalSeed, value) != true))
                {
                    storyPortalSeed = value;
                    OnPropertyChanged("StoryPortalSeed");
                }
            }
        }

        [DataMember(Name = "aPn")]
        public int ShopNumber
        {
            get => shopNumber;
            set
            {
                if ((ReferenceEquals(shopNumber, value) != true))
                {
                    shopNumber = value;
                    OnPropertyChanged("ShopNumber");
                }
            }
        }

        [DataMember(Name = "rk3")]
        public int ShopTier
        {
            get => shopTier;
            set
            {
                if ((ReferenceEquals(shopTier, value) != true))
                {
                    shopTier = value;
                    OnPropertyChanged("ShopTier");
                }
            }
        }

        [DataMember(Name = "Ue9")]
        public bool HasAccessToNexus
        {
            get => hasAccessToNexus;
            set
            {
                if ((ReferenceEquals(hasAccessToNexus, value) != true))
                {
                    hasAccessToNexus = value;
                    OnPropertyChanged("HasAccessToNexus");
                }
            }
        }

        [DataMember(Name = "hiE")]
        public UniverseCoordinates NexusUniverseAddress
        {
            get => nexusUniverseAddress;
            set
            {
                if ((ReferenceEquals(nexusUniverseAddress, value) != true))
                {
                    nexusUniverseAddress = value;
                    OnPropertyChanged("NexusUniverseAddress");
                }
            }
        }

        [DataMember(Name = "Fk@")]
        public float[] NexusMatrixAt
        {
            get => nexusMatrixAt;
            set
            {
                if ((ReferenceEquals(nexusMatrixAt, value) != true))
                {
                    nexusMatrixAt = value;
                    OnPropertyChanged("NexusMatrixAt");
                }
            }
        }

        [DataMember(Name = "d72")]
        public float[] NexusMatrixUp
        {
            get => nexusMatrixUp;
            set
            {
                if ((ReferenceEquals(nexusMatrixUp, value) != true))
                {
                    nexusMatrixUp = value;
                    OnPropertyChanged("NexusMatrixUp");
                }
            }
        }

        [DataMember(Name = "Yel")]
        public float[] NexusMatrixPos
        {
            get => nexusMatrixPos;
            set
            {
                if ((ReferenceEquals(nexusMatrixPos, value) != true))
                {
                    nexusMatrixPos = value;
                    OnPropertyChanged("NexusMatrixPos");
                }
            }
        }

        [DataMember(Name = "j3Y")]
        public PhotoSettings PhotoModeSettings
        {
            get => photoModeSettings;
            set
            {
                if ((ReferenceEquals(photoModeSettings, value) != true))
                {
                    photoModeSettings = value;
                    OnPropertyChanged("PhotoModeSettings");
                }
            }
        }

        [DataMember(Name = "9hR")]
        public int BannerIcon
        {
            get => bannerIcon;
            set
            {
                if ((ReferenceEquals(bannerIcon, value) != true))
                {
                    bannerIcon = value;
                    OnPropertyChanged("BannerIcon");
                }
            }
        }

        [DataMember(Name = "8DG")]
        public int BannerMainColour
        {
            get => bannerMainColour;
            set
            {
                if ((ReferenceEquals(bannerMainColour, value) != true))
                {
                    bannerMainColour = value;
                    OnPropertyChanged("BannerMainColour");
                }
            }
        }

        [DataMember(Name = "lmE")]
        public int BannerBackgroundColour
        {
            get => bannerBackgroundColour;
            set
            {
                if ((ReferenceEquals(bannerBackgroundColour, value) != true))
                {
                    bannerBackgroundColour = value;
                    OnPropertyChanged("BannerBackgroundColour");
                }
            }
        }

        [DataMember(Name = "aNF")]
        public string BannerTitleId
        {
            get => bannerTitleId;
            set
            {
                if ((ReferenceEquals(bannerTitleId, value) != true))
                {
                    bannerTitleId = value;
                    OnPropertyChanged("BannerTitleId");
                }
            }
        }

        [DataMember(Name = "qFl")]
        public long TelemetryUploadVersion
        {
            get => telemetryUploadVersion;
            set
            {
                if ((ReferenceEquals(telemetryUploadVersion, value) != true))
                {
                    telemetryUploadVersion = value;
                    OnPropertyChanged("TelemetryUploadVersion");
                }
            }
        }

        [DataMember(Name = "wb:")]
        public bool UsesThirdPersonVehicleCam
        {
            get => usesThirdPersonVehicleCam;
            set
            {
                if ((ReferenceEquals(usesThirdPersonVehicleCam, value) != true))
                {
                    usesThirdPersonVehicleCam = value;
                    OnPropertyChanged("UsesThirdPersonVehicleCam");
                }
            }
        }

        [DataMember(Name = "T>Z")]
        public float VRCameraOffset
        {
            get => vRCameraOffset;
            set
            {
                if ((ReferenceEquals(vRCameraOffset, value) != true))
                {
                    vRCameraOffset = value;
                    OnPropertyChanged("VRCameraOffset");
                }
            }
        }

        [DataMember(Name = "TFZ")]
        public SeasonData SeasonalData
        {
            get => seasonalData;
            set
            {
                if ((ReferenceEquals(seasonalData, value) != true))
                {
                    seasonalData = value;
                    OnPropertyChanged("SeasonalData");
                }
            }
        }
    }
}