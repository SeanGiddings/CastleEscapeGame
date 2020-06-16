using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Game
    {
        //Debug = true will turn off the opening text scroll for quick debugging
        private static bool Debug = false;
        /*
                private static void InventoryCheck(List<string> currentInventory)
                {
                    currentInventory.ForEach(Console.WriteLine);
                }
        */
        public Game()
        {
            //Player.wentSouth += InventoryCheck;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Debug == true)
            {
                MenuText.TitleCard();
                MenuText.OpeningText();
            }

            Program.TypeLine("What would you like to do?\n");
            Location location = new Location();
            Player player = new Player();
        }

    }
}