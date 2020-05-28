using System;

namespace TestConsoleApp
{
    class Program
    {
    static void TitleCard()
    {
        Console.WriteLine("You are about to begin");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine(" ▄████▄   ▄▄▄        ██████ ▄▄▄█████▓ ██▓    ▓█████    ▓█████   ██████ ▄████▄   ▄▄▄       ██▓███  ▓█████ ");
        Console.WriteLine("▒██▀ ▀█  ▒████▄    ▒██    ▒ ▓  ██▒ ▓▒▓██▒    ▓█   ▀    ▓█   ▀ ▒██    ▒▒██▀ ▀█  ▒████▄    ▓██░  ██▒▓█   ▀ ");
        Console.WriteLine("▒▓█    ▄ ▒██  ▀█▄  ░ ▓██▄   ▒ ▓██░ ▒░▒██░    ▒███      ▒███   ░ ▓██▄  ▒▓█    ▄ ▒██  ▀█▄  ▓██░ ██▓▒▒███   ");
        Console.WriteLine("▒▓▓▄ ▄██▒░██▄▄▄▄██   ▒   ██▒░ ▓██▓ ░ ▒██░    ▒▓█  ▄    ▒▓█  ▄   ▒   ██▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██▄█▓▒ ▒▒▓█  ▄ ");
        Console.WriteLine("▒ ▓███▀ ░ ▓█   ▓██▒▒██████▒▒  ▒██▒ ░ ░██████▒░▒████▒   ░▒████▒▒██████▒▒ ▓███▀ ░ ▓█   ▓██▒▒██▒ ░  ░░▒████▒");
        Console.WriteLine("░ ░▒ ▒  ░ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▓  ░░░ ▒░ ░   ░░ ▒░ ░▒ ▒▓▒ ▒ ░ ░▒ ▒  ░ ▒▒   ▓▒█░▒▓▒░ ░  ░░░ ▒░ ░");
        Console.WriteLine("  ░  ▒     ▒   ▒▒ ░░ ░▒  ░ ░    ░    ░ ░ ▒  ░ ░ ░  ░    ░ ░  ░░ ░▒  ░ ░ ░  ▒     ▒   ▒▒ ░░▒ ░      ░ ░  ░");
        Console.WriteLine("░          ░   ▒   ░  ░  ░    ░        ░ ░      ░         ░   ░  ░  ░ ░          ░   ▒   ░░          ░   ");
        Console.WriteLine("░ ░            ░  ░      ░               ░  ░   ░  ░      ░  ░      ░ ░ ░            ░  ░            ░  ░");
        Console.WriteLine("░                                                                     ░                                  ");
        
        Console.WriteLine("A Text Adventure Game By Sean Giddings");
        System.Threading.Thread.Sleep(2000);
    }

    static void TypeLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);
            System.Threading.Thread.Sleep(20); // Sleep for 150 milliseconds
        }
    }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi, What's your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi {name}, welcome to the program!");

            //Movie testy = new Movie("Jurassic Park", 1.5);
            //VideoGame videoGame = new VideoGame("The Last of Us","Playstation 4");

            //Album album = new Album("Kid A", "RadioHead");

            //testy.Title = "The Pest";

            //Console.WriteLine(testy.Title);


            TitleCard();
            TypeLine("\n \n \n Hit ENTER to begin\n");
            Console.ReadLine();
            TypeLine("\n \n \nYou wake up, with a start! \n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("You are laying on a small, hard BED in an otherwise (almost) empty room. You have a small COMPASS in your pocket, but no other belongings.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("At the NORTH end of the room, there is a large ornate MIRROR.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("On the EAST side of the room, a WINDOW.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("To the WEST, a DESK.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("The BED you are currently sitting on is to the SOUTH.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("You look around the small room, and see the sparse decorations, the stone walls, the single WINDOW with only the sky in view. \n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("You seem to be in a tower. \n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("There seems to be no way in or out.\n");

            Console.ReadLine();
        }
    }
}
