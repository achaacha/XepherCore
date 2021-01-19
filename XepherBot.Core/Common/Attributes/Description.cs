using System;
using System.Runtime.CompilerServices;
using Discord.Commands;
using XepherBot.Core.Services.Impl;

namespace XepherBot.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class DescriptionAttribute : SummaryAttribute
    {
        public DescriptionAttribute([CallerMemberName] string memberName="") : base(Localization.LoadCommand(memberName.ToLowerInvariant()).Desc)
        {

        }
    }
}
