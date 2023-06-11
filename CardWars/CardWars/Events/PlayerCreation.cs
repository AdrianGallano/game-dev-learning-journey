using CardWars.Exceptions;

namespace CardWars.Events;

public static class PlayerCreation
{

  public static int PlayerMax { get; set; }

  public static void PlayerCreationLoop()
  {

    while (PlayerMax > Game.Players.Count)
    {
      PromptCreatePlayer();
    }
  }

  public static bool CreatePlayer(string? name)
  {

    Console.WriteLine("CreatePlayer " + name);
    if (name == null || name == "")
    {
      Console.WriteLine("Please enter a name.");
      return false;
    }

    var tmpPlayer = new Player(name, 25, 2000, 10);
    Game.Players.Add(tmpPlayer);
    return true;

  }

  public static void PromptCreatePlayer()
  {

    Console.Write($"Please Enter Player {Game.Players.Count + 1} Name: ");
    string? playerName = Console.ReadLine();
    if (!PlayerAlreadyExist(playerName) && CreatePlayer(playerName))
    {
      Console.WriteLine($"Player Successfully Created.");
      Console.Clear();
    }

  }

  public static bool PlayerAlreadyExist(string? playerName)
  {
    foreach (Player player in Game.Players)
    {
      if (player.Name == playerName)
      {
        Console.WriteLine("Player name already exist choose another valid name.");
        return true;
      }
    }

    return false;
  }

  public static void EnterPlayerMax(){
    while(!isValidPlayerMax());
  }

  public static bool isValidPlayerMax()
  {
    try
    {
      Console.Write("Enter Player Max: ");
      PlayerMax = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
      Console.WriteLine($"Input is Invalid. Enter a valid player maximum.");
      return false;
    }
    return true;
  }
}