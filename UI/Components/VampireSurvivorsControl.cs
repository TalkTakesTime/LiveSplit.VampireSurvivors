using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LiveSplit.VampireSurvivors.Model;

namespace LiveSplit.UI.Components {
    public partial class VampireSurvivorsControl : UserControl, INotifyPropertyChanged {
        private State _state;
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
            }
        }

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
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
