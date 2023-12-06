using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;

namespace LethalCompanyModTemplate
{
    public class ModInfo
    {
        public const string name = "Unnamed Mod";
        public const string guid = "author.unnamedmod";
        public const string version = "1.0.0";
    }

    [BepInPlugin(ModInfo.guid, ModInfo.name, ModInfo.version)]
    public class Main : BaseUnityPlugin
    {
        private Harmony harmonyInstance = new Harmony(ModInfo.guid);

        void Awake() {
            Logger.LogInfo($"Reached awake point for {ModInfo.name}@{ModInfo.version}, applying patches");
            /*
                this applies all harmony patches, to unpatch, use harmonyInstance.UnpatchSelf()
                this template includes an example patch to learn from
            */
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
            Logger.LogInfo("Applied patches");
        }
    }
}
