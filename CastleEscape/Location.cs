using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Location
    {

        public static List<string> usableItems = new List<string>();
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
            //Player.DrawPicture();
            Program.TypeLine("You see an ancient, mysterious ");
            MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
            Program.TypeLine(" with runes etched across both sides.\n");
        }
        public static void EastLook()
        {
            Program.TypeLine("You see a modest wooden writing ");
            MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
            Program.TypeLine(", with an open ");
            MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
            Program.TypeLine(" sitting on top.\n");
        }
        public static void WestLook()
        {
            Program.TypeLine("You see a small ");
            MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
            Program.TypeLine(" that is far too narrow to climb out of.\n Below the open window is some broken glass, and a handful of small ");
            MenuText.ChangeTextColor("STONES", ConsoleColor.Red);
            Program.TypeLine(".\n");
        }

        public static void UseItemCommand(string useCommand)
        {
            if (usableItems.Contains(useCommand)) {
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
            /*
            Program.TypeLine($"{useCommand} is not a proper command. Type ");
            MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
            Program.TypeLine(" for assitance with the USE command.\n");
            */
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
                    Program.TypeLine(" motioning to the Runes on either side. \nPerhaps if you could decipher them, you could learn more about the Man trapped in the mirror?");
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
                    Program.TypeLine("You dont have a key");
                }
                else if (Player.CheckInventory("KEY") && !(Player.PlayerLocation == 'E'))
                {
                    Program.TypeLine("There is no reason to use a key here");
                }
                else if (Player.PlayerLocation == 'E' && (useCommand == "USE KEY" && Player.CheckInventory("KEY") && !Player.CheckInventory("MAGIC BOOK")))
                {
                    Program.TypeLine("You unlock the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(" with a *click*. \nInside, you find a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    Program.TypeLine(". \nYou take it.");
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
                    Program.TypeLine(" at play here.");
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
                        Program.TypeLine(", he becomes enraged. \nYou throw the stone as hard as you can at the mirror. \nThere is a huge flash of light. And then--\nWhere the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        Program.TypeLine(" stood, there is now a doorway, with a spiral staircase that descends into darkness. \nYou take a deep breath and begin your descent.\n");
                        MenuText.YouWin();
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
                    Program.TypeLine(". \nIt is locked.");
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
                    MenuText.ChangeTextColor("\"The creature in the mirror is not to be trusted.\"", ConsoleColor.Cyan);
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
                        Program.TypeLine(" begins to laugh. \nThere is a flash of light. When you open your eyes, everything around you is dark. \nBefore you, you see the ");
                        MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                        Program.TypeLine(" standing in the tower you were trapped in. \nHe continues to laugh, silently, as he picks up a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        Program.TypeLine(" and throws it at you. \nYour view shatters, and everything goes black.\n");
                        MenuText.GameOver();
                        Player.IsPlaying = false;
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
                        Program.TypeLine(". \nYou take it.");
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
                        Program.TypeLine(". \nThere is nothing else to find here.");
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

        public Location()
        {

        }

    }
}