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
            MenuText.ChangeTextColor("BED", "Red");
            Program.TypeLine(" you woke up on.\n");
        }
        public static void NorthLook()
        {
            Program.TypeLine("You see an ancient, mysterious ");
            MenuText.ChangeTextColor("MIRROR", "Red");
            Program.TypeLine(" with runes etched across both sides.\n");
        }
        public static void EastLook()
        {
            Program.TypeLine("You see a modest wooden writing ");
            MenuText.ChangeTextColor("DESK", "Red");
            Program.TypeLine(", with an open ");
            MenuText.ChangeTextColor("BOOK", "Red");
            Program.TypeLine(" sitting on top.\n");
        }
        public static void WestLook()
        {
            Program.TypeLine("You see a small ");
            MenuText.ChangeTextColor("WINDOW", "Red");
            Program.TypeLine(" that is far too narrow to climb out of.\n");
        }

        public static void UseItem(string useCommand)
        {
            if (useCommand == "USE COMPASS")
            {
                Program.TypeLine("There are four sides to this room. \nTo the North, a ");
                MenuText.ChangeTextColor("MIRROR", "Red");
                Program.TypeLine(".\nTo the East, ");
                MenuText.ChangeTextColor("DESK", "Red");
                Program.TypeLine(".\nTo the South, a ");
                MenuText.ChangeTextColor("BED", "Red");
                Program.TypeLine(".\nTo the West, a ");
                MenuText.ChangeTextColor("WINDOW", "Red");
                Program.TypeLine(".\n");
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
                    Program.TypeLine("You climb into the rough bed and notice something inside the pillow... A ");
                    MenuText.ChangeTextColor("KEY", "Red");
                    Program.TypeLine("? You put it in your bag.\n");
                    Player.inventory.Add("KEY");
                }
                else if (useCommand == "USE BED" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed, and remember finding the ");
                    MenuText.ChangeTextColor("KEY", "Red");
                    Program.TypeLine(" inside the pillow. There's nothing else to find here.\n");
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