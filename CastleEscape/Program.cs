using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Program
    {
        //Debug = true will turn off the opening text scroll for quick debugging
        private static bool Debug = true;

        //This adds the "typing" effect
        public static void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(20); // Sleep for 150 milliseconds
                if (i == line.Length - 1)
                {
                    Console.Write("\n");
                }
            }
        }

        private static void InventoryCheck(List<string> currentInventory) {
            currentInventory.ForEach(Console.WriteLine);
        }


        static void Main(string[] args)
        {
            Player.wentSouth += InventoryCheck;

            Console.ForegroundColor = ConsoleColor.Blue;
            if (Debug == false) 
            {
                MenuText.TitleCard();
                MenuText.OpeningText();
            }
            System.Threading.Thread.Sleep(1000);
            TypeLine("Where would you like to go?");
            Player player = new Player();
        }
    }
}
