using MelonLoader;
using RumbleModdingAPI;

namespace RumbleMod2
{
    public static class BuildInfo
    {
        public const string Name = "NoMute"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "no more muting people on accident"; // Description for the Mod.  (Set as null if none)
        public const string Author = "rdm8417"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class NoMute : MelonMod
    {
        private bool loaded;
        
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "Gym" && !loaded)
            {
                loaded = true;
                
                MelonLogger.Msg("NoMute initialized");
            
                Calls.Managers.GetInputManager().mutePlayerActionName = "whatever";
            
                MelonLogger.Msg("NoMute active");
            }
        }
    }
}