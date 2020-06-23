using System;
using System.Collections.Generic;

namespace CastleEscape
{
    //This class creates a new game
    class Game
    {
        //Debug = true will turn off the opening text scroll for quick debugging
        private static bool Debug = false;

        public Game()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Debug == false)
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