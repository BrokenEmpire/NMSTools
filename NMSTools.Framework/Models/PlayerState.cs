using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace NMSTools.Framework.Models
{
    using Framework.Base;
    using Framework.Primitives;

    [JsonObject]
    public class PlayerState : ModelBase
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
        private int activeMultiTool;
        private Catalog inventoryGrave;
        private bool spawnGrave;
        private bool spaceGrave;
        private UniverseCoordinates graveUniverseAddress;
        private Vector4 gravePosition;
        private Vector4 graveMatrixLookAt;
        private Vector4 graveMatrixUp;
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
        private ulong timeAlive;
        private ulong totalPlayTime;
        private Marker[] markerStack;
        private object[] newMPMarkerStack; //todo: create strong typed object 
        private Vector4[] surveyedEventPositions;
        private int nextSurveyedEventPositionIndex;
        private Stat[] stats;
        private Telemetry[] telemetryStats;
        private StoredInteraction[] storedInteractions;
        private InteractionData[] maintenanceInteractions;
        private InteractionData[] personalMaintenanceInteractions;
        private long[] visitedSystems;
        private double[] hazard;
        private int boltAmmo;
        private int scatterAmmo;
        private int pulseAmmo;
        private int laserAmmo;
        private Vector4 firstSpawnPosition;
        private InteractionIndicies[] savedInteractionIndicies;
        private InteractionDialog[] savedInteractionDialogTable;
        private string[] interactionProgressTable;
        private UniverseCoordinates[] atlasStationAdressData;
        private UniverseCoordinates[] newAtlasStationAdressData;
        private UniverseCoordinates[] visitedAtlasStationsData;
        private bool firstAtlasStationDiscovered;
        private bool usesThirdPersonCharacterCam;
        private int progressionLevel;
        private int procTechIndex;
        private bool isNew;
        private bool useSmallerBlackholeJumps;
        private object[] usedEntitlements;  //todo: create strong typed object
        private Vector3[] planetPositions;
        private object[][] planetSeeds; //todo: create strong typed object
        private int primaryPlanet;
        private ulong timeLastSpaceBattle;
        private int warpsLastSpaceBattle;
        private int activeSpaceBattleUA;
        private ulong timeLastMiniStation;
        private int warpsLastMiniStation;
        private string miniStationUA;
        private Vector4 anomalyPositionOverride;
        private UniverseCoordinates gameStartAddress1;
        private UniverseCoordinates gameStartAddress2;
        private bool[] galacticMapRequests;
        private Vector4 firstShipPosition;
        private ulong hazardTimeAlive;
        private bool revealBlackHoles;
        private object[] currentFreighterHomeSystemSeed; //todo: create strong typed object
        private ProceduralObject currentFreighter;
        private CatalogLayout freighterLayout;
        private Catalog freighterInventory;
        private Catalog freighterInventoryTech;
        private UniverseCoordinates freighterUniverseAddress;
        private Vector3 freighterMatrixAt;
        private Vector3 freighterMatrixUp;
        private Vector3 freighterMatrixPos;
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
        private int primaryVehicle;
        private Vehicle[] shipOwnership;
        private int primaryShip;
        private bool multiShipEnabled;
        private string playerFreighterName;
        private Vector4 startGameShipPosition;
        private bool shipNeedsTerrainPositioning;
        private int tradingSupplyDataIndex;
        private TradeSupplyData[] tradingSupplyData;
        private object[] lastPortal;  //todo: strong type object
        private Portal visitedPortal;
        private int knownPortalRunes;
        private bool onOtherSideOfPortal;
        private PortalData otherSideOfPortalReturnBase;
        private Vector4 portalMarkerPosition_Local;
        private Vector4 portalMarkerPosition_Offset;
        private WeaponDescription startingPrimaryWeapon;
        private WeaponDescription startingSecondaryWeapon;
        private OutfitPreset[] outfitPresets;
        private bool[] shipUsesLegacyColours;
        private Outfit[] outfits;
        private string jetpackEffect;
        private object[] fleetSeed; //todo: strong type object
        private ObservableCollection<Frigate> fleetFrigates;
        private object[] fleetExpeditions;  //todo: strong type object
        private object[] expeditionSeedsSelectedToday;  //todo: strong type object
        private ulong lastKnownDay;
        private ulong sunTimer;
        private long multiplayerLobbyID;
        private UniverseCoordinates multiplayerUA;
        private SpawnData multiplayerSpawn;
        private object[] repairTechBuffer;  //todo: strong type object
        private ulong multiplayerPrivileges;
        private HotAction[] hotActions;
        private object lastUABeforePortalWarp;   //todo: strong type object
        private int storyPortalSeed;
        private ushort shopNumber;
        private ushort shopTier;
        private bool hasAccessToNexus;
        private UniverseCoordinates nexusUniverseAddress;
        private Vector3 nexusMatrixAt;
        private Vector3 nexusMatrixUp;
        private Vector3 nexusMatrixPos;
        private PhotoSettings photoModeSettings;
        private int bannerIcon;
        private int bannerMainColour;
        private int bannerBackgroundColour;
        private string bannerTitleId;
        private int telemetryUploadVersion;
        private bool usesThirdPersonVehicleCam;
        private double vRCameraOffset;
        private SeasonData seasonalData;

        [JsonProperty("yhJ")]
        public UniverseCoordinates UniverseAddress
        {
            get => universeAddress;
            set
            {
                if (ReferenceEquals(universeAddress, value) != true)
                {
                    universeAddress = value;
                    OnPropertyChanged("UniverseAddress");
                }
            }
        }

        [JsonProperty("ux@")]
        public UniverseCoordinates PreviousUniverseAddress
        {
            get => previousUniverseAddress;
            set
            {
                if (ReferenceEquals(previousUniverseAddress, value) != true)
                {
                    previousUniverseAddress = value;
                    OnPropertyChanged("PreviousUniverseAddress");
                }
            }
        }

        [JsonProperty("QQp")]
        public int HomeRealityIteration
        {
            get => homeRealityIteration;
            set
            {
                if (ReferenceEquals(homeRealityIteration, value) != true)
                {
                    homeRealityIteration = value;
                    OnPropertyChanged("HomeRealityIteration");
                }
            }
        }

        [JsonProperty(";l5")]
        public Catalog Inventory
        {
            get => inventory;
            set
            {
                if (ReferenceEquals(inventory, value) != true)
                {
                    inventory = value;
                    OnPropertyChanged("Inventory");
                }
            }
        }

        [JsonProperty("PMT")]
        public Catalog InventoryTech
        {
            get => inventoryTech;
            set
            {
                if (ReferenceEquals(inventoryTech, value) != true)
                {
                    inventoryTech = value;
                    OnPropertyChanged("InventoryTech");
                }
            }
        }

        [JsonProperty("gan")]
        public Catalog InventoryCargo
        {
            get => inventoryCargo;
            set
            {
                if (ReferenceEquals(inventoryCargo, value) != true)
                {
                    inventoryCargo = value;
                    OnPropertyChanged("InventoryCargo");
                }
            }
        }

        [JsonProperty("6<E")]
        public Catalog InventoryShip
        {
            get => inventoryShip;
            set
            {
                if (ReferenceEquals(inventoryShip, value) != true)
                {
                    inventoryShip = value;
                    OnPropertyChanged("InventoryShip");
                }
            }
        }

        [JsonProperty("Kgt")]
        public Catalog InventoryWeapon
        {
            get => inventoryWeapon;
            set
            {
                if (ReferenceEquals(inventoryWeapon, value) != true)
                {
                    inventoryWeapon = value;
                    OnPropertyChanged("InventoryWeapon");
                }
            }
        }

        [JsonProperty("SuJ")]
        public ObservableCollection<MultiTool> MultiTools
        {
            get => multiTools;
            set
            {
                if (ReferenceEquals(multiTools, value) != true)
                {
                    multiTools = value;
                    OnPropertyChanged("MultiTools");
                }
            }
        }

        [JsonProperty("j3E")]
        public int ActiveMultiTool
        {
            get => activeMultiTool;
            set
            {
                if (ReferenceEquals(activeMultiTool, value) != true)
                {
                    activeMultiTool = value;
                    OnPropertyChanged("ActiveMultiTool");
                }
            }
        }

        [JsonProperty("4eu")]
        public Catalog InventoryGrave
        {
            get => inventoryGrave;
            set
            {
                if (ReferenceEquals(inventoryGrave, value) != true)
                {
                    inventoryGrave = value;
                    OnPropertyChanged("InventoryGrave");
                }
            }
        }

        [JsonProperty("BGQ")]
        public bool SpawnGrave
        {
            get => spawnGrave;
            set
            {
                if (ReferenceEquals(spawnGrave, value) != true)
                {
                    spawnGrave = value;
                    OnPropertyChanged("SpawnGrave");
                }
            }
        }

        [JsonProperty(";JQ")]
        public bool SpaceGrave
        {
            get => spaceGrave;
            set
            {
                if (ReferenceEquals(spaceGrave, value) != true)
                {
                    spaceGrave = value;
                    OnPropertyChanged("SpaceGrave");
                }
            }
        }

        [JsonProperty("NFm")]
        public UniverseCoordinates GraveUniverseAddress
        {
            get => graveUniverseAddress;
            set
            {
                if (ReferenceEquals(graveUniverseAddress, value) != true)
                {
                    graveUniverseAddress = value;
                    OnPropertyChanged("GraveUniverseAddress");
                }
            }
        }

        [JsonProperty("4ia")]
        public Vector4 GravePosition
        {
            get => gravePosition;
            set
            {
                if (ReferenceEquals(gravePosition, value) != true)
                {
                    gravePosition = value;
                    OnPropertyChanged("GravePosition");
                }
            }
        }

        [JsonProperty("gIh")]
        public Vector4 GraveMatrixLookAt
        {
            get => graveMatrixLookAt;
            set
            {
                if (ReferenceEquals(graveMatrixLookAt, value) != true)
                {
                    graveMatrixLookAt = value;
                    OnPropertyChanged("GraveMatrixLookAt");
                }
            }
        }

        [JsonProperty("YJU")]
        public Vector4 GraveMatrixUp
        {
            get => graveMatrixUp;
            set
            {
                if (ReferenceEquals(graveMatrixUp, value) != true)
                {
                    graveMatrixUp = value;
                    OnPropertyChanged("GraveMatrixUp");
                }
            }
        }

        [JsonProperty("rj2")]
        public CatalogLayout ShipLayout
        {
            get => shipLayout;
            set
            {
                if (ReferenceEquals(shipLayout, value) != true)
                {
                    shipLayout = value;
                    OnPropertyChanged("ShipLayout");
                }
            }
        }

        [JsonProperty("xbM")]
        public CatalogLayout WeaponLayout
        {
            get => weaponLayout;
            set
            {
                if (ReferenceEquals(weaponLayout, value) != true)
                {
                    weaponLayout = value;
                    OnPropertyChanged("WeaponLayout");
                }
            }
        }

        [JsonProperty("oJJ")]
        public ProceduralObject CurrentShip
        {
            get => currentShip;
            set
            {
                if (ReferenceEquals(currentShip, value) != true)
                {
                    currentShip = value;
                    OnPropertyChanged("CurrentShip");
                }
            }
        }

        [JsonProperty("e6e")]
        public Weapon CurrentWeapon
        {
            get => currentWeapon;
            set
            {
                if (ReferenceEquals(currentWeapon, value) != true)
                {
                    currentWeapon = value;
                    OnPropertyChanged("CurrentWeapon");
                }
            }
        }

        [JsonProperty("4kj")]
        public ObservableCollection<string> KnownTech
        {
            get => knownTech;
            set
            {
                if (ReferenceEquals(knownTech, value) != true)
                {
                    knownTech = value;
                    OnPropertyChanged("KnownTech");
                }
            }
        }

        [JsonProperty("eZ<")]
        public ObservableCollection<string> KnownProducts
        {
            get => knownProducts;
            set
            {
                if (ReferenceEquals(knownProducts, value) != true)
                {
                    knownProducts = value;
                    OnPropertyChanged("KnownProducts");
                }
            }
        }

        [JsonProperty("24<")]
        public ObservableCollection<string> KnownSpecials
        {
            get => knownSpecials;
            set
            {
                if (ReferenceEquals(knownSpecials, value) != true)
                {
                    knownSpecials = value;
                    OnPropertyChanged("KnownSpecials");
                }
            }
        }

        [JsonProperty("Ddk")]
        public ObservableCollection<string> KnownRefinerRecipes
        {
            get => knownRefinerRecipes;
            set
            {
                if (ReferenceEquals(knownRefinerRecipes, value) != true)
                {
                    knownRefinerRecipes = value;
                    OnPropertyChanged("KnownRefinerRecipes");
                }
            }
        }

        [JsonProperty(":JX")]
        public ObservableCollection<string> KnownWords
        {
            get => knownWords;
            set
            {
                if (ReferenceEquals(knownWords, value) != true)
                {
                    knownWords = value;
                    OnPropertyChanged("KnownWords");
                }
            }
        }

        [JsonProperty("MF2")]
        public WordGroup[] KnownWordGroups
        {
            get => knownWordGroups;
            set
            {
                if (ReferenceEquals(knownWordGroups, value) != true)
                {
                    knownWordGroups = value;
                    OnPropertyChanged("KnownWordGroups");
                }
            }
        }

        [JsonProperty("dwb")]
        public Mission[] MissionProgress
        {
            get => missionProgress;
            set
            {
                if (ReferenceEquals(missionProgress, value) != true)
                {
                    missionProgress = value;
                    OnPropertyChanged("MissionProgress");
                }
            }
        }

        [JsonProperty("?eS")]
        public int PostMissionIndex
        {
            get => postMissionIndex;
            set
            {
                if (ReferenceEquals(postMissionIndex, value) != true)
                {
                    postMissionIndex = value;
                    OnPropertyChanged("PostMissionIndex");
                }
            }
        }

        [JsonProperty(";R7")]
        public string CurrentMissionID
        {
            get => currentMissionID;
            set
            {
                if (ReferenceEquals(currentMissionID, value) != true)
                {
                    currentMissionID = value;
                    OnPropertyChanged("CurrentMissionID");
                }
            }
        }

        [JsonProperty("k?G")]
        public int CurrentMissionSeed
        {
            get => currentMissionSeed;
            set
            {
                if (ReferenceEquals(currentMissionSeed, value) != true)
                {
                    currentMissionSeed = value;
                    OnPropertyChanged("CurrentMissionSeed");
                }
            }
        }

        [JsonProperty("Mg<")]
        public string PreviousMissionID
        {
            get => previousMissionID;
            set
            {
                if (ReferenceEquals(previousMissionID, value) != true)
                {
                    previousMissionID = value;
                    OnPropertyChanged("PreviousMissionID");
                }
            }
        }

        [JsonProperty("rej")]
        public int PreviousMissionSeed
        {
            get => previousMissionSeed;
            set
            {
                if (ReferenceEquals(previousMissionSeed, value) != true)
                {
                    previousMissionSeed = value;
                    OnPropertyChanged("PreviousMissionSeed");
                }
            }
        }

        [JsonProperty("yq:")]
        public int MissionVersion
        {
            get => missionVersion;
            set
            {
                if (ReferenceEquals(missionVersion, value) != true)
                {
                    missionVersion = value;
                    OnPropertyChanged("MissionVersion");
                }
            }
        }

        [JsonProperty("EQt")]
        public MissionRecurrence[] MissionRecurrences
        {
            get => missionRecurrences;
            set
            {
                if (ReferenceEquals(missionRecurrences, value) != true)
                {
                    missionRecurrences = value;
                    OnPropertyChanged("MissionRecurrences");
                }
            }
        }

        [JsonProperty("cmA")]
        public Interaction HoloExplorerInteraction
        {
            get => holoExplorerInteraction;
            set
            {
                if (ReferenceEquals(holoExplorerInteraction, value) != true)
                {
                    holoExplorerInteraction = value;
                    OnPropertyChanged("HoloExplorerInteraction");
                }
            }
        }

        [JsonProperty("<>B")]
        public Interaction HoloScepticInteraction
        {
            get => holoScepticInteraction;
            set
            {
                if (ReferenceEquals(holoScepticInteraction, value) != true)
                {
                    holoScepticInteraction = value;
                    OnPropertyChanged("HoloScepticInteraction");
                }
            }
        }

        [JsonProperty(":=:")]
        public Interaction HoloNooneInteraction
        {
            get => holoNooneInteraction;
            set
            {
                if (ReferenceEquals(holoNooneInteraction, value) != true)
                {
                    holoNooneInteraction = value;
                    OnPropertyChanged("HoloNooneInteraction");
                }
            }
        }

        [JsonProperty("fSZ")]
        public int Health
        {
            get => health;
            set
            {
                if (ReferenceEquals(health, value) != true)
                {
                    health = value;
                    OnPropertyChanged("Health");
                }
            }
        }

        [JsonProperty("KCM")]
        public int ShipHealth
        {
            get => shipHealth;
            set
            {
                if (ReferenceEquals(shipHealth, value) != true)
                {
                    shipHealth = value;
                    OnPropertyChanged("ShipHealth");
                }
            }
        }

        [JsonProperty("kLc")]
        public int Shield
        {
            get => shield;
            set
            {
                if (ReferenceEquals(shield, value) != true)
                {
                    shield = value;
                    OnPropertyChanged("Shield");
                }
            }
        }

        [JsonProperty("NE3")]
        public int ShipShield
        {
            get => shipShield;
            set
            {
                if (ReferenceEquals(shipShield, value) != true)
                {
                    shipShield = value;
                    OnPropertyChanged("ShipShield");
                }
            }
        }

        [JsonProperty("dcK")]
        public int Energy
        {
            get => energy;
            set
            {
                if (ReferenceEquals(energy, value) != true)
                {
                    energy = value;
                    OnPropertyChanged("Energy");
                }
            }
        }

        [JsonProperty("wGS")]
        public int Units
        {
            get => units;
            set
            {
                if (ReferenceEquals(units, value) != true)
                {
                    units = value;
                    OnPropertyChanged("Units");
                }
            }
        }

        [JsonProperty("7QL")]
        public int Nanites
        {
            get => nanites;
            set
            {
                if (ReferenceEquals(nanites, value) != true)
                {
                    nanites = value;
                    OnPropertyChanged("Nanites");
                }
            }
        }

        [JsonProperty("kN;")]
        public int Specials
        {
            get => specials;
            set
            {
                if (ReferenceEquals(specials, value) != true)
                {
                    specials = value;
                    OnPropertyChanged("Specials");
                }
            }
        }

        [JsonProperty("cid")]
        public bool ThirdPersonShip
        {
            get => thirdPersonShip;
            set
            {
                if (ReferenceEquals(thirdPersonShip, value) != true)
                {
                    thirdPersonShip = value;
                    OnPropertyChanged("ThirdPersonShip");
                }
            }
        }

        [JsonProperty("i8O")]
        public ulong TimeAlive
        {
            get => timeAlive;
            set
            {
                if (ReferenceEquals(timeAlive, value) != true)
                {
                    timeAlive = value;
                    OnPropertyChanged("TimeAlive");
                }
            }
        }

        [JsonProperty("Lg8")]
        public ulong TotalPlayTime
        {
            get => totalPlayTime;
            set
            {
                if (ReferenceEquals(totalPlayTime, value) != true)
                {
                    totalPlayTime = value;
                    OnPropertyChanged("TotalPlayTime");
                }
            }
        }

        [JsonProperty("A1f")]
        public Marker[] MarkerStack
        {
            get => markerStack;
            set
            {
                if (ReferenceEquals(markerStack, value) != true)
                {
                    markerStack = value;
                    OnPropertyChanged("MarkerStack");
                }
            }
        }

        [JsonProperty("i;<")]
        public object[] NewMPMarkerStack
        {
            get => newMPMarkerStack;
            set
            {
                if (ReferenceEquals(newMPMarkerStack, value) != true)
                {
                    newMPMarkerStack = value;
                    OnPropertyChanged("NewMPMarkerStack");
                }
            }
        }

        [JsonProperty("CYJ")]
        public Vector4[] SurveyedEventPositions
        {
            get => surveyedEventPositions;
            set
            {
                if (ReferenceEquals(surveyedEventPositions, value) != true)
                {
                    surveyedEventPositions = value;
                    OnPropertyChanged("SurveyedEventPositions");
                }
            }
        }

        [JsonProperty("6Ws")]
        public int NextSurveyedEventPositionIndex
        {
            get => nextSurveyedEventPositionIndex;
            set
            {
                if (ReferenceEquals(nextSurveyedEventPositionIndex, value) != true)
                {
                    nextSurveyedEventPositionIndex = value;
                    OnPropertyChanged("NextSurveyedEventPositionIndex");
                }
            }
        }

        [JsonProperty("gUR")]
        public Stat[] Stats
        {
            get => stats;
            set
            {
                if (ReferenceEquals(stats, value) != true)
                {
                    stats = value;
                    OnPropertyChanged("Stats");
                }
            }
        }

        [JsonProperty("m4I")]
        public Telemetry[] TelemetryStats
        {
            get => telemetryStats;
            set
            {
                if (ReferenceEquals(telemetryStats, value) != true)
                {
                    telemetryStats = value;
                    OnPropertyChanged("TelemetryStats");
                }
            }
        }

        [JsonProperty("a6j")]
        public StoredInteraction[] StoredInteractions
        {
            get => storedInteractions;
            set
            {
                if (ReferenceEquals(storedInteractions, value) != true)
                {
                    storedInteractions = value;
                    OnPropertyChanged("StoredInteractions");
                }
            }
        }

        [JsonProperty("RQA")]
        public InteractionData[] MaintenanceInteractions
        {
            get => maintenanceInteractions;
            set
            {
                if (ReferenceEquals(maintenanceInteractions, value) != true)
                {
                    maintenanceInteractions = value;
                    OnPropertyChanged("MaintenanceInteractions");
                }
            }
        }

        [JsonProperty("VhC")]
        public InteractionData[] PersonalMaintenanceInteractions
        {
            get => personalMaintenanceInteractions;
            set
            {
                if (ReferenceEquals(personalMaintenanceInteractions, value) != true)
                {
                    personalMaintenanceInteractions = value;
                    OnPropertyChanged("PersonalMaintenanceInteractions");
                }
            }
        }

        [JsonProperty("nwS")]
        public long[] VisitedSystems
        {
            get => visitedSystems;
            set
            {
                if (ReferenceEquals(visitedSystems, value) != true)
                {
                    visitedSystems = value;
                    OnPropertyChanged("VisitedSystems");
                }
            }
        }

        [JsonProperty("seg")]
        public double[] Hazard
        {
            get => hazard;
            set
            {
                if (ReferenceEquals(hazard, value) != true)
                {
                    hazard = value;
                    OnPropertyChanged("Hazard");
                }
            }
        }

        [JsonProperty("9Lm")]
        public int BoltAmmo
        {
            get => boltAmmo;
            set
            {
                if (ReferenceEquals(boltAmmo, value) != true)
                {
                    boltAmmo = value;
                    OnPropertyChanged("BoltAmmo");
                }
            }
        }

        [JsonProperty("VPy")]
        public int ScatterAmmo
        {
            get => scatterAmmo;
            set
            {
                if (ReferenceEquals(scatterAmmo, value) != true)
                {
                    scatterAmmo = value;
                    OnPropertyChanged("ScatterAmmo");
                }
            }
        }

        [JsonProperty(":ML")]
        public int PulseAmmo
        {
            get => pulseAmmo;
            set
            {
                if (ReferenceEquals(pulseAmmo, value) != true)
                {
                    pulseAmmo = value;
                    OnPropertyChanged("PulseAmmo");
                }
            }
        }

        [JsonProperty("cO>")]
        public int LaserAmmo
        {
            get => laserAmmo;
            set
            {
                if (ReferenceEquals(laserAmmo, value) != true)
                {
                    laserAmmo = value;
                    OnPropertyChanged("LaserAmmo");
                }
            }
        }

        [JsonProperty("vaP")]
        public Vector4 FirstSpawnPosition
        {
            get => firstSpawnPosition;
            set
            {
                if (ReferenceEquals(firstSpawnPosition, value) != true)
                {
                    firstSpawnPosition = value;
                    OnPropertyChanged("FirstSpawnPosition");
                }
            }
        }

        [JsonProperty("E?v")]
        public InteractionIndicies[] SavedInteractionIndicies
        {
            get => savedInteractionIndicies;
            set
            {
                if (ReferenceEquals(savedInteractionIndicies, value) != true)
                {
                    savedInteractionIndicies = value;
                    OnPropertyChanged("SavedInteractionIndicies");
                }
            }
        }

        [JsonProperty("Wu?")]
        public InteractionDialog[] SavedInteractionDialogTable
        {
            get => savedInteractionDialogTable;
            set
            {
                if (ReferenceEquals(savedInteractionDialogTable, value) != true)
                {
                    savedInteractionDialogTable = value;
                    OnPropertyChanged("SavedInteractionDialogTable");
                }
            }
        }

        [JsonProperty("wHR")]
        public string[] InteractionProgressTable
        {
            get => interactionProgressTable;
            set
            {
                if (ReferenceEquals(interactionProgressTable, value) != true)
                {
                    interactionProgressTable = value;
                    OnPropertyChanged("InteractionProgressTable");
                }
            }
        }

        [JsonProperty("vsV")]
        public UniverseCoordinates[] AtlasStationAdressData
        {
            get => atlasStationAdressData;
            set
            {
                if (ReferenceEquals(atlasStationAdressData, value) != true)
                {
                    atlasStationAdressData = value;
                    OnPropertyChanged("AtlasStationAdressData");
                }
            }
        }

        [JsonProperty("B9>")]
        public UniverseCoordinates[] NewAtlasStationAdressData
        {
            get => newAtlasStationAdressData;
            set
            {
                if (ReferenceEquals(newAtlasStationAdressData, value) != true)
                {
                    newAtlasStationAdressData = value;
                    OnPropertyChanged("NewAtlasStationAdressData");
                }
            }
        }

        [JsonProperty(":A3")]
        public UniverseCoordinates[] VisitedAtlasStationsData
        {
            get => visitedAtlasStationsData;
            set
            {
                if (ReferenceEquals(visitedAtlasStationsData, value) != true)
                {
                    visitedAtlasStationsData = value;
                    OnPropertyChanged("VisitedAtlasStationsData");
                }
            }
        }

        [JsonProperty(":0x")]
        public bool FirstAtlasStationDiscovered
        {
            get => firstAtlasStationDiscovered;
            set
            {
                if (ReferenceEquals(firstAtlasStationDiscovered, value) != true)
                {
                    firstAtlasStationDiscovered = value;
                    OnPropertyChanged("FirstAtlasStationDiscovered");
                }
            }
        }

        [JsonProperty("kPF")]
        public bool UsesThirdPersonCharacterCam
        {
            get => usesThirdPersonCharacterCam;
            set
            {
                if (ReferenceEquals(usesThirdPersonCharacterCam, value) != true)
                {
                    usesThirdPersonCharacterCam = value;
                    OnPropertyChanged("UsesThirdPersonCharacterCam");
                }
            }
        }

        [JsonProperty("DtI")]
        public int ProgressionLevel
        {
            get => progressionLevel;
            set
            {
                if (ReferenceEquals(progressionLevel, value) != true)
                {
                    progressionLevel = value;
                    OnPropertyChanged("ProgressionLevel");
                }
            }
        }

        [JsonProperty("QNH")]
        public int ProcTechIndex
        {
            get => procTechIndex;
            set
            {
                if (ReferenceEquals(procTechIndex, value) != true)
                {
                    procTechIndex = value;
                    OnPropertyChanged("ProcTechIndex");
                }
            }
        }

        [JsonProperty("eV1")]
        public bool IsNew
        {
            get => isNew;
            set
            {
                if (ReferenceEquals(isNew, value) != true)
                {
                    isNew = value;
                    OnPropertyChanged("IsNew");
                }
            }
        }

        [JsonProperty("wc3")]
        public bool UseSmallerBlackholeJumps
        {
            get => useSmallerBlackholeJumps;
            set
            {
                if (ReferenceEquals(useSmallerBlackholeJumps, value) != true)
                {
                    useSmallerBlackholeJumps = value;
                    OnPropertyChanged("UseSmallerBlackholeJumps");
                }
            }
        }

        [JsonProperty("<dk")]
        public object[] UsedEntitlements
        {
            get => usedEntitlements;
            set
            {
                if (ReferenceEquals(usedEntitlements, value) != true)
                {
                    usedEntitlements = value;
                    OnPropertyChanged("UsedEntitlements");
                }
            }
        }

        [JsonProperty("aHM")]
        public Vector3[] PlanetPositions
        {
            get => planetPositions;
            set
            {
                if (ReferenceEquals(planetPositions, value) != true)
                {
                    planetPositions = value;
                    OnPropertyChanged("PlanetPositions");
                }
            }
        }

        [JsonProperty("?=a")]
        public object[][] PlanetSeeds
        {
            get => planetSeeds;
            set
            {
                if (ReferenceEquals(planetSeeds, value) != true)
                {
                    planetSeeds = value;
                    OnPropertyChanged("PlanetSeeds");
                }
            }
        }

        [JsonProperty("7Mc")]
        public int PrimaryPlanet
        {
            get => primaryPlanet;
            set
            {
                if (ReferenceEquals(primaryPlanet, value) != true)
                {
                    primaryPlanet = value;
                    OnPropertyChanged("PrimaryPlanet");
                }
            }
        }

        [JsonProperty("05J")]
        public ulong TimeLastSpaceBattle
        {
            get => timeLastSpaceBattle;
            set
            {
                if (ReferenceEquals(timeLastSpaceBattle, value) != true)
                {
                    timeLastSpaceBattle = value;
                    OnPropertyChanged("TimeLastSpaceBattle");
                }
            }
        }

        [JsonProperty("8br")]
        public int WarpsLastSpaceBattle
        {
            get => warpsLastSpaceBattle;
            set
            {
                if (ReferenceEquals(warpsLastSpaceBattle, value) != true)
                {
                    warpsLastSpaceBattle = value;
                    OnPropertyChanged("WarpsLastSpaceBattle");
                }
            }
        }

        [JsonProperty("8xx")]
        public int ActiveSpaceBattleUA
        {
            get => activeSpaceBattleUA;
            set
            {
                if (ReferenceEquals(activeSpaceBattleUA, value) != true)
                {
                    activeSpaceBattleUA = value;
                    OnPropertyChanged("ActiveSpaceBattleUA");
                }
            }
        }

        [JsonProperty("IRi")]
        public ulong TimeLastMiniStation
        {
            get => timeLastMiniStation;
            set
            {
                if (ReferenceEquals(timeLastMiniStation, value) != true)
                {
                    timeLastMiniStation = value;
                    OnPropertyChanged("TimeLastMiniStation");
                }
            }
        }

        [JsonProperty("x=M")]
        public int WarpsLastMiniStation
        {
            get => warpsLastMiniStation;
            set
            {
                if (ReferenceEquals(warpsLastMiniStation, value) != true)
                {
                    warpsLastMiniStation = value;
                    OnPropertyChanged("WarpsLastMiniStation");
                }
            }
        }

        [JsonProperty("gpU")]
        public string MiniStationUA
        {
            get => miniStationUA;
            set
            {
                if (ReferenceEquals(miniStationUA, value) != true)
                {
                    miniStationUA = value;
                    OnPropertyChanged("MiniStationUA");
                }
            }
        }

        [JsonProperty("JvI")]
        public Vector4 AnomalyPositionOverride
        {
            get => anomalyPositionOverride;
            set
            {
                if (ReferenceEquals(anomalyPositionOverride, value) != true)
                {
                    anomalyPositionOverride = value;
                    OnPropertyChanged("AnomalyPositionOverride");
                }
            }
        }

        [JsonProperty("5ST")]
        public UniverseCoordinates GameStartAddress1
        {
            get => gameStartAddress1;
            set
            {
                if (ReferenceEquals(gameStartAddress1, value) != true)
                {
                    gameStartAddress1 = value;
                    OnPropertyChanged("GameStartAddress1");
                }
            }
        }

        [JsonProperty("EeN")]
        public UniverseCoordinates GameStartAddress2
        {
            get => gameStartAddress2;
            set
            {
                if (ReferenceEquals(gameStartAddress2, value) != true)
                {
                    gameStartAddress2 = value;
                    OnPropertyChanged("GameStartAddress2");
                }
            }
        }

        [JsonProperty("M2Z")]
        public bool[] GalacticMapRequests
        {
            get => galacticMapRequests;
            set
            {
                if (ReferenceEquals(galacticMapRequests, value) != true)
                {
                    galacticMapRequests = value;
                    OnPropertyChanged("GalacticMapRequests");
                }
            }
        }

        [JsonProperty("nTB")]
        public Vector4 FirstShipPosition
        {
            get => firstShipPosition;
            set
            {
                if (ReferenceEquals(firstShipPosition, value) != true)
                {
                    firstShipPosition = value;
                    OnPropertyChanged("FirstShipPosition");
                }
            }
        }

        [JsonProperty("G?:")]
        public ulong HazardTimeAlive
        {
            get => hazardTimeAlive;
            set
            {
                if (ReferenceEquals(hazardTimeAlive, value) != true)
                {
                    hazardTimeAlive = value;
                    OnPropertyChanged("HazardTimeAlive");
                }
            }
        }

        [JsonProperty("tSD")]
        public bool RevealBlackHoles
        {
            get => revealBlackHoles;
            set
            {
                if (ReferenceEquals(revealBlackHoles, value) != true)
                {
                    revealBlackHoles = value;
                    OnPropertyChanged("RevealBlackHoles");
                }
            }
        }

        [JsonProperty("kYq")]
        public object[] CurrentFreighterHomeSystemSeed
        {
            get => currentFreighterHomeSystemSeed;
            set
            {
                if (ReferenceEquals(currentFreighterHomeSystemSeed, value) != true)
                {
                    currentFreighterHomeSystemSeed = value;
                    OnPropertyChanged("CurrentFreighterHomeSystemSeed");
                }
            }
        }

        [JsonProperty("bIR")]
        public ProceduralObject CurrentFreighter
        {
            get => currentFreighter;
            set
            {
                if (ReferenceEquals(currentFreighter, value) != true)
                {
                    currentFreighter = value;
                    OnPropertyChanged("CurrentFreighter");
                }
            }
        }

        [JsonProperty(">Yh")]
        public CatalogLayout FreighterLayout
        {
            get => freighterLayout;
            set
            {
                if (ReferenceEquals(freighterLayout, value) != true)
                {
                    freighterLayout = value;
                    OnPropertyChanged("FreighterLayout");
                }
            }
        }

        [JsonProperty("8ZP")]
        public Catalog FreighterInventory
        {
            get => freighterInventory;
            set
            {
                if (ReferenceEquals(freighterInventory, value) != true)
                {
                    freighterInventory = value;
                    OnPropertyChanged("FreighterInventory");
                }
            }
        }

        [JsonProperty("0wS")]
        public Catalog FreighterInventoryTech
        {
            get => freighterInventoryTech;
            set
            {
                if (ReferenceEquals(freighterInventoryTech, value) != true)
                {
                    freighterInventoryTech = value;
                    OnPropertyChanged("FreighterInventoryTech");
                }
            }
        }

        [JsonProperty("RB7")]
        public UniverseCoordinates FreighterUniverseAddress
        {
            get => freighterUniverseAddress;
            set
            {
                if (ReferenceEquals(freighterUniverseAddress, value) != true)
                {
                    freighterUniverseAddress = value;
                    OnPropertyChanged("FreighterUniverseAddress");
                }
            }
        }

        [JsonProperty("9wg")]
        public Vector3 FreighterMatrixAt
        {
            get => freighterMatrixAt;
            set
            {
                if (ReferenceEquals(freighterMatrixAt, value) != true)
                {
                    freighterMatrixAt = value;
                    OnPropertyChanged("FreighterMatrixAt");
                }
            }
        }

        [JsonProperty("fUl")]
        public Vector3 FreighterMatrixUp
        {
            get => freighterMatrixUp;
            set
            {
                if (ReferenceEquals(freighterMatrixUp, value) != true)
                {
                    freighterMatrixUp = value;
                    OnPropertyChanged("FreighterMatrixUp");
                }
            }
        }

        [JsonProperty("lpm")]
        public Vector3 FreighterMatrixPos
        {
            get => freighterMatrixPos;
            set
            {
                if (ReferenceEquals(freighterMatrixPos, value) != true)
                {
                    freighterMatrixPos = value;
                    OnPropertyChanged("FreighterMatrixPos");
                }
            }
        }

        [JsonProperty("c5s")]
        public ObservableCollection<BuildingObject> BaseBuildingObjects
        {
            get => baseBuildingObjects;
            set
            {
                if (ReferenceEquals(baseBuildingObjects, value) != true)
                {
                    baseBuildingObjects = value;
                    OnPropertyChanged("BaseBuildingObjects");
                }
            }
        }

        [JsonProperty("=o:")]
        public TerrainData TerrainEditData
        {
            get => terrainEditData;
            set
            {
                if (ReferenceEquals(terrainEditData, value) != true)
                {
                    terrainEditData = value;
                    OnPropertyChanged("TerrainEditData");
                }
            }
        }

        [JsonProperty("4Km")]
        public NPCWorker[] NPCWorkers
        {
            get => nPCWorkers;
            set
            {
                if (ReferenceEquals(nPCWorkers, value) != true)
                {
                    nPCWorkers = value;
                    OnPropertyChanged("NPCWorkers");
                }
            }
        }

        [JsonProperty("F?0")]
        public ObservableCollection<PlayerBase> PersistentPlayerBases
        {
            get => persistentPlayerBases;
            set
            {
                if (ReferenceEquals(persistentPlayerBases, value) != true)
                {
                    persistentPlayerBases = value;
                    OnPropertyChanged("PersistentPlayerBases");
                }
            }
        }

        [JsonProperty("nlG")]
        public PortalData[] TeleportEndpoints
        {
            get => teleportEndpoints;
            set
            {
                if (ReferenceEquals(teleportEndpoints, value) != true)
                {
                    teleportEndpoints = value;
                    OnPropertyChanged("TeleportEndpoints");
                }
            }
        }

        [JsonProperty("=3B")]
        public CatalogLayout Chest0Layout
        {
            get => chest0Layout;
            set
            {
                if (ReferenceEquals(chest0Layout, value) != true)
                {
                    chest0Layout = value;
                    OnPropertyChanged("Chest0Layout");
                }
            }
        }

        [JsonProperty("3Nc")]
        public Catalog Chest0Inventory
        {
            get => chest0Inventory;
            set
            {
                if (ReferenceEquals(chest0Inventory, value) != true)
                {
                    chest0Inventory = value;
                    OnPropertyChanged("Chest0Inventory");
                }
            }
        }

        [JsonProperty("@ip")]
        public CatalogLayout Chest1Layout
        {
            get => chest1Layout;
            set
            {
                if (ReferenceEquals(chest1Layout, value) != true)
                {
                    chest1Layout = value;
                    OnPropertyChanged("Chest1Layout");
                }
            }
        }

        [JsonProperty("IDc")]
        public Catalog Chest1Inventory
        {
            get => chest1Inventory;
            set
            {
                if (ReferenceEquals(chest1Inventory, value) != true)
                {
                    chest1Inventory = value;
                    OnPropertyChanged("Chest1Inventory");
                }
            }
        }

        [JsonProperty("@Ik")]
        public CatalogLayout Chest2Layout
        {
            get => chest2Layout;
            set
            {
                if (ReferenceEquals(chest2Layout, value) != true)
                {
                    chest2Layout = value;
                    OnPropertyChanged("Chest2Layout");
                }
            }
        }

        [JsonProperty("M=:")]
        public Catalog Chest2Inventory
        {
            get => chest2Inventory;
            set
            {
                if (ReferenceEquals(chest2Inventory, value) != true)
                {
                    chest2Inventory = value;
                    OnPropertyChanged("Chest2Inventory");
                }
            }
        }

        [JsonProperty("@1E")]
        public CatalogLayout Chest3Layout
        {
            get => chest3Layout;
            set
            {
                if (ReferenceEquals(chest3Layout, value) != true)
                {
                    chest3Layout = value;
                    OnPropertyChanged("Chest3Layout");
                }
            }
        }

        [JsonProperty("iYp")]
        public Catalog Chest3Inventory
        {
            get => chest3Inventory;
            set
            {
                if (ReferenceEquals(chest3Inventory, value) != true)
                {
                    chest3Inventory = value;
                    OnPropertyChanged("Chest3Inventory");
                }
            }
        }

        [JsonProperty("XgV")]
        public CatalogLayout Chest4Layout
        {
            get => chest4Layout;
            set
            {
                if (ReferenceEquals(chest4Layout, value) != true)
                {
                    chest4Layout = value;
                    OnPropertyChanged("Chest4Layout");
                }
            }
        }

        [JsonProperty("<IP")]
        public Catalog Chest4Inventory
        {
            get => chest4Inventory;
            set
            {
                if (ReferenceEquals(chest4Inventory, value) != true)
                {
                    chest4Inventory = value;
                    OnPropertyChanged("Chest4Inventory");
                }
            }
        }

        [JsonProperty("nw5")]
        public CatalogLayout Chest5Layout
        {
            get => chest5Layout;
            set
            {
                if (ReferenceEquals(chest5Layout, value) != true)
                {
                    chest5Layout = value;
                    OnPropertyChanged("Chest5Layout");
                }
            }
        }

        [JsonProperty("qYJ")]
        public Catalog Chest5Inventory
        {
            get => chest5Inventory;
            set
            {
                if (ReferenceEquals(chest5Inventory, value) != true)
                {
                    chest5Inventory = value;
                    OnPropertyChanged("Chest5Inventory");
                }
            }
        }

        [JsonProperty("tLo")]
        public CatalogLayout Chest6Layout
        {
            get => chest6Layout;
            set
            {
                if (ReferenceEquals(chest6Layout, value) != true)
                {
                    chest6Layout = value;
                    OnPropertyChanged("Chest6Layout");
                }
            }
        }

        [JsonProperty("@e5")]
        public Catalog Chest6Inventory
        {
            get => chest6Inventory;
            set
            {
                if (ReferenceEquals(chest6Inventory, value) != true)
                {
                    chest6Inventory = value;
                    OnPropertyChanged("Chest6Inventory");
                }
            }
        }

        [JsonProperty("7b?")]
        public CatalogLayout Chest7Layout
        {
            get => chest7Layout;
            set
            {
                if (ReferenceEquals(chest7Layout, value) != true)
                {
                    chest7Layout = value;
                    OnPropertyChanged("Chest7Layout");
                }
            }
        }

        [JsonProperty("5uh")]
        public Catalog Chest7Inventory
        {
            get => chest7Inventory;
            set
            {
                if (ReferenceEquals(chest7Inventory, value) != true)
                {
                    chest7Inventory = value;
                    OnPropertyChanged("Chest7Inventory");
                }
            }
        }

        [JsonProperty("QBc")]
        public CatalogLayout Chest8Layout
        {
            get => chest8Layout;
            set
            {
                if (ReferenceEquals(chest8Layout, value) != true)
                {
                    chest8Layout = value;
                    OnPropertyChanged("Chest8Layout");
                }
            }
        }

        [JsonProperty("5Tg")]
        public Catalog Chest8Inventory
        {
            get => chest8Inventory;
            set
            {
                if (ReferenceEquals(chest8Inventory, value) != true)
                {
                    chest8Inventory = value;
                    OnPropertyChanged("Chest8Inventory");
                }
            }
        }

        [JsonProperty("wqf")]
        public CatalogLayout Chest9Layout
        {
            get => chest9Layout;
            set
            {
                if (ReferenceEquals(chest9Layout, value) != true)
                {
                    chest9Layout = value;
                    OnPropertyChanged("Chest9Layout");
                }
            }
        }

        [JsonProperty("Bq<")]
        public Catalog Chest9Inventory
        {
            get => chest9Inventory;
            set
            {
                if (ReferenceEquals(chest9Inventory, value) != true)
                {
                    chest9Inventory = value;
                    OnPropertyChanged("Chest9Inventory");
                }
            }
        }

        [JsonProperty("v8;")]
        public CatalogLayout ChestMagicLayout
        {
            get => chestMagicLayout;
            set
            {
                if (ReferenceEquals(chestMagicLayout, value) != true)
                {
                    chestMagicLayout = value;
                    OnPropertyChanged("ChestMagicLayout");
                }
            }
        }

        [JsonProperty(";?C")]
        public Catalog ChestMagicInventory
        {
            get => chestMagicInventory;
            set
            {
                if (ReferenceEquals(chestMagicInventory, value) != true)
                {
                    chestMagicInventory = value;
                    OnPropertyChanged("ChestMagicInventory");
                }
            }
        }

        [JsonProperty("wFm")]
        public CatalogLayout ChestMagic2Layout
        {
            get => chestMagic2Layout;
            set
            {
                if (ReferenceEquals(chestMagic2Layout, value) != true)
                {
                    chestMagic2Layout = value;
                    OnPropertyChanged("ChestMagic2Layout");
                }
            }
        }

        [JsonProperty("fCh")]
        public Catalog ChestMagic2Inventory
        {
            get => chestMagic2Inventory;
            set
            {
                if (ReferenceEquals(chestMagic2Inventory, value) != true)
                {
                    chestMagic2Inventory = value;
                    OnPropertyChanged("ChestMagic2Inventory");
                }
            }
        }

        [JsonProperty("RiP")]
        public CatalogLayout CookingIngredientsLayout
        {
            get => cookingIngredientsLayout;
            set
            {
                if (ReferenceEquals(cookingIngredientsLayout, value) != true)
                {
                    cookingIngredientsLayout = value;
                    OnPropertyChanged("CookingIngredientsLayout");
                }
            }
        }

        [JsonProperty("Kha")]
        public Catalog CookingIngredientsInventory
        {
            get => cookingIngredientsInventory;
            set
            {
                if (ReferenceEquals(cookingIngredientsInventory, value) != true)
                {
                    cookingIngredientsInventory = value;
                    OnPropertyChanged("CookingIngredientsInventory");
                }
            }
        }

        [JsonProperty("Sjw")]
        public ProceduralObject CurrentFreighterNPC
        {
            get => currentFreighterNPC;
            set
            {
                if (ReferenceEquals(currentFreighterNPC, value) != true)
                {
                    currentFreighterNPC = value;
                    OnPropertyChanged("CurrentFreighterNPC");
                }
            }
        }

        [JsonProperty("P;m")]
        public Vehicle[] VehicleOwnership
        {
            get => vehicleOwnership;
            set
            {
                if (ReferenceEquals(vehicleOwnership, value) != true)
                {
                    vehicleOwnership = value;
                    OnPropertyChanged("VehicleOwnership");
                }
            }
        }

        [JsonProperty("5sx")]
        public int PrimaryVehicle
        {
            get => primaryVehicle;
            set
            {
                if (ReferenceEquals(primaryVehicle, value) != true)
                {
                    primaryVehicle = value;
                    OnPropertyChanged("PrimaryVehicle");
                }
            }
        }

        [JsonProperty("@Cs")]
        public Vehicle[] ShipOwnership
        {
            get => shipOwnership;
            set
            {
                if (ReferenceEquals(shipOwnership, value) != true)
                {
                    shipOwnership = value;
                    OnPropertyChanged("ShipOwnership");
                }
            }
        }

        [JsonProperty("aBE")]
        public int PrimaryShip
        {
            get => primaryShip;
            set
            {
                if (ReferenceEquals(primaryShip, value) != true)
                {
                    primaryShip = value;
                    OnPropertyChanged("PrimaryShip");
                }
            }
        }

        [JsonProperty("@Vn")]
        public bool MultiShipEnabled
        {
            get => multiShipEnabled;
            set
            {
                if (ReferenceEquals(multiShipEnabled, value) != true)
                {
                    multiShipEnabled = value;
                    OnPropertyChanged("MultiShipEnabled");
                }
            }
        }

        [JsonProperty("vxi")]
        public string PlayerFreighterName
        {
            get => playerFreighterName;
            set
            {
                if (ReferenceEquals(playerFreighterName, value) != true)
                {
                    playerFreighterName = value;
                    OnPropertyChanged("PlayerFreighterName");
                }
            }
        }

        [JsonProperty("h=c")]
        public Vector4 StartGameShipPosition
        {
            get => startGameShipPosition;
            set
            {
                if (ReferenceEquals(startGameShipPosition, value) != true)
                {
                    startGameShipPosition = value;
                    OnPropertyChanged("StartGameShipPosition");
                }
            }
        }

        [JsonProperty("Bur")]
        public bool ShipNeedsTerrainPositioning
        {
            get => shipNeedsTerrainPositioning;
            set
            {
                if (ReferenceEquals(shipNeedsTerrainPositioning, value) != true)
                {
                    shipNeedsTerrainPositioning = value;
                    OnPropertyChanged("ShipNeedsTerrainPositioning");
                }
            }
        }

        [JsonProperty("nkF")]
        public int TradingSupplyDataIndex
        {
            get => tradingSupplyDataIndex;
            set
            {
                if (ReferenceEquals(tradingSupplyDataIndex, value) != true)
                {
                    tradingSupplyDataIndex = value;
                    OnPropertyChanged("TradingSupplyDataIndex");
                }
            }
        }

        [JsonProperty("b69")]
        public TradeSupplyData[] TradingSupplyData
        {
            get => tradingSupplyData;
            set
            {
                if (ReferenceEquals(tradingSupplyData, value) != true)
                {
                    tradingSupplyData = value;
                    OnPropertyChanged("TradingSupplyData");
                }
            }
        }

        [JsonProperty("HbG")]
        public object[] LastPortal
        {
            get => lastPortal;
            set
            {
                if (ReferenceEquals(lastPortal, value) != true)
                {
                    lastPortal = value;
                    OnPropertyChanged("LastPortal");
                }
            }
        }

        [JsonProperty("NQJ")]
        public Portal VisitedPortal
        {
            get => visitedPortal;
            set
            {
                if (ReferenceEquals(visitedPortal, value) != true)
                {
                    visitedPortal = value;
                    OnPropertyChanged("VisitedPortal");
                }
            }
        }

        [JsonProperty("vrS")]
        public int KnownPortalRunes
        {
            get => knownPortalRunes;
            set
            {
                if (ReferenceEquals(knownPortalRunes, value) != true)
                {
                    knownPortalRunes = value;
                    OnPropertyChanged("KnownPortalRunes");
                }
            }
        }

        [JsonProperty("DaC")]
        public bool OnOtherSideOfPortal
        {
            get => onOtherSideOfPortal;
            set
            {
                if (ReferenceEquals(onOtherSideOfPortal, value) != true)
                {
                    onOtherSideOfPortal = value;
                    OnPropertyChanged("OnOtherSideOfPortal");
                }
            }
        }

        [JsonProperty("30s")]
        public PortalData OtherSideOfPortalReturnBase
        {
            get => otherSideOfPortalReturnBase;
            set
            {
                if (ReferenceEquals(otherSideOfPortalReturnBase, value) != true)
                {
                    otherSideOfPortalReturnBase = value;
                    OnPropertyChanged("OtherSideOfPortalReturnBase");
                }
            }
        }

        [JsonProperty("LIR")]
        public Vector4 PortalMarkerPosition_Local
        {
            get => portalMarkerPosition_Local;
            set
            {
                if (ReferenceEquals(portalMarkerPosition_Local, value) != true)
                {
                    portalMarkerPosition_Local = value;
                    OnPropertyChanged("PortalMarkerPosition_Local");
                }
            }
        }

        [JsonProperty("qW;")]
        public Vector4 PortalMarkerPosition_Offset
        {
            get => portalMarkerPosition_Offset;
            set
            {
                if (ReferenceEquals(portalMarkerPosition_Offset, value) != true)
                {
                    portalMarkerPosition_Offset = value;
                    OnPropertyChanged("PortalMarkerPosition_Offset");
                }
            }
        }

        [JsonProperty(";DM")]
        public WeaponDescription StartingPrimaryWeapon
        {
            get => startingPrimaryWeapon;
            set
            {
                if (ReferenceEquals(startingPrimaryWeapon, value) != true)
                {
                    startingPrimaryWeapon = value;
                    OnPropertyChanged("StartingPrimaryWeapon");
                }
            }
        }

        [JsonProperty("SYl")]
        public WeaponDescription StartingSecondaryWeapon
        {
            get => startingSecondaryWeapon;
            set
            {
                if (ReferenceEquals(startingSecondaryWeapon, value) != true)
                {
                    startingSecondaryWeapon = value;
                    OnPropertyChanged("StartingSecondaryWeapon");
                }
            }
        }

        [JsonProperty("l:j")]
        public OutfitPreset[] OutfitPresets
        {
            get => outfitPresets;
            set
            {
                if (ReferenceEquals(outfitPresets, value) != true)
                {
                    outfitPresets = value;
                    OnPropertyChanged("OutfitPresets");
                }
            }
        }

        [JsonProperty("4hl")]
        public bool[] ShipUsesLegacyColours
        {
            get => shipUsesLegacyColours;
            set
            {
                if (ReferenceEquals(shipUsesLegacyColours, value) != true)
                {
                    shipUsesLegacyColours = value;
                    OnPropertyChanged("ShipUsesLegacyColours");
                }
            }
        }

        [JsonProperty("cf5")]
        public Outfit[] Outfits
        {
            get => outfits;
            set
            {
                if (ReferenceEquals(outfits, value) != true)
                {
                    outfits = value;
                    OnPropertyChanged("Outfits");
                }
            }
        }

        [JsonProperty("5LX")]
        public string JetpackEffect
        {
            get => jetpackEffect;
            set
            {
                if (ReferenceEquals(jetpackEffect, value) != true)
                {
                    jetpackEffect = value;
                    OnPropertyChanged("JetpackEffect");
                }
            }
        }

        [JsonProperty("3Z>")]
        public object[] FleetSeed
        {
            get => fleetSeed;
            set
            {
                if (ReferenceEquals(fleetSeed, value) != true)
                {
                    fleetSeed = value;
                    OnPropertyChanged("FleetSeed");
                }
            }
        }

        [JsonProperty(";Du")]
        public ObservableCollection<Frigate> FleetFrigates
        {
            get => fleetFrigates;
            set
            {
                if (ReferenceEquals(fleetFrigates, value) != true)
                {
                    fleetFrigates = value;
                    OnPropertyChanged("FleetFrigates");
                }
            }
        }

        [JsonProperty("kw:")]
        public object[] FleetExpeditions
        {
            get => fleetExpeditions;
            set
            {
                if (ReferenceEquals(fleetExpeditions, value) != true)
                {
                    fleetExpeditions = value;
                    OnPropertyChanged("FleetExpeditions");
                }
            }
        }

        [JsonProperty("ieD")]
        public object[] ExpeditionSeedsSelectedToday
        {
            get => expeditionSeedsSelectedToday;
            set
            {
                if (ReferenceEquals(expeditionSeedsSelectedToday, value) != true)
                {
                    expeditionSeedsSelectedToday = value;
                    OnPropertyChanged("ExpeditionSeedsSelectedToday");
                }
            }
        }

        [JsonProperty("nxr")]
        public ulong LastKnownDay
        {
            get => lastKnownDay;
            set
            {
                if (ReferenceEquals(lastKnownDay, value) != true)
                {
                    lastKnownDay = value;
                    OnPropertyChanged("LastKnownDay");
                }
            }
        }

        [JsonProperty(">db")]
        public ulong SunTimer
        {
            get => sunTimer;
            set
            {
                if (ReferenceEquals(sunTimer, value) != true)
                {
                    sunTimer = value;
                    OnPropertyChanged("SunTimer");
                }
            }
        }

        [JsonProperty("vXX")]
        public long MultiplayerLobbyID
        {
            get => multiplayerLobbyID;
            set
            {
                if (ReferenceEquals(multiplayerLobbyID, value) != true)
                {
                    multiplayerLobbyID = value;
                    OnPropertyChanged("MultiplayerLobbyID");
                }
            }
        }

        [JsonProperty("YxD")]
        public UniverseCoordinates MultiplayerUA
        {
            get => multiplayerUA;
            set
            {
                if (ReferenceEquals(multiplayerUA, value) != true)
                {
                    multiplayerUA = value;
                    OnPropertyChanged("MultiplayerUA");
                }
            }
        }

        [JsonProperty("x<b")]
        public SpawnData MultiplayerSpawn
        {
            get => multiplayerSpawn;
            set
            {
                if (ReferenceEquals(multiplayerSpawn, value) != true)
                {
                    multiplayerSpawn = value;
                    OnPropertyChanged("MultiplayerSpawn");
                }
            }
        }

        [JsonProperty("wyZ")]
        public object[] RepairTechBuffer
        {
            get => repairTechBuffer;
            set
            {
                if (ReferenceEquals(repairTechBuffer, value) != true)
                {
                    repairTechBuffer = value;
                    OnPropertyChanged("RepairTechBuffer");
                }
            }
        }

        [JsonProperty("kpg")]
        public ulong MultiplayerPrivileges
        {
            get => multiplayerPrivileges;
            set
            {
                if (ReferenceEquals(multiplayerPrivileges, value) != true)
                {
                    multiplayerPrivileges = value;
                    OnPropertyChanged("MultiplayerPrivileges");
                }
            }
        }

        [JsonProperty("k8N")]
        public HotAction[] HotActions
        {
            get => hotActions;
            set
            {
                if (ReferenceEquals(hotActions, value) != true)
                {
                    hotActions = value;
                    OnPropertyChanged("HotActions");
                }
            }
        }

        [JsonProperty("8GF")]
        public object LastUABeforePortalWarp
        {
            get => lastUABeforePortalWarp;
            set
            {
                if (ReferenceEquals(lastUABeforePortalWarp, value) != true)
                {
                    lastUABeforePortalWarp = value;
                    OnPropertyChanged("LastUABeforePortalWarp");
                }
            }
        }

        [JsonProperty("7Un")]
        public int StoryPortalSeed
        {
            get => storyPortalSeed;
            set
            {
                if (ReferenceEquals(storyPortalSeed, value) != true)
                {
                    storyPortalSeed = value;
                    OnPropertyChanged("StoryPortalSeed");
                }
            }
        }

        [JsonProperty("aPn")]
        public ushort ShopNumber
        {
            get => shopNumber;
            set
            {
                if (ReferenceEquals(shopNumber, value) != true)
                {
                    shopNumber = value;
                    OnPropertyChanged("ShopNumber");
                }
            }
        }

        [JsonProperty("rk3")]
        public ushort ShopTier
        {
            get => shopTier;
            set
            {
                if (ReferenceEquals(shopTier, value) != true)
                {
                    shopTier = value;
                    OnPropertyChanged("ShopTier");
                }
            }
        }

        [JsonProperty("Ue9")]
        public bool HasAccessToNexus
        {
            get => hasAccessToNexus;
            set
            {
                if (ReferenceEquals(hasAccessToNexus, value) != true)
                {
                    hasAccessToNexus = value;
                    OnPropertyChanged("HasAccessToNexus");
                }
            }
        }

        [JsonProperty("hiE")]
        public UniverseCoordinates NexusUniverseAddress
        {
            get => nexusUniverseAddress;
            set
            {
                if (ReferenceEquals(nexusUniverseAddress, value) != true)
                {
                    nexusUniverseAddress = value;
                    OnPropertyChanged("NexusUniverseAddress");
                }
            }
        }

        [JsonProperty("Fk@")]
        public Vector3 NexusMatrixAt
        {
            get => nexusMatrixAt;
            set
            {
                if (ReferenceEquals(nexusMatrixAt, value) != true)
                {
                    nexusMatrixAt = value;
                    OnPropertyChanged("NexusMatrixAt");
                }
            }
        }

        [JsonProperty("d72")]
        public Vector3 NexusMatrixUp
        {
            get => nexusMatrixUp;
            set
            {
                if (ReferenceEquals(nexusMatrixUp, value) != true)
                {
                    nexusMatrixUp = value;
                    OnPropertyChanged("NexusMatrixUp");
                }
            }
        }

        [JsonProperty("Yel")]
        public Vector3 NexusMatrixPos
        {
            get => nexusMatrixPos;
            set
            {
                if (ReferenceEquals(nexusMatrixPos, value) != true)
                {
                    nexusMatrixPos = value;
                    OnPropertyChanged("NexusMatrixPos");
                }
            }
        }

        [JsonProperty("j3Y")]
        public PhotoSettings PhotoModeSettings
        {
            get => photoModeSettings;
            set
            {
                if (ReferenceEquals(photoModeSettings, value) != true)
                {
                    photoModeSettings = value;
                    OnPropertyChanged("PhotoModeSettings");
                }
            }
        }

        [JsonProperty("9hR")]
        public int BannerIcon
        {
            get => bannerIcon;
            set
            {
                if (ReferenceEquals(bannerIcon, value) != true)
                {
                    bannerIcon = value;
                    OnPropertyChanged("BannerIcon");
                }
            }
        }

        [JsonProperty("8DG")]
        public int BannerMainColour
        {
            get => bannerMainColour;
            set
            {
                if (ReferenceEquals(bannerMainColour, value) != true)
                {
                    bannerMainColour = value;
                    OnPropertyChanged("BannerMainColour");
                }
            }
        }

        [JsonProperty("lmE")]
        public int BannerBackgroundColour
        {
            get => bannerBackgroundColour;
            set
            {
                if (ReferenceEquals(bannerBackgroundColour, value) != true)
                {
                    bannerBackgroundColour = value;
                    OnPropertyChanged("BannerBackgroundColour");
                }
            }
        }

        [JsonProperty("aNF")]
        public string BannerTitleId
        {
            get => bannerTitleId;
            set
            {
                if (ReferenceEquals(bannerTitleId, value) != true)
                {
                    bannerTitleId = value;
                    OnPropertyChanged("BannerTitleId");
                }
            }
        }

        [JsonProperty("qFl")]
        public int TelemetryUploadVersion
        {
            get => telemetryUploadVersion;
            set
            {
                if (ReferenceEquals(telemetryUploadVersion, value) != true)
                {
                    telemetryUploadVersion = value;
                    OnPropertyChanged("TelemetryUploadVersion");
                }
            }
        }

        [JsonProperty("wb:")]
        public bool UsesThirdPersonVehicleCam
        {
            get => usesThirdPersonVehicleCam;
            set
            {
                if (ReferenceEquals(usesThirdPersonVehicleCam, value) != true)
                {
                    usesThirdPersonVehicleCam = value;
                    OnPropertyChanged("UsesThirdPersonVehicleCam");
                }
            }
        }

        [JsonProperty("T>Z")]
        public double VRCameraOffset
        {
            get => vRCameraOffset;
            set
            {
                if (ReferenceEquals(vRCameraOffset, value) != true)
                {
                    vRCameraOffset = value;
                    OnPropertyChanged("VRCameraOffset");
                }
            }
        }

        [JsonProperty("TFZ")]
        public SeasonData SeasonalData
        {
            get => seasonalData;
            set
            {
                if (ReferenceEquals(seasonalData, value) != true)
                {
                    seasonalData = value;
                    OnPropertyChanged("SeasonalData");
                }
            }
        }
    }
}