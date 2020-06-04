using System;

namespace CastleEscape
{
    class MenuText
    {
        public static void TitleCard()
        {
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

            Console.WriteLine("\n A Text Adventure Game By Sean Giddings");
            System.Threading.Thread.Sleep(2000);
            Program.TypeLine("\n \n \n Hit ENTER to begin");
            Console.ReadLine();
        }


        public static void OpeningText()
        {
            int textDelay = 0;
            Program.TypeLine("\n \n \nYou wake up, with a start! \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You are laying on a small, hard BED in an otherwise (almost) empty room. You have a small COMPASS in your pocket, but no other belongings.\n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("At the NORTH end of the room, there is a large ornate MIRROR.");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("On the EAST side of the room, a DESK.");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("To the WEST, a WINDOW.");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("The BED you are currently sitting on is to the SOUTH.\n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You look around the small room, and see the sparse decorations, the stone walls, the single WINDOW with only the sky in view.");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You seem to be in a tower.");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("There seems to be no way in or out.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.TypeLine("For Help/Intructions, type \"HELP\"");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void HelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===                 HELP MENU                    ===");
            Console.WriteLine("=== To choose a direction, write N, S, E, or W   ===");
            Console.WriteLine("=== To examine your surroundings, write LOOK     ===");
            Console.WriteLine("=== To use an item, type USE ______________      ===");
            Console.WriteLine("=== (For example, \"USE KEY\" or \"USE COMPASS\")    ===");
            Console.WriteLine("=== To see your inventory type INV               ===");
            Console.WriteLine("=== To see this menu again, type HELP            ===");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void ChangeTextColor(string keyword, string newColor)
        {

            ConsoleColor consoleColor = ConsoleColor.White;
            try
            {
                consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), newColor, true);
            }
            catch (Exception)
            {
                //Invalid color
            }

            Console.ForegroundColor = consoleColor;
            //Console.ForegroundColor = ConsoleColor.newColor;
            Program.TypeLine(keyword);
            Console.ForegroundColor = ConsoleColor.Blue;
        }



        public MenuText()
        {

        }
    }
}
