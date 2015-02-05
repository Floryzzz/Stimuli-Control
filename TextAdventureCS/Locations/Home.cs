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
            // Add items here
      //      Diamond dia = new Diamond("Diamond", true);
        //    items.Add(dia.GetName(), dia);
            // If there is an enemy, set enemy to true
         //   hasEnemy = true;
        }

        public override void Description(Player player)
        {
            SText sText = new SText();
            Console.WriteLine("You're standing in your home.");
            if (player.StoryProgression == 2)
            {
                
                // Insert a nice description
                string[] TextArray = new string[14] {
                "Something doesn't feel right. I need know what is going on.",
                "I should look on internet for clues that may help me understand", 
                "what is going on.",
                "I watched a couple speeches of important people,", 
                "I found information that they seem to show sympthoms.",
                "The sympthom is that they will sometimes say the same word twice.",
  "It's a error caused by the microchip they got implanted.",
  "The people who had implpanted the microchip can control them.",
  "If I don't take any action this could lead to world domination.",
  "I geuss I'm the first who knows what is going on,", 
  " as I didn't found somebody who also knew this.",
  "I need to stop them, but how will I need to do that?",
  "I also need to find some people who will help to aid me,",
  "but where should I look and who can I trust?" };
                for (int i = 0; i < TextArray.Length; i++)
                {
                    sText.OutputText(TextArray[i]);
                    player.StoryMessage += ("\n" + TextArray[i]);
                    TextArray[i] = "";
                    
                }
                player.StoryProgression = 3;
                
                player.StoryMessage = player.StoryMessage.ToString() + "\n";
            }
            else if (player.StoryProgression == 4)
            {
                string[] Textarray = new string[7]
       {
            "What happend to my home?",
            "Alot of things are ransacked, but who did this?",
            "Perhaps they wanted to know what for intel I already gathered.",
            "I must hide the intel I gathered, otherwise it maybe lead to what I'm going to do next",
            "I need to move quick, otherwise will catch me.",
            "I should go to the university to look for that tape.",
            "I must spread the message of the microchips which can control people."
 
       };
                for (int i = 0; i < Textarray.Length; i++)
                {
                    sText.OutputText(Textarray[i]);
                    player.StoryMessage += ("\n" + Textarray[i]);
                    Textarray[i] = "";
                }
                player.StoryProgression = 5;
            }
        }
    }
}
