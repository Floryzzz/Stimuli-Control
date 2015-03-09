using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace TextAdventureCS
{
    
    class University : Location
    {
        public University(string name)
            : base(name)
        {
            firstime = true;
            Cassette tape = new Cassette("Cassette", true);
            items.Add(tape.GetName(), tape);
        }
        
        public override void Description()
        {
            Console.WriteLine("Welcome to the University");
            Console.WriteLine("Oh, I dropped my phone. I should probably go looking for it");
            Console.WriteLine("Oh no, It slipped right under the bookshelf.");
        }
    }
}
