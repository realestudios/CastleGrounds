using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Steamworks.Ugc;
using System.IO;
using System.Reflection;
using Unity.Netcode;
using UnityEngine;
using LethalLib;
using LethalLib.Modules;

namespace CastleGrounds
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        const string GUID = "CastleGrounds";
        const string NAME = "CastleGrounds";
        const string VERSION = "5.3.0";

        public static Plugin instance;

        void Awake()
        {
            instance = this;

            string assetDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "castlegroundsscrap");
            AssetBundle bundle = AssetBundle.LoadFromFile(assetDir);

            // Star Apparatus scrap

            Item CGStarAppItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/StarApparatus/CGStarAppItem.asset");
            LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGStarAppItem.spawnPrefab);
            LethalLib.Modules.Utilities.FixMixerGroups(CGStarAppItem.spawnPrefab);
            Items.RegisterScrap(CGStarAppItem, 20, Levels.LevelTypes.None);

            // Regular scrap disabled as they are now registered through LethalLevelLoader

            // Star scrap

            //Item CGStarItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Star/CGStarItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGStarItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGStarItem.spawnPrefab);
            //Items.RegisterScrap(CGStarItem, 20, Levels.LevelTypes.None);

            // Coin scrap

            //Item CGCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Coins/CGCoinItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGCoinItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGCoinItem.spawnPrefab);
            //Items.RegisterScrap(CGCoinItem, 20, Levels.LevelTypes.None);

            // Red Coin Scrap

            //Item CGRedCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Coins/CGRedCoinItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGRedCoinItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGRedCoinItem.spawnPrefab);
            //Items.RegisterScrap(CGRedCoinItem, 20, Levels.LevelTypes.None);

            // Blue Coin Scrap

            //Item CGBlueCoinItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Coins/CGBlueCoinItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGBlueCoinItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGBlueCoinItem.spawnPrefab);
            //Items.RegisterScrap(CGBlueCoinItem, 20, Levels.LevelTypes.None);

            // Koopa Shell Scrap

            //Item CGShellItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Shell/CGShellItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGShellItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGShellItem.spawnPrefab);
            //Items.RegisterScrap(CGShellItem, 20, Levels.LevelTypes.None);

            // ? Block Scrap

            //Item CGQBlockItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Q_Block/CGQBlockItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGQBlockItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGQBlockItem.spawnPrefab);
            //Items.RegisterScrap(CGQBlockItem, 20, Levels.LevelTypes.None);

            // Bob-Omb Scrap

            //Item CGBobOmbItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/bob-omb/CGBobOmbItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGBobOmbItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGBobOmbItem.spawnPrefab);
            //Items.RegisterScrap(CGBobOmbItem, 20, Levels.LevelTypes.None);

            // Cap Scrap

            //Item CGCapItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Cap/CGCapItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGCapItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGCapItem.spawnPrefab);
            //Items.RegisterScrap(CGCapItem, 20, Levels.LevelTypes.None);

            // MIPS Scrap

            //Item CGMIPSItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/MIPS/CGMIPSItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGMIPSItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGMIPSItem.spawnPrefab);
            //Items.RegisterScrap(CGMIPSItem, 20, Levels.LevelTypes.None);

            // 1Up Scrap

            //Item CGOneUpItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/1Up/CGOneUpItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGOneUpItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGOneUpItem.spawnPrefab);
            //Items.RegisterScrap(CGOneUpItem, 20, Levels.LevelTypes.None);

            // Bowser Key Scrap

            //Item CGBowserKeyItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/BowserKey/CGBowserKeyItem.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGBowserKeyItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGBowserKeyItem.spawnPrefab);
            //Items.RegisterScrap(CGBowserKeyItem, 20, Levels.LevelTypes.None);

            // Paintings Scrap

            //Item CGPaintingItem = bundle.LoadAsset<Item>("Assets/LethalCompany/Mods/CastleGrounds/Scrap/Paintings/FancyPaintingCG.asset");
            //LethalLib.Modules.NetworkPrefabs.RegisterNetworkPrefab(CGPaintingItem.spawnPrefab);
            //LethalLib.Modules.Utilities.FixMixerGroups(CGPaintingItem.spawnPrefab);
            //Items.RegisterScrap(CGPaintingItem, 20, Levels.LevelTypes.None);

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
            Logger.LogInfo("Star Apparatus Active");
        }
    }

}
