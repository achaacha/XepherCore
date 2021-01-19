using CommandLine;

namespace XepherBot.Core.Common
{
    public class LbOpts : IXepherCommandOptions
    {
        [Option('c', "clean", Default = false, HelpText = "Only show users who are on the server.")]
        public bool Clean { get; set; }
        public void NormalizeOptions()
        {

        }
    }
}
