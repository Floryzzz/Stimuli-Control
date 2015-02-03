using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Cassette : Objects
    {
        public Cassette(string name, bool acquirable)
            : base(name, acquirable)
        {
            Console.WriteLine("You found a cassette tape");
        }

        override protected void Description()
        {
            Console.WriteLine("You found a Cassette tape");
        }
    }
}