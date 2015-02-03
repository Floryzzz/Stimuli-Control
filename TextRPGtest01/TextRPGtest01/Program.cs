using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TextRPGtest01
{
    class Program
    {
        public static Timer tmrText = new Timer(100);
        public static string textToInput;
        public static Text text = new Text();
        public static int numberOfCharDone = 0;
        static void Main(string[] args)
        {
            tmrText.Elapsed += OnTimeEventText;
            OutputText("Welcome to Stimuli Control");
            Console.ReadKey();
            OutputText("Some text, blablablabla");
            Console.ReadKey();
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
                Console.WriteLine("\n\t\t\t\t\t\t\tPress any key to continue");
            }
                
        }
        public static void OutputText(string text)
        {
            Console.Clear();
            textToInput = text;
            numberOfCharDone = 0;
            tmrText.Enabled = true;
        }

    }
}
