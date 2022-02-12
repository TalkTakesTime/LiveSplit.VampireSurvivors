using System;

namespace LiveSplit.VampireSurvivors.Attributes {
    [AttributeUsage(AttributeTargets.Field)]
    public class DescriptionAttribute : Attribute {
        public string Description { get; }

        public DescriptionAttribute(string desc) {
            Description = desc;
        }
    }
}