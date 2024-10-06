﻿using System;
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
        private static (int Row, int Column) Location;

        private static Room[,] Rooms;
        public static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }
        }
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename]  : defaultGameFilename);
            Console.WriteLine("Welcome to Zork!");

        }


        private static void InitialiseRoomDescriptions(string roomsFilename) =>
        
            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }


}
