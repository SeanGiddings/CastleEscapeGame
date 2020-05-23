using System;

namespace TestConsoleApp 
{
  class Movie
  {
    public string Title;
    public double Length;

    
    public Movie(string title, double length)
    {
        Title = title;
        Length = length;
        Console.WriteLine($"The name of the movie is {title}, and it is {length} hours long!");
    }
  }
}