using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Program
    {

        static void TitleCard()
        {
            /*Console.WriteLine("You are about to begin");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);*/
            Console.WriteLine(" ▄████▄   ▄▄▄        ██████ ▄▄▄█████▓ ██▓    ▓█████    ▓█████   ██████ ▄████▄   ▄▄▄       ██▓███  ▓█████ ");
            Console.WriteLine("▒██▀ ▀█  ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓██▒    ▓█   ▀    ▓█   ▀ ▒██    ▒▒██▀ ▀█  ▒████▄    ▓██░  ██▒▓█   ▀ ");
            Console.WriteLine("▒▓█    ▄ ▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██░    ▒███      ▒███   ░ ▓██▄  ▒▓█    ▄ ▒██  ▀█▄  ▓██░ ██▓▒▒███   ");
            Console.WriteLine("▒▓▓▄ ▄██▒░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒██░    ▒▓█  ▄    ▒▓█  ▄   ▒   ██▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██▄█▓▒ ▒▒▓█  ▄ ");
            Console.WriteLine("▒ ▓███▀ ░ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░██████▒░▒████▒   ░▒████▒▒██████▒▒ ▓███▀ ░ ▓█   ▓██▒▒██▒ ░  ░░▒████▒");
            Console.WriteLine("░ ░▒ ▒  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▓  ░░░ ▒░ ░   ░░ ▒░ ░▒ ▒▓▒ ▒ ░ ░▒ ▒  ░ ▒▒   ▓▒█░▒▓▒░ ░  ░░░ ▒░ ░");
            Console.WriteLine("  ░  ▒     ▒   ▒▒ ░░ ░▒  ░ ░    ░    ░ ░ ▒  ░ ░ ░  ░    ░ ░  ░░ ░▒  ░ ░ ░  ▒     ▒   ▒▒ ░░▒ ░      ░ ░  ░");
            Console.WriteLine("░          ░   ▒   ░  ░  ░    ░        ░ ░      ░         ░   ░  ░  ░ ░          ░   ▒   ░░          ░   ");
            Console.WriteLine("░ ░            ░  ░      ░               ░  ░   ░  ░      ░  ░      ░ ░ ░            ░  ░            ░  ░");
            Console.WriteLine("░                                                                     ░                                  ");

            Console.WriteLine("A Text Adventure Game By Sean Giddings");
            System.Threading.Thread.Sleep(2000);
            TypeLine("\n \n \n Hit ENTER to begin");
            Console.ReadLine();
        }


        static void OpeningText()
        {
            int textDelay = 0;
            TypeLine("\n \n \nYou wake up, with a start! \n");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("You are laying on a small, hard BED in an otherwise (almost) empty room. You have a small COMPASS in your pocket, but no other belongings.\n");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("At the NORTH end of the room, there is a large ornate MIRROR.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("On the EAST side of the room, a WINDOW.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("To the WEST, a DESK.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("The BED you are currently sitting on is to the SOUTH.\n");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("You look around the small room, and see the sparse decorations, the stone walls, the single WINDOW with only the sky in view.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("You seem to be in a tower.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("There seems to be no way in or out.");
            System.Threading.Thread.Sleep(textDelay);
            TypeLine("Where would you like to go?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeLine("For Help/Intructions, type \"HELP\"");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

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

        private static void InventoryCheck(List<string> currentInventory)
        {
            currentInventory.ForEach(Console.WriteLine);
        }


        static void Main(string[] args)
        {
            Player.wentSouth += InventoryCheck;

            //Debug = true will turn off the opening text scroll for quick debugging
        private bool debugMode;

        Console.ForegroundColor = ConsoleColor.Blue;
            if (debugMode == false) 
            {
                TitleCard();
        OpeningText();
    }
    Player player = new Player();
}
    }
}
