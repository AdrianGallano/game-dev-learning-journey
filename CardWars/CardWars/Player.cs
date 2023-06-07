namespace CardWars
{
  public class Player
  {
    string Name { get; set; }
    private Area Biome {get; set;}
    private int Troops { get; set; }
    public int Mana { get; set; }
    public int Health { get; set; }
    public int TotalTroops {get; set;}
    public int TotalArea {get; set;}
    
    
    public Player(string Name, int Mana, int Health, int Troops)
    {
      this.Name = Name;
      this.Biome = Biome;
      this.Mana = Mana;
      this.Health = Health;
      this.Troops = Troops;
      this.TotalTroops = 0;
      this.TotalArea = 0;
    }
  }
}