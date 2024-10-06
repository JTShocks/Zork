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
        public bool IsRunning { get; set; }
        [JsonIgnore]
        public CommandManager CommandManager { get; }
        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public Game() => CommandManager = new CommandManager();

        public static void Start(string gameFileName)
        {
            if(!File.Exists(gameFileName))
            {
                throw new FileNotFoundException("Expected file.", gameFileName);
            }
        }
        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Console.WriteLine(Player.Location);
                if(previousRoom != Player.Location)
                {
                    CommandManager.PerformCommand(this, "LOOK");
                    previousRoom = Player.Location;
                }
            }
        }


        public static Game Load(string filename)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();

            return game;
        }
        
    }
}
