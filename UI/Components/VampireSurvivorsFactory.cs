using System;
using System.Reflection;
using LiveSplit.Model;

namespace LiveSplit.UI.Components {
    public class VampireSurvivorsFactory : IComponentFactory {
        public string ComponentName => "Vampire Survivors Tracker";
        public string Description => "Displays achievements obtained so far in the current Vampire Survivors run.";

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
        public ComponentCategory Category => ComponentCategory.Information;

        public string UpdateName => ComponentName;
        public string UpdateURL => "";
        public string XMLURL => UpdateURL + "";

        public IComponent Create(LiveSplitState state) => new VampireSurvivorsComponent(state);
    }
}
