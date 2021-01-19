using System;

namespace XepherBot.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class XepherOptionsAttribute : Attribute
    {
        public Type OptionType { get; set; }

        public XepherOptionsAttribute(Type t)
        {
            this.OptionType = t;
        }
    }
}
