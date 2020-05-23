using System;

namespace TestConsoleApp 
{
  class VideoGame
  {
    public string Title;
    public string GameConsole;

    
    public VideoGame(string title, string gameConsole)
    {
        Title = title;
        GameConsole = gameConsole;
        Console.WriteLine($"The name of the video game is {title}, and you can play it on {gameConsole}!");
    }
  }
}