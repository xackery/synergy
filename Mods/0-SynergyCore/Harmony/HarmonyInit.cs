using DMT;
using HarmonyLib;
using System.Reflection;
using UnityEngine;

public class SynergyCore_Init : IHarmony
{
    public void Start()
    {
        Debug.Log(" Loading Synergy Core Patch: " + GetType().ToString());

        // Reduce extra logging stuff
        Application.SetStackTraceLogType(UnityEngine.LogType.Log, StackTraceLogType.None);
        Application.SetStackTraceLogType(UnityEngine.LogType.Warning, StackTraceLogType.None);

        var harmony = new Harmony(GetType().ToString());
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}



