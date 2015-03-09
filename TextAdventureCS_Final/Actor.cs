using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Actor
    {
        protected int[] indexAnswerEvent;
        protected string[,] text;
        protected string name;
        
        public Actor( string name)
        {
            this.name = name;
        }
       

        public string GetName()
        {
            return name;
        }

        public void Text(Player player)
        {
            int questionIndex = 0;
            do
            {
                for (int i = 0; i < indexAnswerEvent.Length; i++)
                    if (indexAnswerEvent[i] == questionIndex)
                        if (i == 0)
                            Action1(player);
                        else if (i == 1)
                            Action2(player);
                        

                questionIndex = player.Discussion(name, text[questionIndex, 0], text[questionIndex, 1], text[questionIndex, 2], int.Parse(text[questionIndex, 3]),int.Parse(text[questionIndex,4]));
            } while (questionIndex != 7);
        }
        abstract public void Action1(Player player);
        abstract public void Action2(Player player);
    }
}
