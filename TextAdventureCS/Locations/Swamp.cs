using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Swamp : Location
    {
        public Swamp(string name)
            : base(name)
        {
        }

        public override void Description(Player player)
        {
            Console.Write("You are standing in a swamp.");
        }
    }
}
    