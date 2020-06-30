using System;
using System.Collections.Generic;

namespace CastleEscape
{
    /// <summary>
    /// This class handles the player's location, their commands, and inventory
    /// </summary>
    class Player
    {
        //
        public static char PlayerLocation;

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


        public void CheckPlayerLocation()
        {
            if (PlayerLocation == 'S')
            {
                Console.Clear();
                MenuText.DrawPicture(@"Images\South.txt");
                Console.WriteLine($"You moved South");
            }
            else if (PlayerLocation == 'N')
            {
                Console.Clear();
                MenuText.DrawPicture(@"Images\North.txt");
                Console.WriteLine($"You moved North");
            }
            else if (PlayerLocation == 'E')
            {
                Console.Clear();
                MenuText.DrawPicture(@"Images\East.txt");
                Console.WriteLine($"You moved East");
            }
            else if (PlayerLocation == 'W')
            {
                Console.Clear();
                MenuText.DrawPicture(@"Images\West.txt");
                Console.WriteLine($"You moved West");
            }
        }
        //This method handles the commands the player types into the Console
        public void PlayerCommand()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (playerCommand == "SOUTH" || playerCommand == "S")
            {
                if (PlayerLocation == 'S')
                {
                    MenuText.TypeLine("You are already South.\n");
                }
                else
                {
                    PlayerLocation = 'S';
                    CheckPlayerLocation();
                }
            }
            else if (playerCommand == "NORTH" || playerCommand == "N")
            {
                if (PlayerLocation == 'N')
                {
                    MenuText.TypeLine("You are already North.\n");
                }
                else
                {
                    PlayerLocation = 'N';
                    CheckPlayerLocation();
                }
            }
            else if (playerCommand == "EAST" || playerCommand == "E")
            {
                if (PlayerLocation == 'E')
                {
                    MenuText.TypeLine("You are already East.\n");
                }
                else
                {
                    PlayerLocation = 'E';
                    CheckPlayerLocation();
                }
            }
            else if (playerCommand == "WEST" || playerCommand == "W")
            {
                if (PlayerLocation == 'W')
                {
                    MenuText.TypeLine("You are already West.\n");
                }
                else
                {
                    PlayerLocation = 'W';
                    CheckPlayerLocation();
                }
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
                Look.LookCommand();
            }
            else if (playerCommand.Contains("USE") == true)
            {
                UsableItems.UseItemCommand(playerCommand);
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