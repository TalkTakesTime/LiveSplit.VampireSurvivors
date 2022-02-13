using System;

namespace LiveSplit.VampireSurvivors.Attributes {
    [AttributeUsage(AttributeTargets.Field)]
    public class FromVersionAttribute : Attribute {
        public Version Version { get; }

        public FromVersionAttribute(string fromVersion) {
            Version = Version.Parse(fromVersion);
        }
    }
}
