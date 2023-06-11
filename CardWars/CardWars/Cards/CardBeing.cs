using CardWars.Cards.CardComponents;

namespace CardWars.Cards;

public class CardBeing : Card, ICardSkillBeing
{
  public delegate void Skill();
  public int Attack;
  public int Defense;
  public int TroopCost;
  public int Health;

  public CardBeing(string Name, string Type, int Health, int Attack, int Defense, int TroopCost) : base(Name, Type)
  {
    this.Health = Health;
    this.Attack = Attack;
    this.Defense = Defense;
    this.TroopCost = TroopCost;
  }

  public void Activate()
  {

    if (Game.CurrentPlayer == null) return;
    if ((Game.CurrentPlayer.TotalTroops + this.TroopCost) > Game.CurrentPlayer.Troops)
    {
      Console.WriteLine("Cannot add more troops, insufficient troop space");
      return;
    }

    Game.CurrentPlayer.TotalTroops += this.TroopCost;
    Game.CurrentPlayer.ActiveCards.Add(this);
    this.isActivated = true;
  }

  public void DoAttack(int Damage)
  {

  }

  public void DoDefend(int DefensePower)
  {
  }

  public void Destroy()
  {
    if (Game.CurrentPlayer == null) return;
    Game.CurrentPlayer.ActiveCards.Remove(this);
  }

  public void DoSpecialty(Skill skill) => skill();

}