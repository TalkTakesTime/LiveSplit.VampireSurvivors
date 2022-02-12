using System;
using System.Linq;

namespace LiveSplit.VampireSurvivors.Attributes {
    public static class AttributeExtensions {
        public static T GetAttribute<T>(this Enum value) where T : Attribute {
            Type enumType = value.GetType();
            string name = Enum.GetName(enumType, value);
            return enumType.GetField(name).GetCustomAttributes(false).OfType<T>().SingleOrDefault();
        }
    }
}
