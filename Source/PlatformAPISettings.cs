using System;
using Steamworks;

namespace Hacknet
{
    public static class PlatformAPISettings
    {
        public static string Report = "";
        public static bool Running;
        public static bool RemoteStorageRunning;

        public static void InitPlatformAPI()
        {
            if (Settings.isConventionDemo)
                return;
            // Steam disabled - use local storage only
            Running = false;
            RemoteStorageRunning = false;
            Report = "Steam API Disabled";
        }
    }
}