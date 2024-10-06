using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename]  : defaultGameFilename);
            Game.Start(gameFilename);
            Console.WriteLine("Thank you for playing!");

        }
        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }


}
