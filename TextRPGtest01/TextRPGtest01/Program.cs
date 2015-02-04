using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGtest01
{
    class Program
    {
        public static Text text = new Text();
  
        static void Main(string[] args)
        {
            //text.OutputText("Welcome to Stimuli Control");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/new/Desktop/eminem.wav";
            player.Play();



            Console.ReadKey();
        }
    }
}
