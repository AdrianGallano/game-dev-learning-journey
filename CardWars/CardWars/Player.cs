using CardWars.Cards;
using CardWars.Exceptions;

namespace CardWars;

public class Player
{

  // Properties
  public string Name { get; set; }
  private Area Biome { get; set; }
  public int Troops { get; set; }
  public int Mana { get; set; }
  public int Health { get; set; }
  public int TotalTroops { get; set; }
  public int TotalArea { get; set; }
  public List<Card> ActiveCards = new List<Card>();
  public List<Card> InHandCards = new List<Card>();
  public Deck? PlayerDeck { get; set; }

  public Player(string Name, int Mana, int Health, int Troops)
  {


    AddBiome();
    this.Name = Name;
    this.Mana = Mana;
    this.Health = Health;
    this.Troops = Troops;
    this.TotalTroops = 0;
    this.TotalArea = 0;
  }

  private void AddBiome()
  {
    if (Area.Biomes.Count < 0)
      throw new BiomeDoesNotExist("Biomes is still non-existent.");

    if (Area.Biomes.Count == 0)
    {
      this.Biome = Area.Biomes[0];
    }
    Random random = new Random();
    int randNum = random.Next(0, Area.Biomes.Count);
    this.Biome = Area.Biomes[randNum];
  }
}