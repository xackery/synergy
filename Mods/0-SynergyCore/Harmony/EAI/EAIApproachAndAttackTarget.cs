using HarmonyLib;
using UnityEngine;
class SynergyCore_EAIApproachAndAttackTarget_Tweaks
{
    [HarmonyPatch(typeof(EAIApproachAndAttackTarget))]
    [HarmonyPatch("Start")]
    public class Synergy_EAIApproachAndAttackTarget_Start {
		/*static bool Prefix(bool result, EAIApproachAndAttackTarget instance, EntityAlive e) {
			Debug.Log("start called for synergy core on entity"+instance.theEntity.entityId);			
			return true;
		}*/
		static bool Prefix(EAIApproachAndAttackTarget __instance) {
			Debug.Log("start called for synergy core on entity " + __instance.theEntity.entityId);
			//if (__instance.theEntity.entityId % 2 == 2) return false;
			return true;
		}
    }

	[HarmonyPatch(typeof(EAIApproachAndAttackTarget))]
    [HarmonyPatch("Update")]
    public class Synergy_EAIApproachAndAttackTarget_Update {
		static bool Prefix(EAIApproachAndAttackTarget __instance) {
			//if (__instance.theEntity.entityId % 2 == 2) return false;
			return true;
		}
    }
}

