using CardWars.Cards.CardComponents;


namespace CardWars.Cards
{
  public abstract class CardSpell : Card, ICardSkillSpell
  {
    public int ManaCost;
    public CardSpell(string Name, string Type, int ManaCost) : base(Name, Type)
    {
      this.ManaCost = ManaCost;
    }

    public void Activate()
    {
      if (Game.CurrentPlayer == null) return;
      Game.CurrentPlayer.Mana -= this.ManaCost;
    }
    
    public void Destroy() { }
  }
}