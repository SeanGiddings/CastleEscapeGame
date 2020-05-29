using System;

namespace CastleEscape 
{
  class Player
  {
    public char PlayerLocation;
    public bool IsPlaying = false;

    public void CheckPlayerLocation()
    {
        if (PlayerLocation == 'S') {
            Console.WriteLine($"You are South");
        } else if (PlayerLocation == 'N') {
            Console.WriteLine($"You are North");
        } else if (PlayerLocation == 'E') {
            Console.WriteLine($"You are East");
        } else if (PlayerLocation == 'W') {
            Console.WriteLine($"You are West");    
        }
    }

    public void PlayerCommand()
    {
        string input = Console.ReadLine();
        string direction = input.ToUpper();
        if (direction == "SOUTH" || direction == "S") {
            PlayerLocation = 'S';
            CheckPlayerLocation();
        } else if (direction == "NORTH" || direction == "N") {
            PlayerLocation = 'N';
            CheckPlayerLocation();
        } else if (direction == "EAST" || direction == "E") {
            PlayerLocation = 'E';
            CheckPlayerLocation();
        } else if (direction == "WEST" || direction == "W") {
            PlayerLocation = 'W';
            CheckPlayerLocation();
        }
    }
    

    
    public Player(char playerLocation)
    {
        IsPlaying = true;
        PlayerLocation = playerLocation;
        CheckPlayerLocation();
        while (IsPlaying) {
            PlayerCommand();
        }
    }
  }
}