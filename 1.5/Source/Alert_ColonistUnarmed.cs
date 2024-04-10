using RimWorld;
using RimWorld.Planet;
using System.Collections.Generic;
using Verse;

namespace UnarmedAlert
{
    public class Alert_ColonistUnarmed : Alert
    {
        private List<Pawn> GetCulprits()
        {
            List<Pawn> culprits = new List<Pawn>();
            PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_FreeColonists.ForEach(pawn => 
            {
                if (pawn.equipment.Primary == null && (pawn.Spawned || pawn.IsCaravanMember()) && (UnarmedAlertSettings.IncludeGuests || (!pawn.HasExtraMiniFaction() && !pawn.HasExtraHomeFaction())) && !pawn.Downed && !pawn.WorkTagIsDisabled(WorkTags.Violent) && (UnarmedAlertSettings.IncludeSlaves || !pawn.IsSlave)) culprits.Add(pawn);
            });
            return culprits;
        }

        public Alert_ColonistUnarmed()
        {
            this.defaultLabel = "UnarmedAlert_ColonistUnarmed".Translate();
            this.defaultExplanation = "UnarmedAlert_ColonistUnarmedDesc".Translate();
            this.defaultPriority = AlertPriority.High;
        }

        public override AlertReport GetReport()
        {
            return AlertReport.CulpritsAre(GetCulprits());
        }
    }
}
