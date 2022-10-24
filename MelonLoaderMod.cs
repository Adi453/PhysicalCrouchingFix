using HarmonyLib;
using MelonLoader;
using SLZ.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;

namespace PhysicalCrouchingFix
{
    public static class BuildInfo
    {
        public const string Name = "PhysicalCrouchingFix"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Adi"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class PhysicalCrouchingFix : MelonMod
    {
        [HarmonyPatch(typeof(ControllerRig), nameof(ControllerRig.ApplyMovement))]
        public static class RigPatch
        {
            public static void Prefix(ControllerRig __instance) => __instance._crouchLimit = (MarrowGame.xr.HMD != null && MarrowGame.xr.HMD.Position.y < DataManager.ActiveSave.PlayerSettings.PlayerHeight * 0.7f) ? 1f : __instance._crouchLimit;
            public static void Postfix(ControllerRig __instance) => __instance._crouchLimit = (MarrowGame.xr.HMD != null && MarrowGame.xr.HMD.Position.y < DataManager.ActiveSave.PlayerSettings.PlayerHeight * 0.7f) ? 1f : __instance._crouchLimit;
        }
    }
}
