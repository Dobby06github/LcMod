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
    [HarmonyPatch(typeof(PlayerControllerB))]

    internal class playerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void jumpPatch(ref float ___jumpForce, ref float ___movementSpeed, ref float ___climbSpeed)
        {
            ___jumpForce = 50f;
            ___movementSpeed = 50f;
            ___climbSpeed = 100f;
        }
    }

}
