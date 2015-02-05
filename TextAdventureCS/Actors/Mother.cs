using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Mother : Actor
    {
        public Mother(string name)
            : base(name)
        {

            indexAnswerEvent = new int[] { 4, 6 };
            text = new string[7, 5]{
                {"Hi son what are you doing here ?","I just come to drink some tea with you","Mom, i need your help","1","2"},
                {"Ok, get a seat, i will come back with the tea,so, what's new with you ?","I have some problem to resolve","Nothing, i need to go now, bye","2","7"},
                {"What kind of help do you need ?","Mom, i have some drugs problem","i need some money to go to Russia","5","3"},
                {"Why do you need money, do you have any problem ?","I will to talk to a russian friend","I need to by some drugs","4","5"},
                {"Ok, here is 200, take it","Thank you mom","Sorry but i need 600","7","6"},
                {"Drugs problem, I call the police","sry mom, bye","Fuck you mom !, i'm out","7","7"},
                {"Ok take it (she give you 600),","bye mom i love you so much","Bye mom, I'M RICH !","7","7"}
            };
        }
        public override void Action1(Player player)
        {
            player.AddMoney(200);
        }
        public override void Action2(Player player)
        {
            player.AddMoney(400);
        }

    }
}
