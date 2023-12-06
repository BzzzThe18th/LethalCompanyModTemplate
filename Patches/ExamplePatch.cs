using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace LethalCompanyModTemplate.Patches
{
    /*
        this is a harmony patch
        harmony patches can replace runs of for example, methods
        this example shows logging info given when a boombox is started
    
        documentation: https://harmony.pardeike.net/articles/patching.html
    */
    [HarmonyPatch(typeof(BoomboxItem), "StartMusic", MethodType.Normal)]
    internal class ExamplePatch
    {
        internal static void Postfix(BoomboxItem __instance, bool startMusic, bool pitchDown = false)
        {
            Debug.Log($"Started a Boombox\nstartMusic:{startMusic}\npitchDown:{pitchDown}");
        }
    }
}