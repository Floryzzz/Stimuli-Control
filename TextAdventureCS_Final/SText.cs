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
        public static Timer tmrText = new Timer(50);
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

                

        }
        public void OutputText(string text)
        {
            textToInput = text;
            numberOfCharDone = 0;
            tmrText.Enabled = true;
            Console.ReadKey();
            tmrText.Enabled = false;
            Console.SetCursorPosition(numberOfCharDone, Console.CursorTop);
            for (int i = numberOfCharDone; i < textToInput.Length; i++)
            {
                Console.Write(textToInput[i]);
            }
            Console.WriteLine();
            
        }
    }
}
