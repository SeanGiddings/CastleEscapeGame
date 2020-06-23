using System;

namespace CastleEscape
{
    //This class handles Beginning/Ending text, as well as 'pictures'
    class MenuText
    {
        string[] usableWords = { "KEY", "BED", "MIRROR", "COMPASS", "WINDOW", "STONE", "STONES", "DESK", "JOURNAL", "MAGIC BOOK", "SECRET COMPARTMENT" };

        public static void TitleCard()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n A Text Adventure Game By Sean Giddings");
            System.Threading.Thread.Sleep(2000);
            Program.TypeLine("\n \n \n");
            MenuText.HelpMenu();
            Program.TypeLine("\n \n \n Hit ENTER to begin");
            Console.ReadLine();
        }

        public static void OpeningText()
        {
            int textDelay = 500;
            Console.Clear();
            Program.TypeLine("\n \n \nYou wake up, with a start! \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You are laying on a small, hard ");
            MenuText.ChangeTextColor("BED", ConsoleColor.Red);
            Program.TypeLine(" in an otherwise (almost) empty room. You have a small ");
            MenuText.ChangeTextColor("COMPASS", ConsoleColor.Red);
            Program.TypeLine(" in your pocket, but no other belongings.\n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("At the North end of the room, there is a large ornate ");
            MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
            Program.TypeLine(". \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("On the East side of the room, a ");
            MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
            Program.TypeLine(". \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("To the West, a ");
            MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
            Program.TypeLine(". \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("The ");
            MenuText.ChangeTextColor("BED", ConsoleColor.Red);
            Program.TypeLine(" you are currently sitting on is to the South.\n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You look around the small room, and see the sparse decorations, the stone walls, the single ");
            MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
            Program.TypeLine(" with only the sky in view. \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("You seem to be in a tower. \n");
            System.Threading.Thread.Sleep(textDelay);
            Program.TypeLine("There seems to be no way in or out. \n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.TypeLine("For Help/Intructions, type \"HELP\" \n");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void YouWin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" __   __            _____                              _ _ ");
            Console.WriteLine(" \\ \\ / /__  _   _  | ____|___  ___ __ _ _ __   ___  __| | |");
            Console.WriteLine("  \\ V / _ \\| | | | |  _| / __|/ __/ _` | '_ \\ / _ \\/ _` | |");
            Console.WriteLine("   | | (_) | |_| | | |___\\__ \\ (_| (_| | |_) |  __/ (_| |_|");
            Console.WriteLine("   |_|\\___/ \\__,_| |_____|___/\\___\\__,_| .__/ \\___|\\__,_(_)");
            Console.WriteLine("                                       |_|                 ");
            PlayAgain();
        }
        public static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ____    _    __  __ _____    _____     _______ ____  ");
            Console.WriteLine("  / ___|  / \\  |  \\/  | ____|  / _ \\ \\   / / ____|  _ \\ ");
            Console.WriteLine(" | |  _  / _ \\ | |\\/| |  _|   | | | \\ \\ / /|  _| | |_) |");
            Console.WriteLine(" | |_| |/ ___ \\| |  | | |___  | |_| |\\ V / | |___|  _ < ");
            Console.WriteLine("  \\____/_/   \\_\\_|  |_|_____|  \\___/  \\_/  |_____|_| \\_\\");
            Console.WriteLine("                                                        ");
            PlayAgain();
        }

        public static void PlayAgain()
        {
            Program.TypeLine("\nWould You like to play again?\n");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            Console.ForegroundColor = ConsoleColor.Red;
            if (playerCommand == "YES" || playerCommand == "Y")
            {
                Game game = new Game();
            }
            else if (playerCommand == "NO" || playerCommand == "N")
            {
                Player.IsPlaying = false;
            }
            else
            {
                Console.WriteLine($"\"{playerCommand}\" is not a proper command. Please type YES or NO.");
                PlayAgain();
            }
        }

        public static void StoneFinalChoice()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (playerCommand == "YES" || playerCommand == "Y")
            {
                Program.TypeLine("\nYou throw the stone as hard as you can at the mirror. \nThere is a huge flash of light. And then--\nWhere the ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(" stood, there is now a doorway, with a spiral staircase that descends into darkness. \nYou take a deep breath and begin your descent.\n");
                MenuText.YouWin();
            }
            else if (playerCommand == "NO" || playerCommand == "N")
            {
                Program.TypeLine("\nYou put the ");
                MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                Program.TypeLine(" back into your pocket and step away from the ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(". \n");
            }
            else
            {
                Console.WriteLine($"\"{playerCommand}\" is not a proper command. Please type YES or NO.");
                StoneFinalChoice();
            }
        }
        public static void BookFinalChoice()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (playerCommand == "YES" || playerCommand == "Y")
            {
                Program.TypeLine("\nThere is a flash of light. When you open your eyes, everything around you is dark. \nBefore you, you see the ");
                MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                Program.TypeLine(" standing in the tower you were trapped in. \nHe continues to laugh, silently, as he picks up a ");
                MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                Program.TypeLine(" and throws it at you. \nYour view shatters, and everything goes black.\n");
                MenuText.GameOver();
                Player.IsPlaying = false;
            }
            else if (playerCommand == "NO" || playerCommand == "N")
            {
                Program.TypeLine("\nYou put the ");
                MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                Program.TypeLine(" back into your pocket and step away from the ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(". \n");
            }
            else
            {
                Console.WriteLine($"\"{playerCommand}\" is not a proper command. Please type YES or NO.");
                BookFinalChoice();
            }
        }

        public static void HelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===                 Instructions                 ===");
            Console.WriteLine("=== To choose a direction, write N, S, E, or W   ===");
            Console.WriteLine("=== To examine your surroundings, write LOOK     ===");
            Console.WriteLine("=== To use an item, type USE ______________      ===");
            Console.Write("=== (For example, \"USE ");
            MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\" or \"USE ");
            MenuText.ChangeTextColor("COMPASS", ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\")    ===");
            Console.Write("\n=== Any ");
            MenuText.ChangeTextColor("ITEM", ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" that is Red can be used             ===");
            Console.WriteLine("\n=== To see your inventory type INV               ===");
            Console.WriteLine("=== To see this menu again, type HELP            ===");
            Console.WriteLine("=== To end the game, type EXIT                   ===");
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public static void DrawPicture(string filePath) 
        {

                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Sean\github\CastleEscape\CastleEscape\Images\North.txt");

            // Display the file contents by using a foreach loop.

        }

        public static void ChangeTextColor(string keyword, ConsoleColor newColor)
        {

            /*ConsoleColor consoleColor = ConsoleColor.White;
            try
            {
                consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), newColor, true);
            }
            catch (Exception)
            {
                //Invalid color
            }

            Console.ForegroundColor = consoleColor;*/
            Console.ForegroundColor = newColor;
            Program.TypeLine(keyword);
            Console.ForegroundColor = ConsoleColor.Blue;
        }



        public MenuText()
        {

        }
    }
}
