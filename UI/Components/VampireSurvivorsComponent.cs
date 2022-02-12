using LiveSplit.Model;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.VampireSurvivors.Model;
using LiveSplit.VampireSurvivors.Model.SaveData;
using LiveSplit.VampireSurvivors.UI.Controls;

namespace LiveSplit.UI.Components {
    public class VampireSurvivorsComponent : ControlComponent {
        private VampireSurvivorsControl _control;
        private FileSystemWatcher _saveWatcher;
        
        // This is how we will access all the settings that the user has set.
        public VampireSurvivorsSettings Settings { get; set; }
        // This object contains all of the current information about the splits, the timer, etc.
        protected LiveSplitState CurrentState { get; }

        public override string ComponentName => "Vampire Survivors Tracker";
        public override float HorizontalWidth => Control.Width;
        public override float MinimumHeight => Control.MinimumSize.Height;
        public override float VerticalHeight => Control.Height;
        public override float MinimumWidth => Control.MinimumSize.Width;

        public VampireSurvivorsComponent(LiveSplitState state) : base(state, new VampireSurvivorsControl()) {
            CurrentState = state;
            Settings = new VampireSurvivorsSettings();
            _control = (VampireSurvivorsControl)Control;
            ResetState();

            CurrentState.OnStart += state_OnStart;
            CurrentState.OnReset += state_OnReset;
        }

        private void state_OnStart(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(Settings.VsInstallDir)) {
                return;
            }

            _saveWatcher = new FileSystemWatcher(Path.Combine(Settings.VsInstallDir, SaveData.SaveDataDir));
            _saveWatcher.Filter = SaveData.SaveDataFile;
            _saveWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.CreationTime;
            _saveWatcher.Changed += OnSaveDataChanged;
            _saveWatcher.Created += OnSaveDataChanged;
            _saveWatcher.Deleted += OnSaveFileDeleted;

            _control.State = State.TryLoadState(
                Path.Combine(Settings.VsInstallDir, SaveData.SaveDataDir, SaveData.SaveDataFile),
                out State state
            ) ? state : new State();

            _saveWatcher.EnableRaisingEvents = true;
        }

        private void state_OnReset(object sender, TimerPhase _) => StopWatching();

        private void StopWatching() {
            _saveWatcher?.Dispose();
            _saveWatcher = null;
            ResetState();
        }

        private void OnSaveFileDeleted(object sender, FileSystemEventArgs e) => ResetState();

        private void OnSaveDataChanged(object sender, FileSystemEventArgs e) {
            _control.State = State.TryLoadState(e.FullPath, out State state) ? state : new State();
        }

        private void ResetState() {
            _control.State = new State();
        }

        public override Control GetSettingsControl(LayoutMode mode) {
            // Settings.Mode = mode;
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument doc) {
            return Settings.GetSettings(doc);
        }

        public override void SetSettings(XmlNode settings) {
            Settings.SetSettings(settings);
        }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();

        public override void Dispose() {
            base.Dispose();
            _saveWatcher?.Dispose();
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnReset -= state_OnReset;
        }
    }
}