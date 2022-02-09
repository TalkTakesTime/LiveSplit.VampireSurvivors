using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components {
    public class VampireSurvivorsComponent : ControlComponent {
        // This is how we will access all the settings that the user has set.
        public VampireSurvivorsSettings Settings { get; set; }
        // This object contains all of the current information about the splits, the timer, etc.
        protected LiveSplitState CurrentState { get; }

        public override string ComponentName => "VS Achievements";
        public override float HorizontalWidth => Control.Width;
        public override float MinimumHeight => Control.MinimumSize.Height;
        public override float VerticalHeight => Control.Height;
        public override float MinimumWidth => Control.MinimumSize.Width;


        // I'm going to be honest, I don't know what this is for, but I know we don't need it.
        public IDictionary<string, Action> ContextMenuControls => null;

        public VampireSurvivorsComponent(LiveSplitState state) : base(state, new VampireSurvivorsControl()) {
            CurrentState = state;
        }

        public override Control GetSettingsControl(LayoutMode mode) {
            // Settings.Mode = mode;
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument doc) {
            return null;
            // return Settings.GetSettings(doc);
        }

        public override void SetSettings(XmlNode settings) {
            // Settings.SetSettings(settings);
        }

        public override void Dispose() {
            base.Dispose();
        }
    }
}