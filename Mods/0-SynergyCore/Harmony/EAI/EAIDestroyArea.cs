using HarmonyLib;
using UnityEngine;
class SynergyCore_EAIDestroyArea_Tweaks
{
    [HarmonyPatch(typeof(EntityMoveHelper))]
    [HarmonyPatch("CalcIfUnreachablePos")]
    public class Synergy_EntityMoveHelper_CalcIfUnreachablePos {
		static bool Prefix(EntityMoveHelper __instance) {
			__instance.IsUnreachableSide = true;
			__instance.IsUnreachableSideJump = true;
			return false;
		}
    }
}

