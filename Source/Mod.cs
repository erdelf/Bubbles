﻿using Harmony;
using Verse;

namespace Bubbles
{
    [StaticConstructorOnStartup]
    internal static class Mod
    {
        public const string Id = "Bubbles";
        public const string Name = "Bubbles";
        public const string Version = "1.5";

        static Mod()
        {
            HarmonyInstance.Create(Id).PatchAll();
            Log("Initialized");
        }

        public static void Log(string message) => Verse.Log.Message(PrefixMessage(message));
        private static string PrefixMessage(string message) => $"[{Name} v{Version}] {message}";

        public class Exception : System.Exception
        {
            public Exception(string message) : base(PrefixMessage(message))
            { }
        }
    }
}
