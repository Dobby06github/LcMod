using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LCmod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]

    internal class nodamagepatch
    {

        [HarmonyPatch("Update")]
        [HarmonyPrefix]

        public void DamagePlayer(ref int ___damageNumber)
        {
             ___damageNumber = 0;
           
            return;

        }
        


    }


}