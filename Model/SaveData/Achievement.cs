using System;
using System.Collections.Generic;
using System.Linq;
using LiveSplit.VampireSurvivors.Attributes;
using LiveSplit.VampireSurvivors.Images;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiveSplit.VampireSurvivors.Model.SaveData {
    public static class Achievements {
        public static List<Achievement> GetAll() => Enum.GetValues(typeof(Achievement)).Cast<Achievement>().ToList();

        public static List<Achievement> ForVersion(Version version) => Enum.GetValues(typeof(Achievement))
            .Cast<Achievement>()
            .Where(ach => (ach.GetAttribute<FromVersionAttribute>()?.Version ?? new Version()) <= version)
            .ToList();

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

        [Description("Reach Level 40 in Inlaid Library.")]
        [FromVersion("0.3.0")]
        ReachLV40InLibrary,

        [Description("Reach Level 100 with Mortaccio.")]
        [FromVersion("0.2.12")]
        ReachLV100WithMortaccio,

        [Description("Reach Level 100 with Yatta Cavallo.")]
        [FromVersion("0.2.13")]
        ReachLV100WithCavallo,

        [Description("Survive 1 minute with any character.")]
        Survive1Minute,

        [Description("Survive 5 minutes with Pasqualina.")]
        Survive5MinutesWithDiamond,

        [Description("Survive 5 minutes with Gennaro.")]
        Survive5MinutesWithKnife,

        [Description("Survive 10 minutes with any character.")]
        Survive10Minutes,

        [Description("Survive 15 minutes with Poppea.")]
        [FromVersion("0.3.0")]
        Survive15MinutesWithSong,

        [Description("Survive 20 minutes with any character.")]
        Survive20Minutes,

        [Description("Survive 20 minutes with Krochi.")]
        Survive20MinutesWithCross,

        [Description("Survive 20 minutes with at least +10% Curse.")]
        [FromVersion("0.2.13")]
        Survive20MinutesWithCurse,

        [Description("Survive 30 minutes with Lama.")]
        [FromVersion("0.2.13")]
        Survive30MinutesWithAxe,

        [Description("Survive 30 minutes in Green Acres.")]
        [FromVersion("0.2.12")]
        Survive30MinutesInGreenAcres,

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

        [Description("Find the Milky Way Map.")]
        [FromVersion("0.3.0")]
        FindMilkyWayMap,

        [Description("Find and open the coffin in the Dairy Plant.")]
        [FromVersion("0.3.0")]
        FindCoffinStage3,

        [Description("Defeat a total of 3000 Skeletons.")]
        Defeat3000Skeletons,

        [Description("Defeat a total of 3000 Lion Heads.")]
        [FromVersion("0.2.13")]
        Defeat3000Buers,

        [Description("Defeat a total of 5000 enemies.")]
        Defeat5000Enemies,

        [Description("Defeat a total of 100000 enemies.")]
        Defeat100KEnemies,

        [Description("Defeat the giant Blue Venus in the Mad Forest.")]
        DefeatBossMadForest,

        [Description("Defeat the Nesuferit in the Inlaid Library.")]
        DefeatBossLibrary,

        [Description("Defeat the Sword Guardian in the Dairy Plant.")]
        [FromVersion("0.3.0")]
        DefeatBossPlant,

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

        [Description("Evolve the Lightning Ring.")]
        [FromVersion("0.2.12")]
        EvolveLightning,

        [Description("Evolve the King Bible.")]
        EvolveKingBible,

        [Description("Evolve the Cross.")]
        EvolveCross,

        [Description("Evolve the Fire Wand.")]
        EvolveFireWand,

        [Description("Evolve the Garlic.")]
        EvolveGarlic,

        [Description("Evolve the Song Of Mana.")]
        [FromVersion("0.3.0")]
        EvolveSongOfMana,

        [Description("Unite Ebony Wings and Peachone.")]
        UniteBirds,

    }
}
