﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Church : Location
    {
        public Church(string name)
            : base(name)
        {
           
        }

        public override void Description()
        {
            Console.Write("You are standing in front of a church.");
        }
    }
}
