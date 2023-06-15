using CardWars.Cards.CardComponents;
using CardWars.Exceptions;

namespace CardWars.Cards;

public abstract class CardSpell : Card, ICardSkillSpell
{
  public int ManaCost;
  public CardSpell(string Name, string Type, int ManaCost) : base(Name, Type)
  {
    this.ManaCost = ManaCost;
  }

  public void Activate()
  {
    if (Game.CurrentPlayer == null) throw new CurrentPlayerDoesNotExist("Player does not exist.");
    Game.CurrentPlayer.Mana -= this.ManaCost;
  }

  public void Destroy() { }
}