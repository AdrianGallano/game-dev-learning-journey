using CardWars.Cards;

namespace CardWars
{
  public class Player
  {
    string Name { get; set; }
    private Area Biome { get; set; }
    public int Troops { get;}
    public int Mana { get; set; }
    public int Health { get; set; }
    public int TotalTroops { get; set; }
    public int TotalArea { get; set; }
    public List<Card> ActiveCards = new List<Card>();
    public List<Card> InHandCards = new List<Card>();
    
    public Player(string Name, int Mana, int Health, int Troops)
    {
      if (Area.Biomes.Count > 0)
      {
        Random random = new Random();
        int randNum = random.Next(1, Area.Biomes.Count);
        this.Biome = Area.Biomes[randNum];
      }

      this.Name = Name;
      this.Mana = Mana;
      this.Health = Health;
      this.Troops = Troops;
      this.TotalTroops = 0;
      this.TotalArea = 0;
    }
  }
}