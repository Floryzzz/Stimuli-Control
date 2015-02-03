using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TextAdventureCS
{
    
    class University : Location
    {
        bool firsttime = true;
        public University(string name)
            : base(name)
        {
            Cassette tape = new Cassette("Cassette", true);
            items.Add(tape.GetName(), tape);

        }
        
        public override void Description()
        {
            Console.WriteLine("Your standing in Kingston University");
            if (firsttime)
            {
                Console.WriteLine("Oh, I dropped my phone. I should probably go looking for it");
                firsttime = false;
            }
        }
    }
}
