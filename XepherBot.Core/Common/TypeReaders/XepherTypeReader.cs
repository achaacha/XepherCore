using Discord.Commands;
using Discord.WebSocket;

namespace XepherBot.Core.Common.TypeReaders
{
    public abstract class XepherTypeReader<T> : TypeReader
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _cmds;

        private XepherTypeReader() { }
        protected XepherTypeReader(DiscordSocketClient client, CommandService cmds)
        {
            _client = client;
            _cmds = cmds;
        }
    }
}
