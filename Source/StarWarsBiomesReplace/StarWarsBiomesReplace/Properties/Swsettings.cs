using system;
using Verse;

namespace starWarsBiomes
{
     public class Swsettings : ModSettings
    {
        

        public static bool spawnAlpineMeadow = true;
        public static bool spawnCoastalDunes = true;
        public static bool spawnDesertOasis = true;
        public static bool spawnGrasslands = true;
        public static bool spawnIceberg = true;
        public static bool spawnMarsh = true;
        public static bool spawnCloudForest = true;
        public static bool spawnModdedPlantsAnimals = true;
        public static bool spawnSandbar = true;

        public virtual void ExposeData()
        {
    
            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnAlpineMeadow, "spawnAlpineMeadow", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnCoastalDunes, "spawnCoastalDunes", (M0 )1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnDesertOasis, "spawnDesertOasis", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnGrasslands, "spawnGrasslands", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnIceberg, "spawnIceberg", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnMarsh, "spawnMarsh", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnCloudForest, "spawnCloudForest", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnModdedPlantsAnimals, "spawnModdedPlantsAnimals", (M0) 1, false);

            Scribe_Values.Look<bool>((M0&) ref Swsettings.spawnSandbar, "spawnSandbar", (M0) 1, false);
        }
            public Swsettings() => base..ctor();
    }
}