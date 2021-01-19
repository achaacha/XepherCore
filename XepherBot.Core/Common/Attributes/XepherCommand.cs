using System;
using System.Runtime.CompilerServices;
using Discord.Commands;
using XepherBot.Core.Services.Impl;

namespace XepherBot.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class XepherCommandAttribute : CommandAttribute
    {
        public XepherCommandAttribute([CallerMemberName] string memberName="") : base(Localization.LoadCommand(memberName.ToLowerInvariant()).Cmd.Split(' ')[0])
        {

        }
    }
}
