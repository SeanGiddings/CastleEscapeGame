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
            if (Player.PlayerLocation == 'S')
            {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You are south and you have a key and you used a key");
                }
                else
                {
                    Program.TypeLine("You dont have a key");
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