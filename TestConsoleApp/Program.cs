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
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("A Text Adventure Game By Sean Giddings");
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
<<<<<<< HEAD
            //Album album = new Album("Kid A", "RadioHead");

            //testy.Title = "The Pest";

            //Console.WriteLine(testy.Title);


            TitleCard();
            TypeLine("\n \n \nYou wake up, with a start! You are laying on a small, hard bed in an otherwise (almost) empty room. You have a small compass in your pocket, but no other belongings.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("At the north end of the room, there is a large ornate mirror.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("On the east side of the room, a window.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("To the West, a desk.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("The bed you are currently sitting on is to the south.\n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("You look around the small room, and see the sparse decorations, the stone walls, the single window. \n");
            System.Threading.Thread.Sleep(1000);
            TypeLine("There seems to be no way in or out.");



=======
            Album album1 = new Album("Kid A", "RadioHead");
            Album album2 = new Album("Stranger in the Alps", "Phoebe Bridgers");
            Album album3 = new Album("Endless Summer", "The Midnight");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());
>>>>>>> b432a3f0a53d4e752ee3e55d5e8cce19fb12246d
        }
    }
}
