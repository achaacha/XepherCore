using Discord;

namespace XepherBot.Extensions
{
    public static class MusicExtensions
    {
        public static EmbedAuthorBuilder WithMusicIcon(this EmbedAuthorBuilder eab) =>
            eab.WithIconUrl("https://i.imgur.com/HJdS1ji.gif");
    }
}
