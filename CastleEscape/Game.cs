using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Game
    {
        //Debug = true will turn off the opening text scroll for quick debugging
        private static bool Debug = true;
        public Game()
        {
            //Player.wentSouth += InventoryCheck;

            Console.ForegroundColor = ConsoleColor.Blue;
            if (Debug == false) 
            {
                MenuText.TitleCard();
                MenuText.OpeningText();
            }
            
            Program.TypeLine("Where would you like to go?");
            Location location = new Location();
            Player player = new Player();
        }

    }
}