using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LiveSplit.VampireSurvivors.Model.SaveData;
using Newtonsoft.Json;

namespace LiveSplit.VampireSurvivors.Model {
    public class State {
        private const int TargetKills = 100_000;
        private const int TargetSkeles = 3_000;
        private const int TargetHealing = 1_000;

        private const string Skeleton = "SKELETON";


        public static bool TryLoadState(string dataFile, out State state) {
            if (!File.Exists(dataFile)) {
                state = null;
                return false;
            }

            try {
                string data = File.ReadAllText(dataFile);
                var saveData = JsonConvert.DeserializeObject<SaveData.SaveData>(data);

                state = new State(saveData);
                return true;
            } catch {
                state = null;
                return false;
            }
        }

        public State() {
            Achievements = new HashSet<Achievement>();
        }

        public State(SaveData.SaveData data) {
            TotalKills = data.KillCount.Values.Sum();

            if (data.KillCount.TryGetValue(Skeleton, out int skeles)) {
                TotalSkeles = skeles;
            }

            TotalHealing = (int) data.LifetimeHeal;
            Achievements = new HashSet<Achievement>(data.Achievements ?? new List<Achievement>());
        }

        public int TotalKills { get; }
        public int TotalSkeles { get; }
        public int TotalHealing { get; }

        public int RemainingKills => Math.Max(0, TargetKills - TotalKills);
        public int RemainingSkeles => Math.Max(0, TargetSkeles - TotalSkeles);
        public int RemainingHealing => Math.Max(0, TargetHealing - TotalHealing);

        public HashSet<Achievement> Achievements { get; }
    }
}
