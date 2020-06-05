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
                SouthLook();
            }
            else if (Player.PlayerLocation == 'N')
            {
                NorthLook();
            }
            else if (Player.PlayerLocation == 'E')
            {
                EastLook();
            }
            else if (Player.PlayerLocation == 'W')
            {
                WestLook();
            }
        }

        public static void SouthLook()
        {
            Program.TypeLine("You see the ");
            MenuText.ChangeTextColor("BED", ConsoleColor.Red);
            Program.TypeLine(" you woke up on.\n");
        }
        public static void NorthLook()
        {
            Program.TypeLine("You see an ancient, mysterious ");
            MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
            Program.TypeLine(" with runes etched across both sides.\n");
        }
        public static void EastLook()
        {
            Program.TypeLine("You see a modest wooden writing ");
            MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
            Program.TypeLine(", with an open ");
            MenuText.ChangeTextColor("BOOK", ConsoleColor.Red);
            Program.TypeLine(" sitting on top.\n");
        }
        public static void WestLook()
        {
            Program.TypeLine("You see a small ");
            MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
            Program.TypeLine(" that is far too narrow to climb out of.\n");
        }

        public static void UseItem(string useCommand)
        {
            if (useCommand == "USE COMPASS")
            {
                Program.TypeLine("There are four sides to this room. \nTo the North, a ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(".\nTo the East, ");
                MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                Program.TypeLine(".\nTo the South, a ");
                MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                Program.TypeLine(".\nTo the West, a ");
                MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                Program.TypeLine(".\n");
            }
            if (Player.PlayerLocation == 'S')
            {
                SouthUseItem(useCommand);
            }
            else if (Player.PlayerLocation == 'N')
            {
                NorthUseItem(useCommand);
            }
            else if (Player.PlayerLocation == 'E')
            {
                Program.TypeLine("You see a WINDOW.");
            }
            else if (Player.PlayerLocation == 'W')
            {
                WestUseItem(useCommand);
            }
        }

        public static void SouthUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You are south and you have a key and you used a key");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE BED" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed and notice something inside the pillow... A ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine("? You put it in your bag.\n");
                    Player.inventory.Add("KEY");
                }
                else if (useCommand == "USE BED" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed, and remember finding the ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine(" inside the pillow. There's nothing else to find here.\n");
                }  
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }
        public static void NorthUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You havent found a reason to use a key here.");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE MIRROR")
                {
                    Program.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" and instead of seeing your reflection, you see a ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    Program.TypeLine(" motioning to the Runes on either side. \nPerhaps if you could decipher them, you could learn more about the Man trapped in the mirror?");
                }
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }

        public static void WestUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You havent found a reason to use a key here.");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE WINDOW")
                {
                    Program.TypeLine("You look out the small ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    Program.TypeLine(" and gasp! \nThe tower you are in goes down into the clouds. You cannot see the ground below, and start to get the sinking feeling there might be ");
                    MenuText.ChangeTextColor("magic", ConsoleColor.Cyan);
                    Program.TypeLine(" at play here.");
                }
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }



        public Location()
        {

        }

    }
}