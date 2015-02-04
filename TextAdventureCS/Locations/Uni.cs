using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


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
            SText sText = new SText();
            string[] textArray = new string[23] {
                "Oh, I dropped my phone. I should probably go looking for it",
                "Oh no, It slipped right under the bookshelf.",
                "While looking for my phone I found a Cassette tape, it has Test05 \nwritten on it.",
                "Finally I found my phone",
                "Wondering what is on the tape I walked over to the Cassette player ",
                "meant for listening to audio books(They're like books but for people\n to lazy to read)",
                "I clicked the tape into the cassette deck",
                "I heard a voice documentating some kind of test",
                "'The microchip is almost complete'\n 'We only have one minor bug'",
                "'I have tried many things to fix it, so many I am convinced it \ncannot be fixed'",
                "'The human brain is quite complicated after all'",
                "Probably documentation about some kind of lie detector I tought to myself",
                "'The output is exactly as excpected, the test subjects act on our orders \nwitouth even knowing they are'",
                "I was shocked",
                "At some point there were brain control experiments going on in this school",
                "'Can you explain the bug for documentation purposes' I heard a vaguely \nfamiliar voice say in the background",
                "'Ok, Sometimes test subjects repeat words up to 3 times. It's not really\n noticible as some people stutter'",
                "'Are we missing anything' the voice in the background said",
                "'I think were done for today'",
                "I ejected the tape",
                "I saw one of my teachers look at the tape just as I wanted to put it in my bag",
                "He knew, I saw the look on his face",
                "He walked over and grabbed the tape out of my hand and said 'This \nshouldn't be here ill make sure it gets in the right place'"};

            for (int i = 0; i < textArray.Length; i++)
            {
                sText.OutputText(textArray[i]);
                
            }









            //int longpause = 3700;
            //int shortpause = 2200;
            //int normalpause = 2900;
            //Console.WriteLine("Your standing in Kingston University");
            //if (firsttime)
            //{

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
        }
        public void OnEvenTimeDescription(object sender, ElapsedEventArgs e)
        {

        }
    }
}
