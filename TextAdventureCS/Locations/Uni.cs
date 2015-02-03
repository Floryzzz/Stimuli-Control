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
            //     Cassette tape = new Cassette("Cassette", true);
            //    items.Add(tape.GetName(), tape);

        }

        public override void Description()
        {
            int longpause = 3700;
            int shortpause = 2200;
            int normalpause = 2900;
            Console.WriteLine("Your standing in Kingston University");
            if (firsttime)
            {
                Console.WriteLine("Oh, I dropped my phone. I should probably go looking for it");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("Oh no, It slipped right under the bookshelf.");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("While looking for my phone I found a Cassette tape, it has Test05 written on it.");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("Finally I found my phone");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("Wondering what is on the tape I walked over to the Cassette player meant for listening to audio books(They're like books but for people to lazy to read)");
                System.Threading.Thread.Sleep(longpause); System.Threading.Thread.Sleep(shortpause);
                Console.WriteLine("I clicked the tape into the cassette deck");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("I heard a voice documentating some kind of test");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("'The microchip is almost complete'\n 'We only have one minor bug'");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("'I have tried many things to fix it, so many I am convinced it cannot be fixed'");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("'The human brain is quite complicated after all'");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("Probably documentation about some kind of lie detector I tought to myself");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("'The output is exactly as excpected, the test subjects act on our orders witouth even knowing they are'");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("I was shocked");
                System.Threading.Thread.Sleep(shortpause);
                Console.WriteLine("At some point there were brain control experiments going on in this school");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("'Can you explain the bug for documentation purposes' I heard a vaguely familiar voice say in the background");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("'Ok, Sometimes test subjects repeat words up to 3 times. It's not really noticible as some people stutter'");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("'Are we missing anything' the voice in the background said");
                System.Threading.Thread.Sleep(normalpause);
                Console.WriteLine("'I think were done for today'");
                System.Threading.Thread.Sleep(shortpause);
                Console.WriteLine("I ejected the tape");
                System.Threading.Thread.Sleep(shortpause);
                Console.WriteLine("I saw one of my teachers look at the tape just as I wanted to put it in my bag");
                System.Threading.Thread.Sleep(longpause);
                Console.WriteLine("He knew, I saw the look on his face");
                System.Threading.Thread.Sleep(shortpause);
                Console.WriteLine("He walked over and grabbed the tape out of my hand and said 'This shouldn't be here ill make sure it gets in the right place'");
                System.Threading.Thread.Sleep(longpause); System.Threading.Thread.Sleep(shortpause);
                firsttime = false;
            }
        }
    }
}
