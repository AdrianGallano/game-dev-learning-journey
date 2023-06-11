namespace CardWars.Cards;

public class Deck
{
  public string Name { get; }
  public List<Card> cards = new List<Card>();

  public Deck(string Name) => this.Name = Name;


  public void AddOneOrMoreCards(params Card[] cards)
  {
    if (this.cards.Count + cards.Length > 52)
    {
      Console.WriteLine("""
        Your Deck can only hold up to 52 cards.
        Consider Doing This Cases:
        Case 1: Reducing number of additional card/s being added. 
        Case 2: Removing existing card/s in deck.
        Case 3: No Modification/s.
        """);
    }

    if (cards.Length > 0)
    {
      foreach (Card card in cards) this.cards.Add(card);
    }
  }
}