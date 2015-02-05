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
        
        public override void Description(Player player)
        {
            
            SText sText = new SText();
            Console.WriteLine("You are standing in the Kingston University\nThere are no classes at the moment");
            if (firsttime)
            {
                Console.WriteLine("Oh, I dropped my phone. I should probably go looking for it");
                Console.Write("Oh no, It slipped right under the bookshelf.");
                //string[] textArray = new string[30] {
                //"Oh, I dropped my phone. I should probably go looking for it",
                //"Oh no, It slipped right under the bookshelf.",
                //"While looking for my phone I found a Cassette tape, it has Test05",
                //"written on it.",
                //"Finally I found my phone",
                //"Wondering what is on the tape I walked over to the Cassette player ",
                //"meant for listening to audio books(They're like books but for people",
                //"to lazy to read)",
                //"I clicked the tape into the cassette deck",
                //"I heard a voice documentating some kind of test",
                //"'The microchip is almost complete'\n 'We only have one minor bug'",
                //"'I have tried many things to fix it, so many I am convinced it",
                //"cannot be fixed'",
                //"'The human brain is quite complicated after all'",
                //"Probably documentation about some kind of lie detector I tought to myself",
                //"'The output is exactly as excpected, the test subjects act on our orders",
                //"witouth even knowing they are'",
                //"I was shocked",
                //"At some point there were brain control experiments going on in this school",
                //"'Can you explain the bug for documentation purposes' I heard a vaguely ",
                //"familiar voice say in the background",
                //"noticible as some people stutter'",
                //"'Ok, Sometimes test subjects repeat words up to 3 times. It's not really",
                //"'Are we missing anything' the voice in the background said",
                //"'I think were done for today'",
                //"I ejected the tape",
                //"I saw one of my teachers look at the tape just as I wanted to put it in my bag",
                //"He knew, I saw the look on his face",
                //"He walked over and grabbed the tape out of my hand and said 'This",
                //"shouldn't be here ill make sure it gets in the right place'"};
                //string[] textArray = new string[23] {
                //"Oh, I dropped my phone. I should probably go looking for it",
                //"Oh no, It slipped right under the bookshelf.",
                //"While looking for my phone I found a Cassette tape, it has Test05 \nwritten on it.",
                //"Finally I found my phone",
                //"Wondering what is on the tape I walked over to the Cassette player ",
                //"meant for listening to audio books(They're like books but for people\n to lazy to read)",
                //"I clicked the tape into the cassette deck",
                //"I heard a voice documentating some kind of test",
                //"'The microchip is almost complete'\n 'We only have one minor bug'",
                //"'I have tried many things to fix it, so many I am convinced it \ncannot be fixed'",
                //"'The human brain is qui    te complicated after all'",
                //"Probably documentation about some kind of lie detector I tought to myself",
                //"'The output is exactly as excpected, the test subjects act on our orders \nwitouth even knowing they are'",
                //"I was shocked",
                //"At some point there were brain control experiments going on in this school",
                //"'Can you explain the bug for documentation purposes' I heard a vaguely \nfamiliar voice say in the background",
                //"'Ok, Sometimes test subjects repeat words up to 3 times. It's not really\n noticible as some people stutter'",
                //"'Are we missing anything' the voice in the background said",
                //"'I think were done for today'",
                //"I ejected the tape",
                //"I saw one of my teachers look at the tape just as I wanted to put it in my bag",
                //"He knew, I saw the look on his face",
                //"He walked over and grabbed the tape out of my hand and said 'This \nshouldn't be here ill make sure it gets in the right place'"};
                //player.StoryProgression = 2;
                //for (int i = 0; i < textArray.Length; i++)
                //{
                //    sText.OutputText(textArray[i]);
                //    player.StoryMessage += ("\n" + textArray[i]);

                //}
                firsttime = false;
            }
            else if (player.StoryProgression == 3)
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
                    player.StoryMessage += ("\n" + TextArray[i]);
                }
                player.StoryProgression = 4;
            }
            else if (player.StoryProgression == 5)
            {
                string[] textArray = new string[18] {
                "Walking to the teacher room,",
                "Looking through the window,",
                "Seeing the teacher taking a book out his bag,",
                "Thinking: *How can I take the tape out his bag??*",
                "Smash the fire alarm,",
                "Everyone leaves the room,",
                "Ok, now I go!",
                "Found the bag 'Looking in side.. \n nothing in found.'",
                "Tinking: *Where can he hide it??*",
                "Looking around and seeing shine a thing,",
                "A key!",
                "Trying to open the teachers safe,",
                "Anything fall out the safe!",
                "A broken tape,",
                "The teacher has pulled the tape..",
                "*Tuut Taat Tuut Taat* The fire brigade!",
                "Running out of the building,",
                "Goind to home without any succes,"};
                for (int i = 0; i < textArray.Length; i++)
                {
                    sText.OutputText(textArray[i]);
                    player.StoryMessage += ("\n" +textArray[i]);
                    textArray[i] = "";

                }
                player.StoryProgression++;
            }else if (player.StoryProgression == 5)
            {
                string[] textArray = new string[18] {
                "Walking to the teacher room,",
                "Looking through the window,",
                "Seeing the teacher taking a book out his bag,",
                "Thinking: *How can I take the tape out his bag??*",
                "Smash the fire alarm,",
                "Everyone leaves the room,",
                "Ok, now I go!",
                "Found the bag 'Looking in side.. \n nothing in found.'",
                "Tinking: *Where can he hide it??*",
                "Looking around and seeing shine a thing,",
                "A key!",
                "Trying to open the teachers safe,",
                "Anything fall out the safe!",
                "A broken tape,",
                "The teacher has pulled the tape..",
                "*Tuut Taat Tuut Taat* The fire brigade!",
                "Running out of the building,",
                "Goind to home without any succes,"};
                for (int i = 0; i < textArray.Length; i++)
                {
                    sText.OutputText(textArray[i]);
                    player.StoryMessage += ("\n" +textArray[i]);
                    textArray[i] = "";

                }
                player.StoryProgression++;
            }
            else if (player.StoryProgression == 8)
            {
                string[] textArray = new string[30] {
                "Back at the uni, I needed to talk to %%%%%%%%NAME%%%%%%%%%",
                "I took a big breath and stepped in.",
                "'I know about Test05 and how people are getting manipulated' I said to him",
                "'I came for your help'",
                "'I have the cassette but its broken'",
                "'I would assume you were trying to trick me, but I know the people that would want to trick me wouldn't say Test05 out loud' He said to me",
                "'Wait a moment...'",
                "Then he grabbed some device out off the shelve and looked at its display",
                "'Okay, what do you want to know?'",
                "'I want you to help me disable the brain controllers' I said",
                "'I cant help you do the actual process because there would be way to much risk'",
                "'I however can tell you all that is going on'",
                "'A long time ago men discovered a recourse so valuable they kept it from the masses.'",
                "'It is everything your body needs at that time'",
                "'If you consumed it your organs will be clensed causing you to be able to live forever as long as you keep on getting the recourse when your weak'",
                "'This way me and a few hundreds of people are able to live more 3000 years'",
                "'Unforgetely the higher ups within the organisation caused it to go corrupt'",
                "'There's only a few people that wont kill you for talking about it. You're lucky I'm one of them'",
                "'This organisation control how the world develops and can steer it in any direction'",
                "'Recently (3 years ago) they found out a way to develop a chip controlling brains'",
                "'First they started implenting it in powerful people causing them to have more control over the world'",
                "'After their succes they started distrubuting it to the masses'",
                "'It's like a virus because people plant them on each other witouth knowing it'",
                "'People plant it in anyone they can get acces to if they are infected themselves just because they're ordered to by the microchips'",
                "'Halfway in that sentence I heard a familiar voice in the hallway'",
                "'They seemed to be in a worry'",
                "'The next moment 3 man entered the room'",
                "'That moment I knew exactly what whas going to happen'",
                "First they shot the proffessor",
                "I know I am next"
                };
                for (int i = 0; i < textArray.Length; i++)
                {
                    sText.OutputText(textArray[i]);
                    player.StoryMessage += ("\n" + textArray[i]);
                    textArray[i] = "";
                }
                player.StoryProgression++;
                while (true)
                {
                   
                    Console.WriteLine("Game over Thanks for playing");
                    Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey(); Console.ReadKey();
                    System.Threading.Thread.Sleep(2000);
                }
            }
           
        }
        public void OnEvenTimeDescription(object sender, ElapsedEventArgs e)
        {

        }
    }
}
