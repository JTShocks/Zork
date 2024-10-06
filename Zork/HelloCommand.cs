using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    [CommandClass]
    public static class HelloCommand
    {

        static string[] responses = new string[]
        {
            "Good day.",
            "Nice weather we've been having lately.",
            "Nice to see you."
        };
        [Command("HELLO", new string[] { "HELLO", "HI", "HOWDY" })]
        public static void Hello(Game game, CommandContext commandContext)
        {
            string selectedResponse = responses[Game.Random.Next(responses.Length)];
            Console.WriteLine(selectedResponse);
        }
    }
}
