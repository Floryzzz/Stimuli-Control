﻿using System;
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
            sText.OutputText("You are standing in the Kingston University\nThere are no classes at the moment");
            if (firsttime)
            {
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
                firsttime = false;
                StoryProgression = 1;
            }
            if (StoryProgression == 3)
            {
                string[] TextArray = new string[12] {
                    "Okay, lets find out if this is as wildleyspread on normal people as it is on people with alot of influence\nThen this good looking girl walked by", 
                    "Okay let's find out: As I wanted to walk up to her I felt nervous and knew I didn't have enough confidence to talk to her(quite wierd to not have such a skill while studying Social studies",
                    "Lets just talk to a dude this time, then this guy who looked like snob walked by",
                    "'Hey, you have any idea where the closest by coffeshop is? I need my caffiene before my morning class' I said to him",
                    "'If you just walk along the left side of this building you should see it as soon as you cross the corner'. I thanked him",
                    "Lets hope the rest of these people is normal aswell",
                    "I walked up to the next person and asked them the same question as before",
                    "'Its right around around the corner man'",
                    "Oh fuck I tought to myself",
                    "Let's just try some more",
                    "After about an hour I found out 2/3 of people is infected(probably should call it implented haha)",
                    "I should really get try to get this tape back so people believe me"
                };
                for (int i = 0; i < TextArray.Length; i++)
                {
                    sText.OutputText(TextArray[i]);

                }
                StoryProgression = 4;
            }
           
        }
        public void OnEvenTimeDescription(object sender, ElapsedEventArgs e)
        {

        }
    }
}
