using System;
using System.Collections.Generic;

namespace CastleEscape
{
    /// <summary>
    /// This class creates a new game
    /// </summary>
    class Game
    {
        // Debug = true will turn off the opening text scroll for quick debugging
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

            MenuText.TypeLine("What would you like to do?\n");
            UsableItems UsableItems = new UsableItems();
            Player player = new Player();
        }

    }
}