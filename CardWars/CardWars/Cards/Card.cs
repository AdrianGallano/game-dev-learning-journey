using CardWars.Cards.CardComponents;

namespace CardWars.Cards
{
  public abstract class Card
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public bool isActivated = false;

    public Card(string Name, string Type)
    {
      this.Name = Name;
      this.Type = Type;
    }
  }

}



// the cards but i'll make interface here
