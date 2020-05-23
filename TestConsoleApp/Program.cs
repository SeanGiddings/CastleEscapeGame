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

            Movie testy = new Movie("Jurassic Park", 1.5);
            VideoGame videoGame = new VideoGame("The Last of Us","Playstation 4");
            Album album = new Album("Kid A", "RadioHead");

            testy.Title = "The Pest";

            Console.WriteLine(testy.Title);
        }
    }
}
