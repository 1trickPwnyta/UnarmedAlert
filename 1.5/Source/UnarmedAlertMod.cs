using Verse;

namespace UnarmedAlert
{
    public class UnarmedAlertMod : Mod
    {
        public const string PACKAGE_ID = "unarmedalert.1trickPwnyta";
        public const string PACKAGE_NAME = "Unarmed Alert";

        public UnarmedAlertMod(ModContentPack content) : base(content)
        {
            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
