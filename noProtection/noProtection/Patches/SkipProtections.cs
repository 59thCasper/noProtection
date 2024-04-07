using HarmonyLib;
using UnityEngine;
using static noProtection.noProtection;

namespace noProtection.Patches
{
    [HarmonyPatch(typeof(GridManager), "RegisterProtectedZone")]
    public static class SkipRegisterProtectedZonePatch
    {
        [HarmonyPrefix] 
        public static bool Prefix()
        {

            return false; 
        }

        [HarmonyPatch(typeof(VoxelManager), "RegisterProtectedVoxels")]
        public static class SkipRegisterProtectedVoxelsPatch
        {
            [HarmonyPrefix] 
            public static bool Prefix()
            {
                return false; 
            }
        }

        [HarmonyPatch(typeof(CommonMachineInfo), "canErase", MethodType.Getter)]
        public static class AlwaysCanErasePatch
        {
            [HarmonyPostfix] 
            public static void Postfix(ref bool __result)
            {
                __result = true; 
            }
        }
    }
}
