using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TextAdventureCS
{
    class SText
    {
        public static string textToInput;
        public static Timer tmrText = new Timer(100);
        public static int numberOfCharDone = 0;
        public SText()
        {
            tmrText.Elapsed += OnTimeEventText;
        }

        private static void OnTimeEventText(object sender, ElapsedEventArgs e)
        {
            if (numberOfCharDone < textToInput.Length)
            {
                Console.Write(textToInput[numberOfCharDone]);
                numberOfCharDone++;
            }
            else
            {
                tmrText.Enabled = false;
                Console.WriteLine("\n\t\t\t\t\t\tPress any key to continue");
            }

        }
        public void OutputText(string text)
        {
            Console.Clear();
            textToInput = text;
            numberOfCharDone = 0;
            tmrText.Enabled = true;
        }
    }
}
