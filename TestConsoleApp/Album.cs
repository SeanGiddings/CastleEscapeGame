using System;

namespace TestConsoleApp 
{
  class Album
  {
    public readonly string Title;
    public readonly string Artist;

    
    public Album(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }

    public void Loan()
    {
    }

    public void Return()
    {
    }

    
    public string GetDisplayText()
    {
        return $"Album: {Title} by {Artist}";
    }


    
  }
}