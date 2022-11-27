using HarmonyLib;
using MelonLoader;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using SLZ.SaveData;
using System;

namespace PhysicalCrouchingFix
{
    public static class BuildInfo
    {
        public const string Name = "PhysicalCrouchingFix"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Adi"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class PhysicalCrouchingFix : MelonMod
    {
        public static bool error = false;
        public static void ChangeCrouchLimit(ControllerRig controllerRig)
        {
            if (error)
                return;
            //prevents wacky shit if an update breaks the mod
            try{
                controllerRig._crouchLimit = (MarrowGame.xr.HMD != null && MarrowGame.xr.HMD.Position.y < DataManager.ActiveSave.PlayerSettings.PlayerHeight * 0.7f) ? 1f : controllerRig._crouchLimit;
            }
            catch(TypeLoadException e)
            {
                error = true;
                MelonLogger.Error(e);
            }
        }
        [HarmonyPatch(typeof(ControllerRig), nameof(ControllerRig.ApplyMovement))]
        public static class RigPatch
        {
            public static void Prefix(ControllerRig __instance) => ChangeCrouchLimit(__instance);
            public static void Postfix(ControllerRig __instance) => ChangeCrouchLimit(__instance);
        }
    }
}
