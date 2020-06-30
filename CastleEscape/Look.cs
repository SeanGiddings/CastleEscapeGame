using System;

namespace CastleEscape
{
    //This class handles the LOOK command
    class Look
    {
        public static void LookCommand()
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
                MenuText.TypeLine("You see the ");
                MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                MenuText.TypeLine(" you woke up on.\n");
            }
        }
        public static void NorthLook()
        {
            if (Player.PlayerLocation == 'N')
            {
                MenuText.TypeLine("You see an ancient, mysterious ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                MenuText.TypeLine(" with runes etched across both sides.\n");
            }
        }
        public static void EastLook()
        {
            if (Player.PlayerLocation == 'E')
            {
                MenuText.TypeLine("You see a modest wooden writing ");
                MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                MenuText.TypeLine(", with an open ");
                MenuText.ChangeTextColor("JOURNAL", ConsoleColor.Red);
                MenuText.TypeLine(" sitting on top.\n");
            }
        }
        public static void WestLook()
        {
            if (Player.PlayerLocation == 'W')
            {
                MenuText.TypeLine("You see a small ");
                MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                MenuText.TypeLine(" that is far too narrow to climb out of.\n");
                System.Threading.Thread.Sleep(500);
                MenuText.TypeLine("Below the open window is some broken glass, and a handful of small ");
                MenuText.ChangeTextColor("STONES", ConsoleColor.Red);
                MenuText.TypeLine(".\n");
            }
        }

    }
}