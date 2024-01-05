using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCmod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class ChangeJumpPatch
    { 

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void JumpForcePatch(ref float ___jumpForce)
        {
            ___jumpForce = 200f;
        }

    }
}
