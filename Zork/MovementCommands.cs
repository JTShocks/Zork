using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    [CommandClass]
    public static class MovementCommands
    {
        [Command("NORTH", new string[] { "NORTH", "N" })]
        public static void North(Game game, CommandContext commandContext) => Move(game, Directions.North);


        private static void Move(Game game, Directions direction)
        {
            bool playerMoved = game.Player.Move(direction);
            if (!playerMoved)
            {
                Console.WriteLine("The way is shut!");
            }
        }
    }
}
