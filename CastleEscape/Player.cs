using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Player
    {
        //Player always starts to the South of the room.
        public char PlayerLocation = 'S';

        public delegate void PlayerLocationEvents(char currentPlayerLocation);
        public static event PlayerLocationEvents locationChanged;
        public bool IsPlaying = false;
        List<string> inventory = new List<string>();

        public Player()
        {
            IsPlaying = true;
            inventory.Add("Compass");

            //This while loop ensures the game always reverts back to the player command prompt)
            while (IsPlaying)
            {
                PlayerCommand();
            }
        }

        public void HelpMenu()
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

        public void CheckPlayerLocation()
        {
            if (PlayerLocation == 'S')
            {
                Console.WriteLine($"You are South");
            }
            else if (PlayerLocation == 'N')
            {
                Console.WriteLine($"You are North");
            }
            else if (PlayerLocation == 'E')
            {
                Console.WriteLine($"You are East");
            }
            else if (PlayerLocation == 'W')
            {
                Console.WriteLine($"You are West");
            }
        }

        public void PlayerCommand()
        {
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            if (playerCommand == "SOUTH" || playerCommand == "S")
            {
                PlayerLocation = 'S';
                locationChanged?.Invoke(PlayerLocation);
                CheckPlayerLocation();
            }
            else if (playerCommand == "NORTH" || playerCommand == "N")
            {
                PlayerLocation = 'N';
                locationChanged?.Invoke(PlayerLocation);
                CheckPlayerLocation();
            }
            else if (playerCommand == "EAST" || playerCommand == "E")
            {
                PlayerLocation = 'E';
                locationChanged?.Invoke(PlayerLocation);
                if (!CheckInventory("KEY"))
                {
                    inventory.Add("KEY");
                }
                CheckPlayerLocation();
            }
            else if (playerCommand == "WEST" || playerCommand == "W")
            {
                PlayerLocation = 'W';
                locationChanged?.Invoke(PlayerLocation);
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
            else if (playerCommand == "HELP")
            {
                HelpMenu();
            }
        }

        public bool CheckInventory(string itemName)
        {
            return inventory.Contains(itemName);
        }


    }
}