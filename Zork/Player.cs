using System.Collections.Generic;
using System.Collections;
using System;
using Newtonsoft.Json;


namespace Zork
{
    public class Player
    {
        public int Moves;
        public World World { get; }
        [JsonIgnore]
        public Room Location { get; private set; }
        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {

                if (World.RoomsByName.TryGetValue(value, out Room room))
                {
                    if (room != null)
                    {
                        Location = room;
                    }
                    
                }
                
                
                
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }
            return isValidMove;
        }
    }
}
