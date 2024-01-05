using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LCmod.Patches
{
    [HarmonyPatch(typeof(FlashlightItem))]
    internal class FlashlightItemPatch
    {
        private static FieldInfo flashlightBulbField = AccessTools.Field(typeof(FlashlightItem), "flashlightBulb");


        [HarmonyPatch("Update")]
        [HarmonyPostfix]

        public static void Red(FlashlightItem __instance)

        {
            if (flashlightBulbField != null)
            {
                Light flashlightbulb = (Light)flashlightBulbField.GetValue(__instance);
                if (flashlightbulb != null)
                {
                    flashlightbulb.color = Color.magenta;
                }
            }



        }
    }

}
