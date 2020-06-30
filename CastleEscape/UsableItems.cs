using System;
using System.Collections.Generic;

namespace CastleEscape
{
    //This class handles Usable Items and all the ways they are used.
    class UsableItems
    {

        public static List<string> usableItems = new List<string>();

        //When the game begins, all usable items are added to the list
        public UsableItems()
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
                MenuText.TypeLine($"{useCommand} is not a proper command. Type ");
                MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                MenuText.TypeLine(" for assitance with the USE command.\n");
            }
        }

        //All Usable Items, and their text are below here.
        public static void UseMirror(string useCommand)
        {
            if (useCommand == "USE MIRROR")
            {
                if (Player.PlayerLocation == 'N')
                {
                    MenuText.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    MenuText.TypeLine(" and instead of seeing your reflection, you see a ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    MenuText.TypeLine(" motioning to the Runes on either side.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("Perhaps if you could decipher them, you could learn more about the Man trapped in the mirror?\n");
                }
                else
                {
                    MenuText.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    MenuText.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseKey(string useCommand)
        {
            if (useCommand == "USE KEY")
            {
                if (!Player.CheckInventory("KEY"))
                {
                    MenuText.TypeLine("You dont have a ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    MenuText.TypeLine(".\n");
                }
                else if (Player.CheckInventory("KEY") && !(Player.PlayerLocation == 'E'))
                {
                    MenuText.TypeLine("There is no reason to use a ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    MenuText.TypeLine(" here.\n");
                }
                else if (Player.PlayerLocation == 'E' && (useCommand == "USE KEY" && Player.CheckInventory("KEY") && !Player.CheckInventory("MAGIC BOOK")))
                {
                    MenuText.TypeLine("You unlock the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    MenuText.TypeLine(" with a *click*.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("Inside, you find a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    MenuText.TypeLine(". \n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("You take it.\n");
                    Player.inventory.Add("MAGIC BOOK");
                }
                else if (Player.PlayerLocation == 'E' && (useCommand == "USE KEY" && Player.CheckInventory("KEY") && Player.CheckInventory("MAGIC BOOK")))
                {
                    MenuText.TypeLine("You have already unlocked the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    MenuText.TypeLine(" and found the ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    MenuText.TypeLine(".\n");
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
                        MenuText.TypeLine("You climb into the rough bed and notice something inside the pillow... A ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        MenuText.TypeLine("?\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("You put it in your bag.\n");
                        Player.inventory.Add("KEY");
                    }
                    else if (Player.CheckInventory("KEY"))
                    {
                        MenuText.TypeLine("You climb into the rough bed, and remember finding the ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        MenuText.TypeLine(" inside the pillow.\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("There's nothing else to find here.\n");
                    }
                }
                else
                {
                    MenuText.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                    MenuText.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseCompass(string useCommand)
        {
            static void CompassText()
            {
                {
                    MenuText.TypeLine("There are four sides to this room. \nTo the North, a ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    MenuText.TypeLine(".\nTo the East, ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    MenuText.TypeLine(".\nTo the South, a ");
                    MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                    MenuText.TypeLine(".\nTo the West, a ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                }
            }
            if (useCommand == "USE COMPASS")
            {
                if (Player.PlayerLocation == 'S')
                {
                    CompassText();
                    MenuText.TypeLine($".\n(You are South) \n");
                }
                else if (Player.PlayerLocation == 'N')
                {
                    CompassText();
                    MenuText.TypeLine($".\n(You are North) \n");
                }
                else if (Player.PlayerLocation == 'E')
                {
                    CompassText();
                    MenuText.TypeLine($".\n(You are East) \n");
                }
                else if (Player.PlayerLocation == 'W')
                {
                    CompassText();
                    MenuText.TypeLine($".\n(You are West) \n");
                }
            }
        }

        public static void UseWindow(string useCommand)
        {
            if (useCommand == "USE WINDOW")
            {
                if (Player.PlayerLocation == 'W')
                {

                    MenuText.TypeLine("You look out the small ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    MenuText.TypeLine(" and gasp!\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("The tower you are in goes down into the clouds.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("You cannot see the ground below, and start to get the sinking feeling there might be ");
                    MenuText.ChangeTextColor("magic", ConsoleColor.Cyan);
                    MenuText.TypeLine(" at play here.\n");
                }
                else
                {
                    MenuText.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    MenuText.TypeLine(" to use it.\n");
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
                        MenuText.TypeLine("You examine the broken glass at your feet.\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("Someone seems to have used a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(" to break the ");
                        MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                        MenuText.TypeLine(".\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("You have no idea why you might need it, but you pick up a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(" and put it in your pocket.\n");
                        Player.inventory.Add("STONE");
                    }
                    else if (Player.CheckInventory("STONE"))
                    {
                        MenuText.TypeLine("You have already picked up a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(" from the broken glass at your feet. \nYou decide you don't need a second one. \n");
                    }
                }
                else if (Player.PlayerLocation == 'N')
                {
                    if (Player.CheckInventory("STONE"))
                    {
                        MenuText.TypeLine("You pull the stone out of your pocket and look at the ");
                        MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                        MenuText.TypeLine(" in the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        MenuText.TypeLine(". \n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("His eyes dart from you, to your hand.\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("When he sees the ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(", he becomes enraged.\n \n \n");
                        System.Threading.Thread.Sleep(1000);
                        MenuText.TypeLine("Are you sure you want to throw the stone at the mirror?\n");
                        MenuText.StoneFinalChoice();
                    }
                    else
                    {
                        MenuText.TypeLine("You don't have a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(". \n");
                    }
                }
                else
                {
                    if (Player.CheckInventory("STONE"))
                    {
                        MenuText.TypeLine("There's no reason to use a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(" here. \n");
                    }
                    else if (!Player.CheckInventory("STONE"))
                    {
                        MenuText.TypeLine("You don't have a ");
                        MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                        MenuText.TypeLine(". \n");
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
                    MenuText.TypeLine("You sit at the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    MenuText.TypeLine(" and begin rifling through the drawers.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("You dont find anything of use--spare parchment and some ink.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("But wait--");
                    System.Threading.Thread.Sleep(1000);
                    MenuText.TypeLine("reaching under the desk, you find a ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    MenuText.TypeLine(". \n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("It is locked.\n");
                }
                else
                {
                    MenuText.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    MenuText.TypeLine(" to use it.\n");
                }
            }
        }

        public static void UseJournal(string useCommand)
        {
            if (useCommand == "USE JOURNAL")
            {
                if (Player.PlayerLocation == 'E')
                {
                    MenuText.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                    MenuText.TypeLine(" sitting on the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    MenuText.TypeLine(".\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("Most of the text is unreadable to you--written in some sort of ancient script.\n");
                    System.Threading.Thread.Sleep(500);
                    MenuText.TypeLine("At the bottom of the page, you see these words scrawled in the common tongue:\n");
                    System.Threading.Thread.Sleep(1000);
                    MenuText.ChangeTextColor("\"The creature in the mirror is not to be trusted.\"\n", ConsoleColor.Cyan);
                }
                else
                {
                    MenuText.TypeLine("You are not close enough to the ");
                    MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                    MenuText.TypeLine(" to use it.\n");
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
                        MenuText.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        MenuText.TypeLine(" begin to ");
                        MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                        MenuText.TypeLine(".\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("The ");
                        MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                        MenuText.TypeLine(" in the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        MenuText.TypeLine(" begins to laugh.\n \n \n");
                        System.Threading.Thread.Sleep(1000);
                        MenuText.TypeLine("Would you like to keep reading?\n");
                        MenuText.BookFinalChoice();
                    }
                    else
                    {
                        MenuText.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        MenuText.TypeLine(" begin to ");
                        MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                        MenuText.TypeLine(". \n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("You shut the book again. Perhaps if you were closer to the ");
                        MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                        MenuText.TypeLine("?\n");
                    }
                }
                else
                {
                    MenuText.TypeLine("You dont have a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    MenuText.TypeLine(".\n");
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
                        MenuText.TypeLine("You unlock the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        MenuText.TypeLine(" with a *click*.\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("Inside, you find a ");
                        MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                        MenuText.TypeLine(".\n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("You take it.\n");
                        Player.inventory.Add("MAGIC BOOK");
                    }
                    else if (useCommand == "USE SECRET COMPARTMENT" && !Player.CheckInventory("KEY"))
                    {
                        MenuText.TypeLine("You cannot open the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        MenuText.TypeLine(". \n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("Perhaps if you had a ");
                        MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                        MenuText.TypeLine("?\n");
                    }
                    else if (Player.CheckInventory("MAGIC BOOK"))
                    {
                        MenuText.TypeLine("You have already found the ");
                        MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                        MenuText.TypeLine(" inside the ");
                        MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                        MenuText.TypeLine(". \n");
                        System.Threading.Thread.Sleep(500);
                        MenuText.TypeLine("There is nothing else to find here.\n");
                    }
                }
                else
                {
                    MenuText.TypeLine("There isn't a ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    MenuText.TypeLine(" here.\n");
                }
            }
        }

    }
}