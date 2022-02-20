using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LiveSplit.VampireSurvivors.Model.SaveData {
    [JsonObject(MemberSerialization.OptOut)]
    public class SaveData {
        // Vampire Survivors keeps save data in two locations:
        //  - "%APPDATA%\Vampire_Survivors\Local Storage" - this is the primary save data location, where the data is
        //    stored as a LevelDB database
        //  - "<VS steam install dir>\resources\app\.webpack\renderer\SaveDataBackup.sav" - this is the secondary
        //    save data location, where the data is stored as a JSON file
        // we load the data from the secondary location, because it's much simpler to parse
        // however, this means it isn't sufficient to just delete the JSON file - we have to delete both to reset the
        // save properly
        public static readonly string SaveDataDir = Path.Combine("resources", "app", ".webpack", "renderer");
        public const string SaveDataFile = "SaveDataBackup.sav";

        private static readonly string
            AppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string SaveDataDbDir = string.IsNullOrEmpty(AppDataDir)
            ? null
            : Path.Combine(AppDataDir, "Vampire_Survivors", "Local Storage");

        public static void DeleteSaveData(string installDir) {
            if (SaveDataDbDir != null && Directory.Exists(SaveDataDbDir)) {
                Directory.Delete(SaveDataDbDir, true);
            }

            if (string.IsNullOrEmpty(installDir)) {
                return;
            }

            string savFile = Path.Combine(installDir, SaveDataDir, SaveDataFile);
            if (File.Exists(savFile)) {
                File.Delete(savFile);
            }
        }

        public float LifetimeHeal { get; set; }
        public Dictionary<string, int> KillCount { get; set; }
        public List<Achievement> Achievements { get; set; }
    }
}
