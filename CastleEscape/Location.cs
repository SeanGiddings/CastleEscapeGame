using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Location
    {
        public static void Look()
        {
            
            if (Player.PlayerLocation == 'S')
            {
                //String SKeyword = MenuText.ChangeToRed("BED");
               // Program.TypeLine($"You see the {SKeyword} you woke up on.");
                SouthLook();
            }
            else if (Player.PlayerLocation == 'N')
            {
                Program.TypeLine("You see a MIRROR.");
            }
            else if (Player.PlayerLocation == 'E')
            {
                Program.TypeLine("You see a WINDOW.");
            }
            else if (Player.PlayerLocation == 'W')
            {
                Program.TypeLine("You see a DESK.");
            }
        }

        public static void SouthLook()
        {
                Program.TypeLine("You see the ");
                MenuText.ChangeToRed("BED", "Red");
                Program.TypeLine(" you woke up on.\n");
        }

            public static void UseItem(string useCommand)
        {
            if (useCommand == "USE COMPASS")
                {
                    Program.TypeLine("There are four sides to this room. To the North, a MIRROR. To the East, a DESK. To the South, a BED. To the West, a WINDOW.");
                }
            if (Player.PlayerLocation == 'S')
            {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You are south and you have a key and you used a key");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                if (useCommand == "USE BED" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed and notice something inside the pillow... A KEY? You put it in your bag.");
                    Player.inventory.Add("KEY");
                }
                else if (useCommand == "USE BED" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed, and remember finding the KEY inside the pillow. There's nothing else to find here.");
                }
            }
            else if (Player.PlayerLocation == 'N')
            {
                Program.TypeLine("You see a MIRROR.");
            }
            else if (Player.PlayerLocation == 'E')
            {
                Program.TypeLine("You see a WINDOW.");
            }
            else if (Player.PlayerLocation == 'W')
            {
                Program.TypeLine("You see a DESK.");
            }
        }



            public Location()
        {
                
        }

    }
}