using System;
using CardWars.Admin;
namespace CardWars
{
  public class Game
  {
    public static List<Player> Players = new List<Player>();
    public static Player? CurrentPlayer;

    public static void Play()
    {
      Administration.RunAdmin();
      int playerMax = 2;

      while (Players.Count != playerMax)
      { // create player
        PromptCreatePlayer();
      }

    }

    public static bool CreatePlayer(string? name)
    {

      if (name == null || name == "") return false;

      var tmpPlayer = new Player(name, 25, 2000, 10);

      Players.Add(tmpPlayer);

      return true;

    }

    public static void PromptCreatePlayer()
    {

      Console.Write($"Please Enter Player {Players.Count + 1} Name: ");

      string? playerName = Console.ReadLine();

      if (CreatePlayer(playerName))
      {
        Console.WriteLine($"Player Successfully Created.");
      }
      else
      {
        Console.WriteLine($"Please enter a name.");
      }

    }
  }
}