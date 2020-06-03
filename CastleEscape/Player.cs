using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Player
    {
        //Player always starts to the South of the room.
        public static char PlayerLocation = 'S';

        public delegate void PlayerLocationEvents(List<string> currentInventory);
        public static event PlayerLocationEvents wentNorth;
        public static event PlayerLocationEvents wentSouth;
        public static event PlayerLocationEvents wentWest;
        public static event PlayerLocationEvents wentEast;

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
                wentSouth?.Invoke(inventory);
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
                if (!CheckInventory("KEY"))
                {
                    inventory.Add("KEY");
                }
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
            else if (playerCommand == "HELP")
            {
                MenuText.HelpMenu();
            }
            else if (playerCommand == "LOOK")
            {
                //Program.TypeLine("You see the BED you woke up on.");
                Location.Look();
            }
            else 
            {
                Console.WriteLine($"\"{playerCommand}\" is not a proper command. Please type \"HELP\" for all available commands");
            }
        }

        public bool CheckInventory(string itemName)
        {
            return inventory.Contains(itemName);
        }


    }
}