using RimWorld;
using UnityEngine;
using Verse;

namespace UnarmedAlert
{
    public class UnarmedAlertSettings : ModSettings
    {
        public static bool IncludeGuests = false;
        public static bool IncludeSlaves = false;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();

            listingStandard.Begin(inRect);

            listingStandard.CheckboxLabeled("UnarmedAlert_IncludeGuests".Translate(), ref IncludeGuests);
            if (ModsConfig.IdeologyActive)
            {
                listingStandard.CheckboxLabeled("UnarmedAlert_IncludeSlaves".Translate(), ref IncludeSlaves);
            }

            listingStandard.End();
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref IncludeGuests, "IncludeGuests");
            Scribe_Values.Look(ref IncludeSlaves, "IncludeSlaves");
        }
    }
}
