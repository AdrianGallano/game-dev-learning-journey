using CardWars.Cards.CardComponents;
using CardWars.Exceptions;

namespace CardWars.Cards;

public class CardBeing : Card, ICardSkillBeing
{
  public delegate void Skill();
  public int Attack;
  public int Defense;
  public int TroopCost;
  public int Health;
  public Skill? Special;
  private bool isDefending = false;
  private bool StateLocked = false;
  private bool Attacked = false;

  public CardBeing(string Name, string Type, int Health, int Attack, int Defense, int TroopCost) : base(Name, Type)
  {
    this.Health = Health;
    this.Attack = Attack;
    this.Defense = Defense;
    this.TroopCost = TroopCost;
  }

  public void Activate()
  {

    if (Game.CurrentPlayer == null) throw new CurrentPlayerDoesNotExist("Player does not exist.");
    if ((Game.CurrentPlayer.TotalTroops + this.TroopCost) > Game.CurrentPlayer.Troops)
    {
      Console.WriteLine("Cannot add more troops, insufficient troop space");
      return;
    }

    Game.CurrentPlayer.TotalTroops += this.TroopCost;
    Game.CurrentPlayer.ActiveCards.Add(this);
    Game.CurrentPlayer.InHandCards.Remove(this);

    this.isActivated = true;
  }

  public void DoAttack(ref CardBeing entity)
  {
    if (!this.isDefending && !this.Attacked)
    {
      this.Attacked = true;
      if (entity.Health > this.Attack)
      {
        entity.Health -= this.Attack;
      }else {
        entity.Destroy();
      }
    }
  }

  public void DoAttack(ref CardBuillding entity)
  {
    if (!this.isDefending && !this.Attacked)
    {
      this.Attacked = true;
      if (entity.Durability > this.Attack)
      {
        entity.Durability -= this.Attack;
      }else {
        entity.Destroy();
      }
    }
  }


  public void SetAttack()
  {
    if (!StateLocked)
    {
      this.isDefending = false;
      this.StateLocked = true;
    }
  }

  public void SetDefense()
  {
    if (!StateLocked)
    {
      this.isDefending = true;
      this.StateLocked = true;
    }
  }

  public void Destroy()
  {
    if (Game.CurrentPlayer == null) throw new CurrentPlayerDoesNotExist("Player does not exist.");

    Game.CurrentPlayer.ActiveCards.Remove(this);
  }

  public void AddSpecialty(Skill skill) => this.Special = skill;

  public void DoSpecialty()
  {
    if (this.Special == null) throw new SkillDoesNotExist("Skill does not exist yet.");
    this.Special();
  }

  public void Reset()
  {
    this.StateLocked = false;
    this.Attacked = false;
  }

}