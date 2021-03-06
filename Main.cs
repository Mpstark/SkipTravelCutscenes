﻿using Harmony;
using System.Reflection;

// ReSharper disable UnusedMember.Global

namespace SkipTravelCutscenes
{
    public static class Main
    {
        public static void Init(string modDir, string modSettings)
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.SkipTravelCutscenes");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
