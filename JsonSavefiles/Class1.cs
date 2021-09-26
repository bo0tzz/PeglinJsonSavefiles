using System;
using System.Collections.Generic;
using System.Linq;
using BepInEx;
using HarmonyLib;

namespace JsonSavefiles
{
    [BepInPlugin(modGuid, modName, modVersion)]
    [BepInProcess("Peglin.exe")]
    public class JsonSavefiles : BaseUnityPlugin
    {
        private const string modGuid = "me.bo0tzz.peglinmods.jsonsavefiles";
        private const string modName = "JSON Savefiles for Peglin";
        private const string modVersion = "1.0.0.0";
        private readonly Harmony harmony = new Harmony(modGuid);

        void Awake()
        {
            harmony.PatchAll();
            Logger.LogInfo("JsonSavefiles mod loaded");
        }
    }
}
