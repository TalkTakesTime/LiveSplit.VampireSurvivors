using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LiveSplit.VampireSurvivors.Model.SaveData {
    [JsonObject(MemberSerialization.OptOut)]
    public class SaveData {
        [JsonIgnore]
        public static readonly string SaveDataDir = Path.Combine("resources", "app", ".webpack", "renderer");
        [JsonIgnore]
        public const string SaveDataFile = "SaveDataBackup.sav";
        
        public float LifetimeHeal { get; set; }
        public Dictionary<string, int> KillCount { get; set; }
        public List<Achievement> Achievements { get; set; }
    }
}