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
        private readonly Version _gameVersion;

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

                UpdateAchievements();
            }
        }

        public string AchievementsTitle => $"Achievements ({_achievedAchievements}/{_achControls.Count})";

        private Dictionary<Achievement, AchievementControl> _achControls = new Dictionary<Achievement, AchievementControl>();
        private int _achievedAchievements = 0;

        public int TotalKills => _state.TotalKills;
        public int TotalSkeles => _state.TotalSkeles;
        public int TotalHealing => _state.TotalHealing;
        public int RemainingKills => _state.RemainingKills;
        public int RemainingSkeles => _state.RemainingSkeles;
        public int RemainingHealing => _state.RemainingHealing;

        public VampireSurvivorsControl(Version gameVersion = null) {
            InitializeComponent();

            _gameVersion = gameVersion;
        }

        private void VampireSurvivorsControl_Load(object sender, EventArgs e) {
            lblKillsCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalKills)));
            lblKillsRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingKills)));
            lblSkelesCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalSkeles)));
            lblSkelesRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingSkeles)));
            lblHealingCumu.DataBindings.Add(new Binding("Text", this, nameof(TotalHealing)));
            lblHealingRem.DataBindings.Add(new Binding("Text", this, nameof(RemainingHealing)));
            grpAchievements.DataBindings.Add(new Binding("Text", this, nameof(AchievementsTitle)));

            List<Achievement> achievements =
                _gameVersion == null ? Achievements.GetAll() : Achievements.ForVersion(_gameVersion);

            // update the number of rows to match the number of achievements
            // the `RowCount` property is actually the _maximum_ number of rows, not the real number of rows, so
            // we need to update it and then add new rows by adding a new style
            grpAchievements.SuspendLayout();
            int rowsNeeded =
                Math.DivRem(achievements.Count, tblAchievements.ColumnCount, out int rem) + (rem != 0 ? 1 : 0);
            tblAchievements.RowCount = rowsNeeded;
            while (tblAchievements.RowStyles.Count < rowsNeeded) {
                tblAchievements.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < achievements.Count; i++) {
                int row = Math.DivRem(i, tblAchievements.ColumnCount, out int column);
                var ctrl = new AchievementControl(achievements[i]);
                ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                tblAchievements.Controls.Add(ctrl, column, row);
                _achControls[achievements[i]] = ctrl;
            }
            grpAchievements.ResumeLayout(true);
        }

        private void UpdateAchievements() {
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
