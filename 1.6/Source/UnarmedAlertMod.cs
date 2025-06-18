using UnityEngine;
using Verse;

namespace UnarmedAlert
{
    public class UnarmedAlertMod : Mod
    {
        public const string PACKAGE_ID = "unarmedalert.1trickPwnyta";
        public const string PACKAGE_NAME = "Unarmed Alert";

        public static UnarmedAlertSettings Settings;

        public UnarmedAlertMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<UnarmedAlertSettings>();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }

        public override string SettingsCategory() => PACKAGE_NAME;

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            UnarmedAlertSettings.DoSettingsWindowContents(inRect);
        }
    }
}
