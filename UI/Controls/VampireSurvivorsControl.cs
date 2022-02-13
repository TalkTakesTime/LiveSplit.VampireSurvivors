using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LiveSplit.VampireSurvivors.Model;
using LiveSplit.VampireSurvivors.Model.SaveData;

namespace LiveSplit.VampireSurvivors.UI.Controls {
    public partial class VampireSurvivorsControl : UserControl, INotifyPropertyChanged {
        private Version _gameVersion;

        public Version GameVersion {
            get => _gameVersion;
            set {
                _gameVersion = value;
                UpdateAchievementsForVersion();
            }
        }

        private State _state = new State();
        public State State {
            get => _state;
            set {
                _state = value;
                OnPropertyChanged(nameof(TotalKills));
                OnPropertyChanged(nameof(TotalSkeles));
                OnPropertyChanged(nameof(TotalHealing));
                OnPropertyChanged(nameof(RemainingKills));
                OnPropertyChanged(nameof(RemainingSkeles));
                OnPropertyChanged(nameof(RemainingHealing));

                UpdateAchievementChecks();
            }
        }

        public string AchievementsTitle => $"Achievements ({_achievedAchievements}/{_achControls.Count})";

        private Dictionary<Achievement, AchievementControl> _achControls = new Dictionary<Achievement, AchievementControl>();
        private int _achievedAchievements;

        public int TotalKills => _state.TotalKills;
        public int TotalSkeles => _state.TotalSkeles;
        public int TotalHealing => _state.TotalHealing;
        public int RemainingKills => _state.RemainingKills;
        public int RemainingSkeles => _state.RemainingSkeles;
        public int RemainingHealing => _state.RemainingHealing;

        public VampireSurvivorsControl() {
            InitializeComponent();
        }

        private void VampireSurvivorsControl_Load(object sender, EventArgs e) {
            lblKillsCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalKills)));
            lblKillsRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingKills)));
            lblSkelesCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalSkeles)));
            lblSkelesRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingSkeles)));
            lblHealingCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalHealing)));
            lblHealingRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingHealing)));
            lblAchievements.DataBindings.Add(new Binding("Text", this, nameof(AchievementsTitle)));

            UpdateAchievementsForVersion();
        }

        private void UpdateAchievementsForVersion() {
            List<Achievement> achievements =
                _gameVersion == null ? Achievements.GetAll() : Achievements.ForVersion(_gameVersion);

            Dictionary<Achievement, AchievementControl> existingControls = _achControls;
            _achControls = new Dictionary<Achievement, AchievementControl>();

            flpAchievements.SuspendLayout();
            flpAchievements.Controls.Clear();

            foreach (Achievement ach in achievements) {
                AchievementControl ctrl = existingControls.TryGetValue(ach, out var existingCtrl)
                    ? existingCtrl
                    : new AchievementControl(ach);
                flpAchievements.Controls.Add(ctrl);
                _achControls[ach] = ctrl;
            }
            flpAchievements.ResumeLayout(true);
        }

        private void UpdateAchievementChecks() {
            foreach (Achievement ach in _achControls.Keys) {
                AchievementControl ctrl = _achControls[ach];
                bool isAchieved = _state.Achievements.Contains(ach);
                if (ctrl.IsAchieved != isAchieved) {
                    ctrl.IsAchieved = isAchieved;
                }
            }

            _achievedAchievements = _state.Achievements.Count;
            OnPropertyChanged(nameof(AchievementsTitle));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
