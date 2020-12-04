using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMSTools.CodeGen
{

    public class NMSRoot
    {
        public int Version { get; set; }
        public string Platform { get; set; }
        public StateData PlayerStateData { get; set; }
        public SpawnData SpawnStateData { get; set; }
        public KnowledgeData GameKnowledgeData { get; set; }
        public DiscoveryData DiscoveryManagerData { get; set; }
    }

    public class StateData
    {
        public Universeaddress UniverseAddress { get; set; }
        public Previousuniverseaddress PreviousUniverseAddress { get; set; }
        public int HomeRealityIteration { get; set; }
        public Inventory Inventory { get; set; }
        public Inventory_Techonly Inventory_TechOnly { get; set; }
        public Inventory_Cargo Inventory_Cargo { get; set; }
        public Shipinventory ShipInventory { get; set; }
        public Weaponinventory WeaponInventory { get; set; }
        public Multitool[] MultiTools { get; set; }
        public int ActiveMultioolIndex { get; set; }
        public Graveinventory GraveInventory { get; set; }
        public bool SpawnGrave { get; set; }
        public bool SpaceGrave { get; set; }
        public Graveuniverseaddress GraveUniverseAddress { get; set; }
        public float[] GravePosition { get; set; }
        public float[] GraveMatrixLookAt { get; set; }
        public float[] GraveMatrixUp { get; set; }
        public Shiplayout ShipLayout { get; set; }
        public Weaponlayout WeaponLayout { get; set; }
        public Currentship CurrentShip { get; set; }
        public Currentweapon CurrentWeapon { get; set; }
        public string[] KnownTech { get; set; }
        public string[] KnownProducts { get; set; }
        public string[] KnownSpecials { get; set; }
        public string[] KnownRefinerRecipes { get; set; }
        public object[] KnownWords { get; set; }
        public Knownwordgroup[] KnownWordGroups { get; set; }
        public Missionprogress[] MissionProgress { get; set; }
        public int PostMissionIndex { get; set; }
        public string CurrentMissionID { get; set; }
        public int CurrentMissionSeed { get; set; }
        public string PreviousMissionID { get; set; }
        public int PreviousMissionSeed { get; set; }
        public int MissionVersion { get; set; }
        public Missionrecurrence[] MissionRecurrences { get; set; }
        public Holoexplorerinteraction HoloExplorerInteraction { get; set; }
        public Holoscepticinteraction HoloScepticInteraction { get; set; }
        public Holonooneinteraction HoloNooneInteraction { get; set; }
        public int Health { get; set; }
        public int ShipHealth { get; set; }
        public int Shield { get; set; }
        public int ShipShield { get; set; }
        public int Energy { get; set; }
        public int Units { get; set; }
        public int Nanites { get; set; }
        public int Specials { get; set; }
        public bool ThirdPersonShip { get; set; }
        public int TimeAlive { get; set; }
        public int TotalPlayTime { get; set; }
        public Markerstack[] MarkerStack { get; set; }
        public object[] NewMPMarkerStack { get; set; }
        public object[] SurveyedEventPositions { get; set; }
        public int NextSurveyedEventPositionIndex { get; set; }
        public Stat[] Stats { get; set; }
        public Telemetrystat[] TelemetryStats { get; set; }
        public Storedinteraction[] StoredInteractions { get; set; }
        public Maintenanceinteraction[] MaintenanceInteractions { get; set; }
        public Personalmaintenanceinteraction[] PersonalMaintenanceInteractions { get; set; }
        public long[] VisitedSystems { get; set; }
        public float[] Hazard { get; set; }
        public int BoltAmmo { get; set; }
        public int ScatterAmmo { get; set; }
        public int PulseAmmo { get; set; }
        public int LaserAmmo { get; set; }
        public float[] FirstSpawnPosition { get; set; }
        public Savedinteractionindicy[] SavedInteractionIndicies { get; set; }
        public Savedinteractiondialogtable[] SavedInteractionDialogTable { get; set; }
        public object[] InteractionProgressTable { get; set; }
        public Atlasstationadressdata[] AtlasStationAdressData { get; set; }
        public Newatlasstationadressdata[] NewAtlasStationAdressData { get; set; }
        public Visitedatlasstationsdata[] VisitedAtlasStationsData { get; set; }
        public bool FirstAtlasStationDiscovered { get; set; }
        public bool UsesThirdPersonCharacterCam { get; set; }
        public int ProgressionLevel { get; set; }
        public int ProcTechIndex { get; set; }
        public bool IsNew { get; set; }
        public bool UseSmallerBlackholeJumps { get; set; }
        public object[] UsedEntitlements { get; set; }
        public float[][] PlanetPositions { get; set; }
        public object[][] PlanetSeeds { get; set; }
        public int PrimaryPlanet { get; set; }
        public int TimeLastSpaceBattle { get; set; }
        public int WarpsLastSpaceBattle { get; set; }
        public int ActiveSpaceBattleUA { get; set; }
        public int TimeLastMiniStation { get; set; }
        public int WarpsLastMiniStation { get; set; }
        public string MiniStationUA { get; set; }
        public float[] AnomalyPositionOverride { get; set; }
        public Gamestartaddress1 GameStartAddress1 { get; set; }
        public Gamestartaddress2 GameStartAddress2 { get; set; }
        public bool[] GalacticMapRequests { get; set; }
        public float[] FirstShipPosition { get; set; }
        public int HazardTimeAlive { get; set; }
        public bool RevealBlackHoles { get; set; }
        public object[] CurrentFreighterHomeSystemSeed { get; set; }
        public Currentfreighter CurrentFreighter { get; set; }
        public Freighterlayout FreighterLayout { get; set; }
        public Freighterinventory FreighterInventory { get; set; }
        public Freighterinventory_Techonly FreighterInventory_TechOnly { get; set; }
        public Freighteruniverseaddress FreighterUniverseAddress { get; set; }
        public float[] FreighterMatrixAt { get; set; }
        public float[] FreighterMatrixUp { get; set; }
        public float[] FreighterMatrixPos { get; set; }
        public Basebuildingobject[] BaseBuildingObjects { get; set; }
        public Terraineditdata TerrainEditData { get; set; }
        public Npcworker[] NPCWorkers { get; set; }
        public Persistentplayerbas[] PersistentPlayerBases { get; set; }
        public Teleportendpoint[] TeleportEndpoints { get; set; }
        public Chest1layout Chest1Layout { get; set; }
        public Chest1inventory Chest1Inventory { get; set; }
        public Chest2layout Chest2Layout { get; set; }
        public Chest2inventory Chest2Inventory { get; set; }
        public Chest3layout Chest3Layout { get; set; }
        public Chest3inventory Chest3Inventory { get; set; }
        public Chest4layout Chest4Layout { get; set; }
        public Chest4inventory Chest4Inventory { get; set; }
        public Chest5layout Chest5Layout { get; set; }
        public Chest5inventory Chest5Inventory { get; set; }
        public Chest6layout Chest6Layout { get; set; }
        public Chest6inventory Chest6Inventory { get; set; }
        public Chest7layout Chest7Layout { get; set; }
        public Chest7inventory Chest7Inventory { get; set; }
        public Chest8layout Chest8Layout { get; set; }
        public Chest8inventory Chest8Inventory { get; set; }
        public Chest9layout Chest9Layout { get; set; }
        public Chest9inventory Chest9Inventory { get; set; }
        public Chest10layout Chest10Layout { get; set; }
        public Chest10inventory Chest10Inventory { get; set; }
        public Chestmagiclayout ChestMagicLayout { get; set; }
        public Chestmagicinventory ChestMagicInventory { get; set; }
        public Chestmagic2layout ChestMagic2Layout { get; set; }
        public Chestmagic2inventory ChestMagic2Inventory { get; set; }
        public Cookingingredientslayout CookingIngredientsLayout { get; set; }
        public Cookingingredientsinventory CookingIngredientsInventory { get; set; }
        public Currentfreighternpc CurrentFreighterNPC { get; set; }
        public Vehicleownership[] VehicleOwnership { get; set; }
        public int PrimaryVehicle { get; set; }
        public Shipownership[] ShipOwnership { get; set; }
        public int PrimaryShip { get; set; }
        public bool MultiShipEnabled { get; set; }
        public string PlayerFreighterName { get; set; }
        public float[] StartGameShipPosition { get; set; }
        public bool ShipNeedsTerrainPositioning { get; set; }
        public int TradingSupplyDataIndex { get; set; }
        public Tradingsupplydata[] TradingSupplyData { get; set; }
        public object[] LastPortal { get; set; }
        public Visitedportal VisitedPortal { get; set; }
        public int KnownPortalRunes { get; set; }
        public bool OnOtherSideOfPortal { get; set; }
        public Othersideofportalreturnbase OtherSideOfPortalReturnBase { get; set; }
        public float[] PortalMarkerPosition_Local { get; set; }
        public float[] PortalMarkerPosition_Offset { get; set; }
        public Startingprimaryweapon StartingPrimaryWeapon { get; set; }
        public Startingsecondaryweapon StartingSecondaryWeapon { get; set; }
        public Charactercustomisationdata[] CharacterCustomisationData { get; set; }
        public bool[] ShipUsesLegacyColours { get; set; }
        public Outfit[] Outfits { get; set; }
        public string JetpackEffect { get; set; }
        public object[] FleetSeed { get; set; }
        public Fleetfrigate[] FleetFrigates { get; set; }
        public object[] FleetExpeditions { get; set; }
        public object[] ExpeditionSeedsSelectedToday { get; set; }
        public int LastKnownDay { get; set; }
        public int SunTimer { get; set; }
        public int MultiplayerLobbyID { get; set; }
        public Multiplayerua MultiplayerUA { get; set; }
        public Multiplayerspawn MultiplayerSpawn { get; set; }
        public object[] RepairTechBuffer { get; set; }
        public int MultiplayerPrivileges { get; set; }
        public Hotaction[] HotActions { get; set; }
        public string LastUABeforePortalWarp { get; set; }
        public int StoryPortalSeed { get; set; }
        public int ShopNumber { get; set; }
        public int ShopTier { get; set; }
        public bool HasAccessToNexus { get; set; }
        public Nexusuniverseaddress NexusUniverseAddress { get; set; }
        public float[] NexusMatrixAt { get; set; }
        public float[] NexusMatrixUp { get; set; }
        public float[] NexusMatrixPos { get; set; }
        public Photomodesettings PhotoModeSettings { get; set; }
        public int BannerIcon { get; set; }
        public int BannerMainColour { get; set; }
        public int BannerBackgroundColour { get; set; }
        public string BannerTitleId { get; set; }
        public int TelemetryUploadVersion { get; set; }
        public bool UsesThirdPersonVehicleCam { get; set; }
        public float VRCameraOffset { get; set; }
        public Seasonaldata SeasonalData { get; set; }
    }

    public class Universeaddress
    {
        public int RealityIndex { get; set; }
        public Galacticaddress GalacticAddress { get; set; }
    }

    public class Galacticaddress
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Previousuniverseaddress
    {
        public int RealityIndex { get; set; }
        public Galacticaddress1 GalacticAddress { get; set; }
    }

    public class Galacticaddress1
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Inventory
    {
        public Slot[] Slots { get; set; }
        public Validslotindice[] ValidSlotIndices { get; set; }
        public Class1 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class1
    {
        public string InventoryClass { get; set; }
    }

    public class Slot
    {
        public Type Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index Index { get; set; }
    }

    public class Type
    {
        public string InventoryType { get; set; }
    }

    public class Index
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Inventory_Techonly
    {
        public Slot1[] Slots { get; set; }
        public Validslotindice1[] ValidSlotIndices { get; set; }
        public Class2 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class2
    {
        public string InventoryClass { get; set; }
    }

    public class Slot1
    {
        public Type1 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index1 Index { get; set; }
    }

    public class Type1
    {
        public string InventoryType { get; set; }
    }

    public class Index1
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice1
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Inventory_Cargo
    {
        public Slot2[] Slots { get; set; }
        public Validslotindice2[] ValidSlotIndices { get; set; }
        public Class3 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class3
    {
        public string InventoryClass { get; set; }
    }

    public class Slot2
    {
        public Type2 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index2 Index { get; set; }
    }

    public class Type2
    {
        public string InventoryType { get; set; }
    }

    public class Index2
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice2
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Shipinventory
    {
        public object[] Slots { get; set; }
        public object[] ValidSlotIndices { get; set; }
        public Class4 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class4
    {
        public string InventoryClass { get; set; }
    }

    public class Weaponinventory
    {
        public Slot3[] Slots { get; set; }
        public Validslotindice3[] ValidSlotIndices { get; set; }
        public Class5 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class5
    {
        public string InventoryClass { get; set; }
    }

    public class Slot3
    {
        public Type3 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index3 Index { get; set; }
    }

    public class Type3
    {
        public string InventoryType { get; set; }
    }

    public class Index3
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice3
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Graveinventory
    {
        public object[] Slots { get; set; }
        public object[] ValidSlotIndices { get; set; }
        public Class6 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class6
    {
        public string InventoryClass { get; set; }
    }

    public class Graveuniverseaddress
    {
        public int RealityIndex { get; set; }
        public Galacticaddress2 GalacticAddress { get; set; }
    }

    public class Galacticaddress2
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Shiplayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Weaponlayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Currentship
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture ProceduralTexture { get; set; }
    }

    public class Proceduraltexture
    {
        public object[] Samplers { get; set; }
    }

    public class Currentweapon
    {
        public string Filename { get; set; }
        public object[] GenerationSeed { get; set; }
    }

    public class Holoexplorerinteraction
    {
        public int GalacticAddress { get; set; }
        public int Value { get; set; }
        public float[] Position { get; set; }
    }

    public class Holoscepticinteraction
    {
        public int GalacticAddress { get; set; }
        public int Value { get; set; }
        public float[] Position { get; set; }
    }

    public class Holonooneinteraction
    {
        public int GalacticAddress { get; set; }
        public int Value { get; set; }
        public float[] Position { get; set; }
    }

    public class Gamestartaddress1
    {
        public int RealityIndex { get; set; }
        public Galacticaddress3 GalacticAddress { get; set; }
    }

    public class Galacticaddress3
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Gamestartaddress2
    {
        public int RealityIndex { get; set; }
        public Galacticaddress4 GalacticAddress { get; set; }
    }

    public class Galacticaddress4
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Currentfreighter
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture1 ProceduralTexture { get; set; }
    }

    public class Proceduraltexture1
    {
        public object[] Samplers { get; set; }
    }

    public class Freighterlayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Freighterinventory
    {
        public Slot4[] Slots { get; set; }
        public Validslotindice4[] ValidSlotIndices { get; set; }
        public Class7 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue1[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class7
    {
        public string InventoryClass { get; set; }
    }

    public class Slot4
    {
        public Type4 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index4 Index { get; set; }
    }

    public class Type4
    {
        public string InventoryType { get; set; }
    }

    public class Index4
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice4
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue1
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Freighterinventory_Techonly
    {
        public Slot5[] Slots { get; set; }
        public Validslotindice5[] ValidSlotIndices { get; set; }
        public Class8 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue2[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class8
    {
        public string InventoryClass { get; set; }
    }

    public class Slot5
    {
        public Type5 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index5 Index { get; set; }
    }

    public class Type5
    {
        public string InventoryType { get; set; }
    }

    public class Index5
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice5
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue2
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Freighteruniverseaddress
    {
        public int RealityIndex { get; set; }
        public Galacticaddress5 GalacticAddress { get; set; }
    }

    public class Galacticaddress5
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Terraineditdata
    {
        public object[] GalacticAddresses { get; set; }
        public int[] BufferSizes { get; set; }
        public int[] BufferAges { get; set; }
        public float[][] BufferAnchors { get; set; }
        public bool[] BufferProtected { get; set; }
        public Edit[] Edits { get; set; }
    }

    public class Edit
    {
        public int Data { get; set; }
        public int Position { get; set; }
    }

    public class Chest1layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest1inventory
    {
        public Slot6[] Slots { get; set; }
        public Validslotindice6[] ValidSlotIndices { get; set; }
        public Class9 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class9
    {
        public string InventoryClass { get; set; }
    }

    public class Slot6
    {
        public Type6 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index6 Index { get; set; }
    }

    public class Type6
    {
        public string InventoryType { get; set; }
    }

    public class Index6
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice6
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest2layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest2inventory
    {
        public Slot7[] Slots { get; set; }
        public Validslotindice7[] ValidSlotIndices { get; set; }
        public Class10 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class10
    {
        public string InventoryClass { get; set; }
    }

    public class Slot7
    {
        public Type7 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index7 Index { get; set; }
    }

    public class Type7
    {
        public string InventoryType { get; set; }
    }

    public class Index7
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice7
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest3layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest3inventory
    {
        public Slot8[] Slots { get; set; }
        public Validslotindice8[] ValidSlotIndices { get; set; }
        public Class11 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class11
    {
        public string InventoryClass { get; set; }
    }

    public class Slot8
    {
        public Type8 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index8 Index { get; set; }
    }

    public class Type8
    {
        public string InventoryType { get; set; }
    }

    public class Index8
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice8
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest4layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest4inventory
    {
        public Slot9[] Slots { get; set; }
        public Validslotindice9[] ValidSlotIndices { get; set; }
        public Class12 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class12
    {
        public string InventoryClass { get; set; }
    }

    public class Slot9
    {
        public Type9 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index9 Index { get; set; }
    }

    public class Type9
    {
        public string InventoryType { get; set; }
    }

    public class Index9
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice9
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest5layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest5inventory
    {
        public object[] Slots { get; set; }
        public Validslotindice10[] ValidSlotIndices { get; set; }
        public Class13 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class13
    {
        public string InventoryClass { get; set; }
    }

    public class Validslotindice10
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest6layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest6inventory
    {
        public object[] Slots { get; set; }
        public Validslotindice11[] ValidSlotIndices { get; set; }
        public Class14 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class14
    {
        public string InventoryClass { get; set; }
    }

    public class Validslotindice11
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest7layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest7inventory
    {
        public Slot10[] Slots { get; set; }
        public Validslotindice12[] ValidSlotIndices { get; set; }
        public Class15 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class15
    {
        public string InventoryClass { get; set; }
    }

    public class Slot10
    {
        public Type10 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index10 Index { get; set; }
    }

    public class Type10
    {
        public string InventoryType { get; set; }
    }

    public class Index10
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice12
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest8layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest8inventory
    {
        public Slot11[] Slots { get; set; }
        public Validslotindice13[] ValidSlotIndices { get; set; }
        public Class16 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class16
    {
        public string InventoryClass { get; set; }
    }

    public class Slot11
    {
        public Type11 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index11 Index { get; set; }
    }

    public class Type11
    {
        public string InventoryType { get; set; }
    }

    public class Index11
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice13
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest9layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest9inventory
    {
        public Slot12[] Slots { get; set; }
        public Validslotindice14[] ValidSlotIndices { get; set; }
        public Class17 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class17
    {
        public string InventoryClass { get; set; }
    }

    public class Slot12
    {
        public Type12 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index12 Index { get; set; }
    }

    public class Type12
    {
        public string InventoryType { get; set; }
    }

    public class Index12
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice14
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chest10layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chest10inventory
    {
        public Slot13[] Slots { get; set; }
        public Validslotindice15[] ValidSlotIndices { get; set; }
        public Class18 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class18
    {
        public string InventoryClass { get; set; }
    }

    public class Slot13
    {
        public Type13 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index13 Index { get; set; }
    }

    public class Type13
    {
        public string InventoryType { get; set; }
    }

    public class Index13
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice15
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chestmagiclayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chestmagicinventory
    {
        public Slot14[] Slots { get; set; }
        public Validslotindice16[] ValidSlotIndices { get; set; }
        public Class19 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class19
    {
        public string InventoryClass { get; set; }
    }

    public class Slot14
    {
        public Type14 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index14 Index { get; set; }
    }

    public class Type14
    {
        public string InventoryType { get; set; }
    }

    public class Index14
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice16
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Chestmagic2layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Chestmagic2inventory
    {
        public object[] Slots { get; set; }
        public Validslotindice17[] ValidSlotIndices { get; set; }
        public Class20 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class20
    {
        public string InventoryClass { get; set; }
    }

    public class Validslotindice17
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Cookingingredientslayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Cookingingredientsinventory
    {
        public Slot15[] Slots { get; set; }
        public Validslotindice18[] ValidSlotIndices { get; set; }
        public Class21 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class21
    {
        public string InventoryClass { get; set; }
    }

    public class Slot15
    {
        public Type15 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index15 Index { get; set; }
    }

    public class Type15
    {
        public string InventoryType { get; set; }
    }

    public class Index15
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice18
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Currentfreighternpc
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture2 ProceduralTexture { get; set; }
    }

    public class Proceduraltexture2
    {
        public object[] Samplers { get; set; }
    }

    public class Visitedportal
    {
        public object[] PortalSeed { get; set; }
        public string LastPortalUA { get; set; }
    }

    public class Othersideofportalreturnbase
    {
        public Universeaddress1 UniverseAddress { get; set; }
        public float[] Position { get; set; }
        public float[] Facing { get; set; }
        public string TeleporterType { get; set; }
        public string Name { get; set; }
        public bool CalcWarpOffset { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Universeaddress1
    {
        public int RealityIndex { get; set; }
        public Galacticaddress6 GalacticAddress { get; set; }
    }

    public class Galacticaddress6
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Startingprimaryweapon
    {
        public string WeaponMode { get; set; }
    }

    public class Startingsecondaryweapon
    {
        public string WeaponMode { get; set; }
    }

    public class Multiplayerua
    {
        public int RealityIndex { get; set; }
        public Galacticaddress7 GalacticAddress { get; set; }
    }

    public class Galacticaddress7
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Multiplayerspawn
    {
        public float[] PlayerPositionInSystem { get; set; }
        public float[] PlayerTransformAt { get; set; }
        public float[] ShipPositionInSystem { get; set; }
        public float[] ShipTransformAt { get; set; }
        public string LastKnownPlayerState { get; set; }
        public float[] FreighterPositionInSystem { get; set; }
        public float[] FreighterTransformAt { get; set; }
        public float[] FreighterTransformUp { get; set; }
        public float[] AbandonedFreighterPositionInSystem { get; set; }
        public float[] AbandonedFreighterTransformAt { get; set; }
        public float[] AbandonedFreighterTransformUp { get; set; }
    }

    public class Nexusuniverseaddress
    {
        public int RealityIndex { get; set; }
        public Galacticaddress8 GalacticAddress { get; set; }
    }

    public class Galacticaddress8
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Photomodesettings
    {
        public float Fog { get; set; }
        public float CloudAmount { get; set; }
        public float[] SunDir { get; set; }
        public bool SunDirSet { get; set; }
        public float FoV { get; set; }
        public bool FoVSet { get; set; }
        public string DepthOfField { get; set; }
        public int DepthOfFieldStrengthSetting { get; set; }
        public float DepthOfFieldDistance { get; set; }
        public float DepthOfFieldDistanceSpace { get; set; }
        public float HalfFocalPlaneDepth { get; set; }
        public float HalfFocalPlaneDepthSpace { get; set; }
        public float Vignette { get; set; }
        public int Filter { get; set; }
    }

    public class Seasonaldata
    {
        public int StartTimeUTC { get; set; }
        public int EndTimeUTC { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public Gamemode GameMode { get; set; }
        public string SeasonalUAOverride { get; set; }
        public int UAOverrideValue { get; set; }
        public object[] WeaponSeed { get; set; }
        public object[] ShipSeed { get; set; }
        public Shiptype ShipType { get; set; }
        public bool StartNextToShip { get; set; }
        public bool ShipStartsDamaged { get; set; }
        public bool AllowMissionDetailMessages { get; set; }
        public object[] Milestones { get; set; }
        public object[] SecondaryStats { get; set; }
    }

    public class Gamemode
    {
        public string PresetGameMode { get; set; }
    }

    public class Shiptype
    {
        public string ShipClass { get; set; }
    }

    public class Multitool
    {
        public Layout Layout { get; set; }
        public Store Store { get; set; }
        public object[] Seed { get; set; }
        public string Name { get; set; }
        public bool IsLarge { get; set; }
        public int PrimaryMode { get; set; }
        public int SecondaryMode { get; set; }
    }

    public class Layout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Store
    {
        public Slot16[] Slots { get; set; }
        public Validslotindice19[] ValidSlotIndices { get; set; }
        public Class22 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue3[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class22
    {
        public string InventoryClass { get; set; }
    }

    public class Slot16
    {
        public Type16 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index16 Index { get; set; }
    }

    public class Type16
    {
        public string InventoryType { get; set; }
    }

    public class Index16
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice19
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue3
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Knownwordgroup
    {
        public string Group { get; set; }
        public bool[] Races { get; set; }
    }

    public class Missionprogress
    {
        public string Mission { get; set; }
        public int Progress { get; set; }
        public object Seed { get; set; }
        public int Data { get; set; }
        public Participant[] Participants { get; set; }
    }

    public class Participant
    {
        public object UA { get; set; }
        public object[] BuildingSeed { get; set; }
        public float[] BuildingLocation { get; set; }
        public Participanttype ParticipantType { get; set; }
    }

    public class Participanttype
    {
        public string ParticipantType { get; set; }
    }

    public class Missionrecurrence
    {
        public string MissionID { get; set; }
        public int RecurrenceDeadline { get; set; }
    }

    public class Markerstack
    {
        public int Table { get; set; }
        public string Event { get; set; }
        public object GalacticAddress { get; set; }
        public object[] BuildingSeed { get; set; }
        public float[] BuildingLocation { get; set; }
        public Buildingclass BuildingClass { get; set; }
        public float Time { get; set; }
        public string MissionID { get; set; }
        public int MissionSeed { get; set; }
        public Participanttype1 ParticipantType { get; set; }
    }

    public class Buildingclass
    {
        public string BuildingClass { get; set; }
    }

    public class Participanttype1
    {
        public string ParticipantType { get; set; }
    }

    public class Stat
    {
        public string GroupId { get; set; }
        public object Address { get; set; }
        public Stat1[] Stats { get; set; }
    }

    public class Stat1
    {
        public string Id { get; set; }
        public Value Value { get; set; }
    }

    public class Value
    {
        public int IntValue { get; set; }
        public float FloatValue { get; set; }
    }

    public class Telemetrystat
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
    }

    public class Storedinteraction
    {
        public Interaction[] Interactions { get; set; }
        public int CurrentPos { get; set; }
    }

    public class Interaction
    {
        public object GalacticAddress { get; set; }
        public int Value { get; set; }
        public float[] Position { get; set; }
    }

    public class Maintenanceinteraction
    {
        public Inventorycontainer InventoryContainer { get; set; }
        public int LastUpdateTimestamp { get; set; }
        public int LastCompletedTimestamp { get; set; }
        public int LastBrokenTimestamp { get; set; }
        public float?[] DamageTimers { get; set; }
        public int Flags { get; set; }
    }

    public class Inventorycontainer
    {
        public Slot17[] Slots { get; set; }
        public object[] ValidSlotIndices { get; set; }
        public Class23 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class23
    {
        public string InventoryClass { get; set; }
    }

    public class Slot17
    {
        public Type17 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index17 Index { get; set; }
    }

    public class Type17
    {
        public string InventoryType { get; set; }
    }

    public class Index17
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Personalmaintenanceinteraction
    {
        public Inventorycontainer1 InventoryContainer { get; set; }
        public int LastUpdateTimestamp { get; set; }
        public int LastCompletedTimestamp { get; set; }
        public int LastBrokenTimestamp { get; set; }
        public float[] DamageTimers { get; set; }
        public int Flags { get; set; }
    }

    public class Inventorycontainer1
    {
        public Slot18[] Slots { get; set; }
        public object[] ValidSlotIndices { get; set; }
        public Class24 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class24
    {
        public string InventoryClass { get; set; }
    }

    public class Slot18
    {
        public Type18 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index18 Index { get; set; }
    }

    public class Type18
    {
        public string InventoryType { get; set; }
    }

    public class Index18
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Savedinteractionindicy
    {
        public int[] SavedRaceIndicies { get; set; }
    }

    public class Savedinteractiondialogtable
    {
        public string Hash { get; set; }
        public string Dialog { get; set; }
    }

    public class Atlasstationadressdata
    {
        public int RealityIndex { get; set; }
        public Galacticaddress9 GalacticAddress { get; set; }
    }

    public class Galacticaddress9
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Newatlasstationadressdata
    {
        public int RealityIndex { get; set; }
        public Galacticaddress10 GalacticAddress { get; set; }
    }

    public class Galacticaddress10
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Visitedatlasstationsdata
    {
        public int RealityIndex { get; set; }
        public Galacticaddress11 GalacticAddress { get; set; }
    }

    public class Galacticaddress11
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Basebuildingobject
    {
        public int Timestamp { get; set; }
        public string ObjectID { get; set; }
        public object GalacticAddress { get; set; }
        public string RegionSeed { get; set; }
        public int UserData { get; set; }
        public float[] Position { get; set; }
        public float[] Up { get; set; }
        public float[] At { get; set; }
    }

    public class Npcworker
    {
        public Resourceelement ResourceElement { get; set; }
        public object[] InteractionSeed { get; set; }
        public bool HiredWorker { get; set; }
        public bool FreighterBase { get; set; }
        public string BaseUA { get; set; }
        public float[] BaseOffset { get; set; }
    }

    public class Resourceelement
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture3 ProceduralTexture { get; set; }
    }

    public class Proceduraltexture3
    {
        public object[] Samplers { get; set; }
    }

    public class Persistentplayerbas
    {
        public int BaseVersion { get; set; }
        public int OriginalBaseVersion { get; set; }
        public object GalacticAddress { get; set; }
        public float[] Position { get; set; }
        public float[] Forward { get; set; }
        public int UserData { get; set; }
        public int LastUpdateTimestamp { get; set; }
        public Object[] Objects { get; set; }
        public string RID { get; set; }
        public Owner Owner { get; set; }
        public string Name { get; set; }
        public Basetype BaseType { get; set; }
        public string LastEditedById { get; set; }
        public string LastEditedByUsername { get; set; }
        public float[] ScreenshotAt { get; set; }
        public float[] ScreenshotPos { get; set; }
        public Gamemode1 GameMode { get; set; }
        public string PlatformToken { get; set; }
        public bool IsReported { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Owner
    {
        public string LID { get; set; }
        public string UID { get; set; }
        public string USN { get; set; }
        public string PTK { get; set; }
        public int TS { get; set; }
    }

    public class Basetype
    {
        public string PersistentBaseTypes { get; set; }
    }

    public class Gamemode1
    {
        public string PresetGameMode { get; set; }
    }

    public class Object
    {
        public int Timestamp { get; set; }
        public string ObjectID { get; set; }
        public long UserData { get; set; }
        public float[] Position { get; set; }
        public float[] Up { get; set; }
        public float[] At { get; set; }
        public string Message { get; set; }
    }

    public class Teleportendpoint
    {
        public Universeaddress2 UniverseAddress { get; set; }
        public float[] Position { get; set; }
        public float[] Facing { get; set; }
        public string TeleporterType { get; set; }
        public string Name { get; set; }
        public bool CalcWarpOffset { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Universeaddress2
    {
        public int RealityIndex { get; set; }
        public Galacticaddress12 GalacticAddress { get; set; }
    }

    public class Galacticaddress12
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Vehicleownership
    {
        public string Name { get; set; }
        public Resource Resource { get; set; }
        public Inventory1 Inventory { get; set; }
        public Inventory_Techonly1 Inventory_TechOnly { get; set; }
        public Inventorylayout InventoryLayout { get; set; }
        public object Location { get; set; }
        public float[] Position { get; set; }
        public float[] Direction { get; set; }
    }

    public class Resource
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture4 ProceduralTexture { get; set; }
    }

    public class Proceduraltexture4
    {
        public object[] Samplers { get; set; }
    }

    public class Inventory1
    {
        public Slot19[] Slots { get; set; }
        public Validslotindice20[] ValidSlotIndices { get; set; }
        public Class25 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class25
    {
        public string InventoryClass { get; set; }
    }

    public class Slot19
    {
        public Type19 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index19 Index { get; set; }
    }

    public class Type19
    {
        public string InventoryType { get; set; }
    }

    public class Index19
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice20
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Inventory_Techonly1
    {
        public object[] Slots { get; set; }
        public object[] ValidSlotIndices { get; set; }
        public Class26 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public object[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class26
    {
        public string InventoryClass { get; set; }
    }

    public class Inventorylayout
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Shipownership
    {
        public string Name { get; set; }
        public Resource1 Resource { get; set; }
        public Inventory2 Inventory { get; set; }
        public Inventory_Techonly2 Inventory_TechOnly { get; set; }
        public Inventorylayout1 InventoryLayout { get; set; }
        public int Location { get; set; }
        public float[] Position { get; set; }
        public float[] Direction { get; set; }
    }

    public class Resource1
    {
        public string Filename { get; set; }
        public object[] Seed { get; set; }
        public string AltId { get; set; }
        public Proceduraltexture5 ProceduralTexture { get; set; }
    }

    public class Proceduraltexture5
    {
        public object[] Samplers { get; set; }
    }

    public class Inventory2
    {
        public Slot20[] Slots { get; set; }
        public Validslotindice21[] ValidSlotIndices { get; set; }
        public Class27 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue4[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class27
    {
        public string InventoryClass { get; set; }
    }

    public class Slot20
    {
        public Type20 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index20 Index { get; set; }
    }

    public class Type20
    {
        public string InventoryType { get; set; }
    }

    public class Index20
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice21
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue4
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Inventory_Techonly2
    {
        public Slot21[] Slots { get; set; }
        public Validslotindice22[] ValidSlotIndices { get; set; }
        public Class28 Class { get; set; }
        public int SubstanceMaxStorageMultiplier { get; set; }
        public int ProductMaxStorageMultiplier { get; set; }
        public Basestatvalue5[] BaseStatValues { get; set; }
        public object[] SpecialSlots { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsCool { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }

    public class Class28
    {
        public string InventoryClass { get; set; }
    }

    public class Slot21
    {
        public Type21 Type { get; set; }
        public string Id { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }
        public float DamageFactor { get; set; }
        public bool FullyInstalled { get; set; }
        public Index21 Index { get; set; }
    }

    public class Type21
    {
        public string InventoryType { get; set; }
    }

    public class Index21
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Validslotindice22
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Basestatvalue5
    {
        public string BaseStatID { get; set; }
        public float Value { get; set; }
    }

    public class Inventorylayout1
    {
        public int Slots { get; set; }
        public object[] Seed { get; set; }
        public int Level { get; set; }
    }

    public class Tradingsupplydata
    {
        public object GalacticAddress { get; set; }
        public float Supply { get; set; }
        public float Demand { get; set; }
        public string Product { get; set; }
        public int Timestamp { get; set; }
    }

    public class Charactercustomisationdata
    {
        public string SelectedPreset { get; set; }
        public Customdata CustomData { get; set; }
    }

    public class Customdata
    {
        public string[] DescriptorGroups { get; set; }
        public Colour[] Colours { get; set; }
        public Textureoption[] TextureOptions { get; set; }
        public Bonescale[] BoneScales { get; set; }
        public float Scale { get; set; }
    }

    public class Colour
    {
        public Palette Palette { get; set; }
        public float[] Colour { get; set; }
    }

    public class Palette
    {
        public string Palette { get; set; }
        public string ColourAlt { get; set; }
    }

    public class Textureoption
    {
        public string TextureOptionGroupName { get; set; }
        public string TextureOptionName { get; set; }
    }

    public class Bonescale
    {
        public string BoneName { get; set; }
        public float Scale { get; set; }
    }

    public class Outfit
    {
        public string[] DescriptorGroups { get; set; }
        public Colour1[] Colours { get; set; }
        public Textureoption1[] TextureOptions { get; set; }
        public Bonescale1[] BoneScales { get; set; }
        public float Scale { get; set; }
    }

    public class Colour1
    {
        public Palette1 Palette { get; set; }
        public float[] Colour { get; set; }
    }

    public class Palette1
    {
        public string Palette { get; set; }
        public string ColourAlt { get; set; }
    }

    public class Textureoption1
    {
        public string TextureOptionGroupName { get; set; }
        public string TextureOptionName { get; set; }
    }

    public class Bonescale1
    {
        public string BoneName { get; set; }
        public float Scale { get; set; }
    }

    public class Fleetfrigate
    {
        public object[] ResourceSeed { get; set; }
        public object[] HomeSystemSeed { get; set; }
        public int TimeOfLastIncomeCollection { get; set; }
        public string CustomName { get; set; }
        public Frigateclass FrigateClass { get; set; }
        public Race Race { get; set; }
        public int TotalNumberOfExpeditions { get; set; }
        public int TotalNumberOfSuccessfulEvents { get; set; }
        public int TotalNumberOfFailedEvents { get; set; }
        public int NumberOfTimesDamaged { get; set; }
        public string[] TraitIDs { get; set; }
        public int[] Stats { get; set; }
        public int RepairsMade { get; set; }
        public int DamageTaken { get; set; }
    }

    public class Frigateclass
    {
        public string FrigateClass { get; set; }
    }

    public class Race
    {
        public string AlienRace { get; set; }
    }

    public class Hotaction
    {
        public Keyaction[] KeyActions { get; set; }
    }

    public class Keyaction
    {
        public Action Action { get; set; }
        public string Id { get; set; }
        public int Number { get; set; }
        public Inventoryindex InventoryIndex { get; set; }
    }

    public class Action
    {
        public string QuickMenuActions { get; set; }
    }

    public class Inventoryindex
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class SpawnData
    {
        public float[] PlayerPositionInSystem { get; set; }
        public float[] PlayerTransformAt { get; set; }
        public float[] ShipPositionInSystem { get; set; }
        public float[] ShipTransformAt { get; set; }
        public string LastKnownPlayerState { get; set; }
        public float[] FreighterPositionInSystem { get; set; }
        public float[] FreighterTransformAt { get; set; }
        public float[] FreighterTransformUp { get; set; }
        public float[] AbandonedFreighterPositionInSystem { get; set; }
        public float[] AbandonedFreighterTransformAt { get; set; }
        public float[] AbandonedFreighterTransformUp { get; set; }
    }

    public class KnowledgeData
    {
        public Waypoint[] Waypoints { get; set; }
    }

    public class Waypoint
    {
        public Address Address { get; set; }
        public Type22 Type { get; set; }
        public string EventId { get; set; }
    }

    public class Address
    {
        public int VoxelX { get; set; }
        public int VoxelY { get; set; }
        public int VoxelZ { get; set; }
        public int SolarSystemIndex { get; set; }
        public int PlanetIndex { get; set; }
    }

    public class Type22
    {
        public string GalaxyWaypointType { get; set; }
    }

    public class DiscoveryData
    {
        public DiscoverydataV1 DiscoveryDatav1 { get; set; }
    }

    public class DiscoverydataV1
    {
        public int ReserveStore { get; set; }
        public int ReserveManaged { get; set; }
        public Store1 Store { get; set; }
        public Available[] Available { get; set; }
        public object[] Enqueued { get; set; }
    }

    public class Store1
    {
        public Record[] Record { get; set; }
    }

    public class Record
    {
        public DD DD { get; set; }
        public DM DM { get; set; }
        public OWS OWS { get; set; }
        public FL FL { get; set; }
        public string RID { get; set; }
        public string PTK { get; set; }
    }

    public class DD
    {
        public object UA { get; set; }
        public string DT { get; set; }
        public object[] VP { get; set; }
    }

    public class DM
    {
        public string CN { get; set; }
    }

    public class OWS
    {
        public string LID { get; set; }
        public string UID { get; set; }
        public string USN { get; set; }
        public string PTK { get; set; }
        public int TS { get; set; }
    }

    public class FL
    {
        public int C { get; set; }
        public int Unknown { get; set; }
    }

    public class Available
    {
        public int TSrec { get; set; }
        public DD1 DD { get; set; }
    }

    public class DD1
    {
        public object UA { get; set; }
        public string DT { get; set; }
        public object[] VP { get; set; }
    }

}
