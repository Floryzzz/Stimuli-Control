﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Map
    {
        private int height;
        private int width;
        private Location[,] map;

        private Position pos;
        private Directions directions;

        private struct Position
        {
            public int Xposition;
            public int Yposition;
        }

        private struct Directions
        {
            public int north;
            public int east;
            public int south;
            public int west;
        }

        public Map(int width, int height, int XStartPos, int YStartPos)
        {
            this.width = width;
            this.height = height;

            map = new Location[this.width, this.height];
            directions = new Directions();
            
            if ((XStartPos < width) && (XStartPos >= 0) && (YStartPos < height) && (YStartPos >= 0))
            {
                pos = new Position() { Xposition = XStartPos, Yposition = YStartPos };
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error: Position is outside the map");
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
            }
        }

        public void AddLocation(Location loc, int XPos, int YPos)
        {
            map[XPos, YPos] = loc;
        }

        public void Move( string dir )
        {
            switch (dir)
            {
                case "Go North":
                    pos.Yposition += 1;
                    break;
                case "Go East":
                    pos.Xposition += 1;
                    break;
                case "Go South":
                    pos.Yposition -= 1;
                    break;
                case "Go West":
                    pos.Xposition -= 1;
                    break;
                default:
                    Console.WriteLine("Move() has broken down.");
                    break;
            }
        }

        public void AllowedDirections()
        {
            // if a direction has a value of 1, then the player can go there
            directions.north = 1;
            directions.east = 1;
            directions.south = 1;
            directions.west = 1;

            // Check boundries and if there is a level north in the array
            if (pos.Yposition + 1 >= height)
                directions.north = -1;
            else if (map[pos.Yposition + 1, pos.Xposition] == null)
                directions.north = -1;
            // Check boundries and if there is a level south in the array
            if (pos.Yposition - 1 < 0)
                directions.south = -1;
            else if (map[pos.Yposition - 1, pos.Xposition] == null)
                directions.south = -1;
            // Check boundries and if there is a level east in the array
            if (pos.Xposition + 1 >= width)
                directions.east = -1;
            else if (map[pos.Yposition, pos.Xposition + 1] == null)
                directions.east = -1;
            // Check boundries and if there is a level west in the array
            if (pos.Xposition - 1 < 0)
                directions.west = -1;
            else if (map[pos.Yposition, pos.Xposition - 1] == null)
                directions.west = -1;
        }

        public Location GetLocation()
        {
            return map[pos.Yposition,pos.Xposition];
        }

        public int GetNorth()
        {
            return directions.north;
        }

        public int GetEast()
        {
            return directions.east;
        }

        public int GetSouth()
        {
            return directions.south;
        }

        public int GetWest()
        {
            return directions.west;
        }
        public int GetXP()
        {
            return pos.Xposition; 
        }
        public int GetYP()
        {
            return pos.Yposition;
        }
    }
}
