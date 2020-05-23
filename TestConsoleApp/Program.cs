using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi, What's your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi {name}, welcome to the program!");

            //Movie testy = new Movie("Jurassic Park", 1.5);
            //VideoGame videoGame = new VideoGame("The Last of Us","Playstation 4");
            Album album1 = new Album("Kid A", "RadioHead");
            Album album2 = new Album("Stranger in the Alps", "Phoebe Bridgers");
            Album album3 = new Album("Endless Summer", "The Midnight");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());
        }
    }
}
