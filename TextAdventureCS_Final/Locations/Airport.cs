using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Airport : Location
    {
        public Airport(string name)
            : base(name)
        {
            firstime = true;
            specificAction = true;
        }
        public override void Description()
        {
            Console.WriteLine("You're now in the Londen airport");
        }
    }
}
