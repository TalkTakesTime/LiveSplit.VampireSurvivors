using System;
using System.IO;
using Newtonsoft.Json;

namespace LiveSplit.VampireSurvivors.Model {
    [JsonObject(MemberSerialization.OptIn)]
    public class GameVersion {
        public static readonly string GameVersionDir = Path.Combine("resources", "app");
        public const string GameVersionFile = "package.json";

        public static bool TryLoadGameVersion(string installDir, out GameVersion gv) {
            gv = null;

            if (string.IsNullOrEmpty(installDir)) {
                return false;
            }

            try {
                string versionPath = Path.Combine(installDir, GameVersionDir, GameVersionFile);
                if (!File.Exists(versionPath)) {
                    return false;
                }

                string fileContent = File.ReadAllText(versionPath);
                gv = JsonConvert.DeserializeObject<GameVersion>(fileContent);
                return true;
            } catch (Exception) {
                return false;
            }
        }

        [JsonProperty("version")]
        public string VersionString { get; set; }

        public bool TryParseVersion(out Version version) {
            return Version.TryParse(VersionString ?? string.Empty, out version);
        }
    }
}
