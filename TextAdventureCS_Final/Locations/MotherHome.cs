using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class MotherHome : Location
    {
        public MotherHome(string name)
            : base(name)
        {
            firstime = true;
            hasPeople = true;
            actor = new Mother("mom");
        }
        public override void Description()
        {
            Console.WriteLine("You are now standing in your mothers house");
        }
        
    }
}
