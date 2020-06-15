using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Location
    {

        public static List<string> usableItems = new List<string>();


        public Location()
        {
            usableItems.Add("USE MIRROR");
            usableItems.Add("USE KEY");
            usableItems.Add("USE BED");
            usableItems.Add("USE COMPASS");
            usableItems.Add("USE WINDOW");
            usableItems.Add("USE STONE");
            usableItems.Add("USE STONES");
            usableItems.Add("USE DESK");
            usableItems.Add("USE JOURNAL");
            usableItems.Add("USE MAGIC BOOK");
            usableItems.Add("USE SECRET COMPARTMENT");
        }


        public static void Look()
        {
            SouthLook();
            NorthLook();
            EastLook();
            WestLook();
        }

        public static void SouthLook()
        {
            if (Player.PlayerLocation == 'S')
            {
                Program.TypeLine("You see the ");
                MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                Program.TypeLine(" you woke up on.\n");
            }
        }
        public static void NorthLook()
        {
            if (Player.PlayerLocation == 'N')
            {
                //Player.DrawPicture();
                Program.TypeLine("You see an ancient, mysterious ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(" with runes etched across both sides.\n");
            }
        }
        public static void EastLook()
        {
            if (Player.PlayerLocation == 'E')
            {
                Program.TypeLine("You see a modest wooden writing ");
                MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                Program.TypeLine(", with an open ");
                MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                Program.TypeLine(" sitting on top.\n");
            }
        }
        public static void WestLook()
        {
            if (Player.PlayerLocation == 'W')
            {
                Program.TypeLine("You see a small ");
                MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                Program.TypeLine(" that is far too narrow to climb out of.\n Below the open window is some broken glass, and a handful of small ");
                MenuText.ChangeTextColor("STONES", ConsoleColor.Red);
                Program.TypeLine(".\n");
            }
        }

        public static void UseItemCommand(string useCommand)
        {
            if (usableItems.Contains(useCommand))
            {
                UseMirror(useCommand);
                UseKey(useCommand);
                UseBed(useCommand);
                UseCompass(useCommand);
                UseWindow(useCommand);
                UseStone(useCommand);
                UseDesk(useCommand);
                UseJournal(useCommand);
                UseMagicBook(useCommand);
                UseSecretCompartment(useCommand);
            }
            else
            {
                Program.TypeLine($"{useCommand} is not a proper command. Type ");
                MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                Program.TypeLine(" for assitance with the USE command.\n");
            }
        }

        public static void UseMirror(string useCommand)
        {
            if (useCommand == "USE MIRROR")
            {
                if (Player.PlayerLocation == 'N')
                {
                    Program.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" and instead of seeing your reflection, you see a ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    Program.TypeLine(" motioning to the Runes on either side. \nPerhaps if you could decipher them, you could learn more about the Man trapped in the mirror?\n");
                }
                else
                {
                    Program.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseKey(string useCommand)
        {
            if (useCommand == "USE KEY")
            {
                if (!Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine(".\n");
                }
                else if (Player.CheckInventory("KEY") && !(Player.PlayerLocation == 'E'))
                {
                    Program.TypeLine("There is no reason to use a ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine(" here.\n");
                }
                else if (Player.PlayerLocation == 'E' && (useCommand == "USE KEY" && Player.CheckInventory("KEY") && !Player.CheckInventory("MAGIC BOOK")))
                {
                    Program.TypeLine("You unlock the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(" with a *click*. \nInside, you find a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    Program.TypeLine(". \nYou take it.\n");
                    Player.inventory.Add("MAGIC BOOK");
                }
            }
        }

        public static void UseBed(string useCommand)
        {
            if (useCommand == "USE BED")
            {
                if (Player.PlayerLocation == 'S')
                {
                    if (!Player.CheckInventory("KEY"))
                    {
                        Program.TypeLine("You climb into the rough bed and notice something inside the pillow... A ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        Program.TypeLine("? You put it in your bag.\n");
                        Player.inventory.Add("KEY");
                    }
                    else if (Player.CheckInventory("KEY"))
                    {
                        Program.TypeLine("You climb into the rough bed, and remember finding the ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        Program.TypeLine(" inside the pillow. There's nothing else to find here.\n");
                    }
                }
                else
                {
                    Program.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                    Program.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseCompass(string useCommand)
        {
            static void CompassText()
            {
                {
                    Program.TypeLine("There are four sides to this room. \nTo the North, a ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(".\nTo the East, ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(".\nTo the South, a ");
                    MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                    Program.TypeLine(".\nTo the West, a ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                }
            }
            if (useCommand == "USE COMPASS")
            {
                if (Player.PlayerLocation == 'S')
                {
                    CompassText();
                    Program.TypeLine($".\n(You are South) \n");
                }
                else if (Player.PlayerLocation == 'N')
                {
                    CompassText();
                    Program.TypeLine($".\n(You are North) \n");
                }
                else if (Player.PlayerLocation == 'E')
                {
                    CompassText();
                    Program.TypeLine($".\n(You are East) \n");
                }
                else if (Player.PlayerLocation == 'W')
                {
                    CompassText();
                    Program.TypeLine($".\n(You are West) \n");
                }
            }
        }

        public static void UseWindow(string useCommand)
        {
            if (useCommand == "USE WINDOW")
            {
                if (Player.PlayerLocation == 'W')
                {

                    Program.TypeLine("You look out the small ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    Program.TypeLine(" and gasp! \nThe tower you are in goes down into the clouds. You cannot see the ground below, and start to get the sinking feeling there might be ");
                    MenuText.ChangeTextColor("magic", ConsoleColor.Cyan);
                    Program.TypeLine(" at play here.\n");
                }
                else
                {
                    Program.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    Program.TypeLine(" to use it.\n");
                }
            }
        }
        public static void UseStone(string useCommand)
        {
            if (useCommand == "USE STONE" || useCommand == "USE STONES")
            {
                if (Player.PlayerLocation == 'W')
                {
                    if (!Player.CheckInventory("STONE"))
                    {
                        Program.TypeLine("You examine the broken glass at your feet. Someone seems to have used a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(" to break the ");
                        MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                        Program.TypeLine(". \nYou have no idea why you might need it, but you pick up a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(" and put it in your pocket.\n");
                        Player.inventory.Add("STONE");
                    }
                    else if (Player.CheckInventory("STONE"))
                    {
                        Program.TypeLine("You have already picked up a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(" from the broken glass at your feet. \nYou decide you don't need a second one. \n");
                    }
                }
                else if (Player.PlayerLocation == 'N')
                {
                    if (Player.CheckInventory("STONE"))
                    {
                        Program.TypeLine("You pull the stone out of your pocket and look at the ");
                        MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                        Program.TypeLine(" in the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine(". \nHis eyes dart from you, to your hand. \nWhen he sees the ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(", he becomes enraged. \nAre you sure you want to throw the stone at the mirror?\n");
                        MenuText.StoneFinalChoice();
                    }
                    else
                    {
                        Program.TypeLine("You don't have a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(". \n");
                    }
                }
                else
                {
                    if (Player.CheckInventory("STONE"))
                    {
                        Program.TypeLine("There's no reason to use a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(" here. \n");
                    }
                    else if (!Player.CheckInventory("STONE"))
                    {
                        Program.TypeLine("You don't have a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(". \n");
                    }
                }
            }
        }

        public static void UseDesk(string useCommand)
        {
            if (useCommand == "USE DESK")
            {
                if (Player.PlayerLocation == 'E')
                {
                    Program.TypeLine("You sit at the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(" and begin rifling through the drawers. \nYou dont find anything of use--spare parchment and some ink. \n But wait--reaching under the desk, you find a ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(". \nIt is locked.\n");
                }
                else
                {
                    Program.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseJournal(string useCommand)
        {
            if (useCommand == "USE JOURNAL")
            {
                if (Player.PlayerLocation == 'E')
                {
                    Program.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                    Program.TypeLine(" sitting on the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(". \nMost of the text is unreadable to you--written in some sort of ancient script. \nAt the bottom of the page, you see these words scrawled in the common tongue:\n");
                    MenuText.ChangeTextColor("\"The creature in the mirror is not to be trusted.\"\n", ConsoleColor.Cyan);
                }
                else
                {
                    Program.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                    Program.TypeLine(" to use it.\n");
                }
            }
        }
        public static void UseMagicBook(string useCommand)
        {
            if (useCommand == "USE MAGIC BOOK")
            {
                if (Player.CheckInventory("MAGIC BOOK"))
                {
                    if (Player.PlayerLocation == 'N')
                    {
                        Program.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine(" begin to ");
                        MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                        Program.TypeLine(". \nThe ");
                        MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                        Program.TypeLine(" in the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine(" begins to laugh.\n \n \nWould you like to keep reading?\n");
                        MenuText.BookFinalChoice();
                    }
                    else
                    {
                        Program.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine(" begin to ");
                        MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                        Program.TypeLine(". \nYou shut the book again. Perhaps if you were closer to the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine("?\n");
                    }
                }
                else
                {
                    Program.TypeLine("You dont have a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    Program.TypeLine(".\n");
                }
            }
        }

        public static void UseSecretCompartment(string useCommand)
        {
            if (useCommand == "USE SECRET COMPARTMENT")
            {
                if (Player.PlayerLocation == 'E')
                {
                    if ((Player.CheckInventory("KEY") && !Player.CheckInventory("MAGIC BOOK")) || (Player.CheckInventory("KEY") && !Player.CheckInventory("MAGIC BOOK")))
                    {
                        Program.TypeLine("You unlock the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        Program.TypeLine(" with a *click*. \nInside, you find a ");
                        MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                        Program.TypeLine(". \nYou take it.\n");
                        Player.inventory.Add("MAGIC BOOK");
                    }
                    else if (useCommand == "USE SECRET COMPARTMENT" && !Player.CheckInventory("KEY"))
                    {
                        Program.TypeLine("You cannot open the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        Program.TypeLine(". \nPerhaps if you had a ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        Program.TypeLine("?\n");
                    }
                    else if (Player.CheckInventory("MAGIC BOOK"))
                    {
                        Program.TypeLine("You have already found the ");
                        MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                        Program.TypeLine(" inside the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        Program.TypeLine(". \nThere is nothing else to find here.\n");
                    }
                }
                else
                {
                    Program.TypeLine("There isn't a ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(" here.\n");
                }
            }
        }



    }
}