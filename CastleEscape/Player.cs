using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Player
    {
        
        public static char PlayerLocation;

        public delegate void PlayerLocationEvents(List<string> currentInventory);
        public static event PlayerLocationEvents wentNorth;
        public static event PlayerLocationEvents wentSouth;
        public static event PlayerLocationEvents wentWest;
        public static event PlayerLocationEvents wentEast;

        public static bool IsPlaying = false;
        public static List<string> inventory = new List<string>();

        public Player()
        {
            IsPlaying = true;
            //Player always starts to the South of the room.
            PlayerLocation = 'S';
            inventory.Clear();
            inventory.Add("COMPASS");

            //This while loop ensures the game always reverts back to the player command prompt)
            while (IsPlaying)
            {
                PlayerCommand();
            }
        }

        public static void DrawPicture() //string ImagePath
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Sean\github\CastleEscape\CastleEscape\Images\North.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }


        public void CheckPlayerLocation()
        {
            if (PlayerLocation == 'S')
            {
                Console.Clear();
                Console.WriteLine($"You are South");
            }
            else if (PlayerLocation == 'N')
            {
                Console.Clear();
                Console.WriteLine($"You are North");
            }
            else if (PlayerLocation == 'E')
            {
                Console.Clear();
                Console.WriteLine($"You are East");
            }
            else if (PlayerLocation == 'W')
            {
                Console.Clear();
                Console.WriteLine($"You are West");
            }
        }

        public void PlayerCommand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (playerCommand == "SOUTH" || playerCommand == "S")
            {
                PlayerLocation = 'S';
                //wentSouth?.Invoke(inventory);
                CheckPlayerLocation();
            }
            else if (playerCommand == "NORTH" || playerCommand == "N")
            {
                PlayerLocation = 'N';
                wentNorth?.Invoke(inventory);
                CheckPlayerLocation();
            }
            else if (playerCommand == "EAST" || playerCommand == "E")
            {
                PlayerLocation = 'E';
                wentEast?.Invoke(inventory);
                CheckPlayerLocation();
            }
            else if (playerCommand == "WEST" || playerCommand == "W")
            {
                PlayerLocation = 'W';
                wentWest?.Invoke(inventory);
                CheckPlayerLocation();
            }
            else if (playerCommand == "EXIT")
            {
                IsPlaying = false;
            }
            else if (playerCommand == "INVENTORY" || playerCommand == "INV")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Your bag contains:");
                inventory.ForEach(Console.WriteLine);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (playerCommand == "LIST")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Location.usableItems.ForEach(Console.WriteLine);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (playerCommand == "HELP")
            {
                MenuText.HelpMenu();
            }
            else if (playerCommand == "LOOK")
            {
                Location.Look();
            }
            else if (playerCommand.Contains("USE") == true)
            {
                Location.UseItemCommand(playerCommand);
            }
            else
            {
                Console.WriteLine($"\"{playerCommand}\" is not a proper command. Please type \"HELP\" for all available commands");
            }
        }

        public static bool CheckInventory(string itemName)
        {
            return inventory.Contains(itemName);
        }

    }
}