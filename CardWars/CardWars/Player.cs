namespace CardWars
{
  public class Player
  {
    string Name { get; set; }
    int Area { get; set; }
    int Mana { get; set; }
    int Health { get; set; }
    int Troops { get; set; }

    public Player(string Name, int Area, int Mana, int Health, int Troops)
    {

      this.Name = Name;
      this.Area = Area;
      this.Mana = Mana;
      this.Health = Health;
      this.Troops = Troops;

    }
  }
}