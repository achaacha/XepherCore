using System;
using Discord.Commands;

namespace XepherBot.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed class XepherModuleAttribute : GroupAttribute
    {
        public XepherModuleAttribute(string moduleName) : base(moduleName)
        {
        }
    }
}
