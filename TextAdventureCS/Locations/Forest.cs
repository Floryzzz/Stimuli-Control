﻿using System;
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
            Diamond dia = new Diamond("Diamond", true);
            items.Add(dia.GetName(), dia);
            // If there is an enemy, set enemy to true
            hasEnemy = false;
        }

        public override void Description()
        {
            // Insert a nice description
            Console.WriteLine("You are standing in your home");
        }
    }
}
