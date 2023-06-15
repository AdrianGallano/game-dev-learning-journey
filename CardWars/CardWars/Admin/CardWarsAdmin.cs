// this is where i'll add new cards to the database
// but for the beginning i'll just add it manually 
using CardWars.Cards;
using System.Diagnostics;

namespace CardWars.Admin;

public class Administration
{
  public static void RunAdmin()
  {
    CardBeing cb = new CardBeing("One Punch Man", "Human", 5000000, 999999999, 999999999, 1);
    cb.AddSpecialty(Skill.SayHello);
    cb.DoSpecialty();
    Debug.WriteLine("Admin Worked");
  }
}

public class Skill
{
  public static void SayHello()
  {
    Console.WriteLine("hello world");
  }
}