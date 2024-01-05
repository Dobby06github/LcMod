using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using LCmod.Patches;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace LCmod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin
    {
        private const string modGUID = "Mordi.LCmod";
        private const string modName = "LC mod";
        private const string modVersion = "10.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ModBase Instance;

        internal ManualLogSource mls;

        void Awake()

        {
            if (Instance  == null)
            {
                Instance = this;
            }
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The test mod started ");
            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(FlashlightItemPatch));
            harmony.PatchAll(typeof(playerControllerBPatch));
            harmony.PatchAll(typeof(nodamagepatch));
        }

    }


}
