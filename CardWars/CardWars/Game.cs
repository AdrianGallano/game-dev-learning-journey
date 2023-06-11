using CardWars.Admin;
using CardWars.Events;

namespace CardWars
{
  public class Game
  {
    public static List<Player> Players = new List<Player>();
    public static Player? CurrentPlayer;

    public static void Play()
    {
      Administration.RunAdmin();
      PlayerCreation.EnterPlayerMax();
      PlayerCreation.PlayerCreationLoop();
    }
  }
}