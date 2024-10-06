using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Zork
{
    public class Game
    {
        [JsonIgnore]
        public static Game Instance { get; private set; }
        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; }
        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }
        
    }
}
