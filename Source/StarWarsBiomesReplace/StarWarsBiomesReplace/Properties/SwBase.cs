using UnityEngine;
using Verse;

namespace starWarsBiomes
{
    public class StarWarsBiomes : Mod
    {
        private Swsettings settings;
        base..ctor();

        public StarWarsBiomes(ModContentPack content)
        {
            
            this.settings = (Swsettings)this.GetSettings<Swsettings>();
        }

        public virtual void DoSettingsWindowContents(Rect inRect)
        {
            ((Rect)ref inRect).set_width(450f);
            Listing_Standard listingStandard = new Listing_Standard();
            ((Listing)listingStandard).Begin(inRect);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxMeadow")), ref Swsettings.spawnAlpineMeadow, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxDunes")), ref Swsettings.spawnCoastalDunes, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxOasis")), ref Swsettings.spawnDesertOasis, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxGrasslands")), ref Swsettings.spawnGrasslands, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxIceberg")), ref Swsettings.spawnIceberg, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxMarsh")), ref Swsettings.spawnMarsh, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxCloudForest")), ref Swsettings.spawnCloudForest, (string)null);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxSandbar")), ref Swsettings.spawnSandbar, (string)null);
            ((Listing)listingStandard).GapLine(12f);
            listingStandard.CheckboxLabeled(TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxModdedThings")), ref Swsettings.spawnModdedPlantsAnimals, TaggedString.op_Implicit(Translator.Translate("ZB_CheckboxModdedThingsDesc")));
            ((Listing)listingStandard).End();
            base.DoSettingsWindowContents(inRect);
        }

        public virtual string SettingsCategory() => TaggedString.op_Implicit(Translator.Translate("ZB_ModName"));
    }
}