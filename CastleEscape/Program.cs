using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Program
    {
        //This adds the "typing" effect
        public static void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(20); // Sleep for 150 milliseconds
                if (i == line.Length - 1)
                {
                    //Console.Write("\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Game game = new Game();
        }
    }
}
