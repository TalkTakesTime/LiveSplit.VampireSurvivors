using LiveSplit.VampireSurvivors.Images;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiveSplit.VampireSurvivors.Model.SaveData {
    public static class AchievementExtensions {
        public static ImageResource GetResource(this Achievement ach) => new ImageResource($"{ach}.png");
    }
    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Achievement {
        /// <summary>
        /// Reach Level 5.
        /// </summary>
        ReachLV5,
        /// <summary>
        /// Reach Level 10.
        /// </summary>
        ReachLV10,
        /// <summary>
        /// Reach Level 20 in Mad Forest.
        /// </summary>
        ReachLV20InMadForest,
        /// <summary>
        /// Survive 1 minute with any character.
        /// </summary>
        Survive1Minute,
        /// <summary>
        /// Survive 5 minutes with Pasqualina.
        /// </summary>
        Survive5MinutesWithDiamond,
        /// <summary>
        /// Survive 5 minutes with Gennaro.
        /// </summary>
        Survive5MinutesWithKnife,
        /// <summary>
        /// Survive 10 minutes with any character.
        /// </summary>
        Survive10Minutes,
        /// <summary>
        /// Survive 20 minutes with any character.
        /// </summary>
        Survive20Minutes,
        /// <summary>
        /// Survive 20 minutes with Krochi.
        /// </summary>
        Survive20MinutesWithCross,
        /// <summary>
        /// Get Fire Wand to Level 4.
        /// </summary>
        GetFireWandToLevel4,
        /// <summary>
        /// Get King Bible to Level 4.
        /// </summary>
        GetHolyBookToLevel4,
        /// <summary>
        /// Get Santa Water to Level 4.
        /// </summary>
        GetHolyWaterToLevel4,
        /// <summary>
        /// Get Lightning Ring to Level 4.
        /// </summary>
        GetLightningRingToLevel4,
        /// <summary>
        /// Get Magic Wand to Level 7.
        /// </summary>
        GetMagicMissileToLevel7,
        /// <summary>
        /// Get Peachone to Level 7.
        /// </summary>
        GetPeachoneToLevel7,
        /// <summary>
        /// Get Runetracer to Level 7.
        /// </summary>
        GetRunetracerToLevel7,
        /// <summary>
        /// Get Garlic to Level 7.
        /// </summary>
        GetGarlicToLevel7,
        /// <summary>
        /// Hold 6 different weapons at once.
        /// </summary>
        Have6DifferentWeapons,
        /// <summary>
        /// Recover a total of 1000 HP.
        /// </summary>
        Recover1000HP,
        /// <summary>
        /// Earn 5000 coins in a single run.
        /// </summary>
        Earn5000CoinsInASingleRun,
        /// <summary>
        /// Destroy 20 light sources.
        /// </summary>
        Destroy20Candles,
        /// <summary>
        /// Find 5 Floor Chickens.
        /// </summary>
        Eat5PotRoast,
        /// <summary>
        /// Find a Little Clover.
        /// </summary>
        FindAClover,
        /// <summary>
        /// Find a Vacuum.
        /// </summary>
        FindAVacuum,
        /// <summary>
        /// Find an Orologion.
        /// </summary>
        FindAnOrologion,
        /// <summary>
        /// Find a Rosary.
        /// </summary>
        FindARosary,
        /// <summary>
        /// Find a Stone Mask.
        /// </summary>
        FindAStoneMask,
        /// <summary>
        /// Defeat a total of 3000 skeletons.
        /// </summary>
        Defeat3000Skeletons,
        /// <summary>
        /// Defeat a total of 5000 enemies.
        /// </summary>
        Defeat5000Enemies,
        /// <summary>
        /// Defeat a total of 100000 enemies.
        /// </summary>
        Defeat100KEnemies,
        /// <summary>
        /// Defeat the gian Blue Venus in the Mad Forest.
        /// </summary>
        DefeatBossMadForest,
        /// <summary>
        /// Defeat the Nesuferit in the Inlaid Library.
        /// </summary>
        DefeatBossLibrary,
        /// <summary>
        /// Unlock Hyper mode for 2 stages.
        /// </summary>
        Unlock2Hypers,
        /// <summary>
        /// Evolve the Whip.
        /// </summary>
        EvolveWhip,
        /// <summary>
        /// Evolve the Magic Wand.
        /// </summary>
        EvolveMagicWand,
        /// <summary>
        /// Evolve the Knife.
        /// </summary>
        EvolveKnife,
        /// <summary>
        /// Evolve the Axe.
        /// </summary>
        EvolveAxe,
        /// <summary>
        /// Evolve the Santa Water.
        /// </summary>
        EvolveSantaWater,
        /// <summary>
        /// Evolve the King Bible.
        /// </summary>
        EvolveKingBible,
        /// <summary>
        /// Evolve the Cross.
        /// </summary>
        EvolveCross,
        /// <summary>
        /// Evolve the Fire Wand.
        /// </summary>
        EvolveFireWand,
        /// <summary>
        /// Evolve the Garlic.
        /// </summary>
        EvolveGarlic,
        /// <summary>
        /// Unite Ebony Wings and Peachone.
        /// </summary>
        UniteBirds,
    }
}
