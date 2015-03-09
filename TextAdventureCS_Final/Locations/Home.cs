using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Home : Location
    {
        public Home(string name)
            : base(name)
        {
            firstime = true;
            Cassette cas = new Cassette("Cassette", true);
            items.Add(cas.GetName(), cas);
            specificAction = false;
            hasPeople = true;
        }

        public override void Description()
        {
            // Insert a nice description
            Console.WriteLine("You are standing in your home");
        }
    }
}
