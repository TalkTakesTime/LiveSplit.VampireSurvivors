using LiveSplit.VampireSurvivors.Attributes;
using LiveSplit.VampireSurvivors.Images;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiveSplit.VampireSurvivors.Model.SaveData {
    public static class AchievementExtensions {
        public static ImageResource GetResource(this Achievement ach) => new ImageResource($"{ach}.png");
    }
    
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Achievement {
        [Description("Reach Level 5.")]
        ReachLV5,
        [Description("Reach Level 10.")]
        ReachLV10,
        [Description("Reach Level 20 in Mad Forest.")]
        ReachLV20InMadForest,
        [Description("Survive 1 minute with any character.")]
        Survive1Minute,
        [Description("Survive 5 minutes with Pasqualina.")]
        Survive5MinutesWithDiamond,
        [Description("Survive 5 minutes with Gennaro.")]
        Survive5MinutesWithKnife,
        [Description("Survive 10 minutes with any character.")]
        Survive10Minutes,
        [Description("Survive 20 minutes with any character.")]
        Survive20Minutes,
        [Description("Survive 20 minutes with Krochi.")]
        Survive20MinutesWithCross,
        [Description("Get Fire Wand to Level 4.")]
        GetFireWandToLevel4,
        [Description("Get King Bible to Level 4.")]
        GetHolyBookToLevel4,
        [Description("Get Santa Water to Level 4.")]
        GetHolyWaterToLevel4,
        [Description("Get Lightning Ring to Level 4.")]
        GetLightningRingToLevel4,
        [Description("Get Magic Wand to Level 7.")]
        GetMagicMissileToLevel7,
        [Description("Get Peachone to Level 7.")]
        GetPeachoneToLevel7,
        [Description("Get Runetracer to Level 7.")]
        GetRunetracerToLevel7,
        [Description("Get Garlic to Level 7.")]
        GetGarlicToLevel7,
        [Description("Hold 6 different weapons at once.")]
        Have6DifferentWeapons,
        [Description("Recover a total of 1000 HP.")]
        Recover1000HP,
        [Description("Earn 5000 coins in a single run.")]
        Earn5000CoinsInASingleRun,
        [Description("Destroy 20 light sources.")]
        Destroy20Candles,
        [Description("Find 5 Floor Chickens.")]
        Eat5PotRoast,
        [Description("Find a Little Clover.")]
        FindAClover,
        [Description("Find a Vacuum.")]
        FindAVacuum,
        [Description("Find an Orologion.")]
        FindAnOrologion,
        [Description("Find a Rosary.")]
        FindARosary,
        [Description("Find a Stone Mask.")]
        FindAStoneMask,
        [Description("Defeat a total of 3000 skeletons.")]
        Defeat3000Skeletons,
        [Description("Defeat a total of 5000 enemies.")]
        Defeat5000Enemies,
        [Description("Defeat a total of 100000 enemies.")]
        Defeat100KEnemies,
        [Description("Defeat the gian Blue Venus in the Mad Forest.")]
        DefeatBossMadForest,
        [Description("Defeat the Nesuferit in the Inlaid Library.")]
        DefeatBossLibrary,
        [Description("Unlock Hyper mode for 2 stages.")]
        Unlock2Hypers,
        [Description("Evolve the Whip.")]
        EvolveWhip,
        [Description("Evolve the Magic Wand.")]
        EvolveMagicWand,
        [Description("Evolve the Knife.")]
        EvolveKnife,
        [Description("Evolve the Axe.")]
        EvolveAxe,
        [Description("Evolve the Santa Water.")]
        EvolveSantaWater,
        [Description("Evolve the King Bible.")]
        EvolveKingBible,
        [Description("Evolve the Cross.")]
        EvolveCross,
        [Description("Evolve the Fire Wand.")]
        EvolveFireWand,
        [Description("Evolve the Garlic.")]
        EvolveGarlic,
        [Description("Unite Ebony Wings and Peachone.")]
        UniteBirds,
    }
}
