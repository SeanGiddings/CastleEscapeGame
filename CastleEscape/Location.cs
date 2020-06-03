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
                Program.TypeLine("You see the BED you woke up on.");
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