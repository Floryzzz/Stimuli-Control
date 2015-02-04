using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    abstract class Actor
    {
        protected string name;
        
        public Actor( string name)
        {
            this.name = name;
        }
       

        public string GetName()
        {
            return name;
        }
    }
}
