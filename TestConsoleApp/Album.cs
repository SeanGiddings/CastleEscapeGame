using System;

namespace TestConsoleApp 
{
  class Album
  {
    public string Title;
    public string Artist;

    
    public Album(string title, string artist)
    {
        Title = title;
        Artist = artist;
        Console.WriteLine($"The best album by {artist} is {title}");
    }
  }
}