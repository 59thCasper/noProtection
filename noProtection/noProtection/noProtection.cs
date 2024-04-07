using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace noProtection
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class noProtection : BaseUnityPlugin
    {
        private const string MyGUID = "com.casper.noProtection";
        private const string PluginName = "noProtection";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);


        private void Awake()
        {
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();
        }
    }
}
