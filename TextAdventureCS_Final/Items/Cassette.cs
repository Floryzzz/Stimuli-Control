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

        override public void Description()
        {
            Console.WriteLine("This is the tape that you found in the University");
        }
        override public void TinyDescription()
        {
            Console.WriteLine("Here is something under the shelves");
        }
        public override void Use()
        {
            Console.Clear();
            SText sText = new SText();
            string[] textArray = new string[28] {
                
                "While looking for my phone I found a Cassette tape, it has Test05",
                "written on it.",
                "Finally I found my phone",
                "Wondering what is on the tape I walked over to the Cassette player ",
                "meant for listening to audio books(They're like books but for people",
                "to lazy to read)",
                "I clicked the tape into the cassette deck",
                "I heard a voice documentating some kind of test",
                "'The microchip is almost complete'\n 'We only have one minor bug'",
                "'I have tried many things to fix it, so many I am convinced it",
                "cannot be fixed'",
                "'The human brain is quite complicated after all'",
                "Probably documentation about some kind of lie detector I tought to myself",
                "'The output is exactly as excpected, the test subjects act on our orders",
                "witouth even knowing they are'",
                "I was shocked",
                "At some point there were brain control experiments going on in this school",
                "'Can you explain the bug for documentation purposes' I heard a vaguely ",
                "familiar voice say in the background",
                "noticible as some people stutter'",
                "'Ok, Sometimes test subjects repeat words up to 3 times. It's not really",
                "'Are we missing anything' the voice in the background said",
                "'I think were done for today'",
                "I ejected the tape",
                "I saw one of my teachers look at the tape just as I wanted to put it in my bag",
                "He knew, I saw the look on his face",
                "He walked over and grabbed the tape out of my hand and said 'This",
                "shouldn't be here ill make sure it gets in the right place'"};

            for (int i = 0; i < textArray.Length; i++)
            {
                sText.OutputText(textArray[i]);

            }
        }
    }
}