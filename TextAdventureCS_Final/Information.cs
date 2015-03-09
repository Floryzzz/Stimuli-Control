using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureCS
{
    class Information
    {
        public string infoText;

        public Information()
        {
            infoText = "";
        }
        public void AddInfoMessage()
        {
            Console.WriteLine("\t" + this.infoText);
        }
    }
}
