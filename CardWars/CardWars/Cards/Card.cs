using CardWars.Cards.CardComponents;
using CardWars;

namespace CardWars.Cards
{
  public abstract class Card
  {
    string Name { get; set; }
    string Type { get; set; }

    public Card(string Name, string Type)
    {
      this.Name = Name;
      this.Type = Type;
    }
  }

  public abstract class CardBeing : Card, CardSkillBeing
  {
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
      Game.CurrentPlayer.TotalTroops += this.TroopCost;

    }

    public void DoAttack() { }
    public void DoDefend() { }
    public void DoSpecialty() { }
  }

  public abstract class CardBuillding : Card, CardSkillBuilding
  {

    public int Durability;
    public int AreaCost;

    public CardBuillding(string Name, string Type, int Durability, int AreaCost) : base(Name, Type)
    {
      this.Durability = Durability;
      this.AreaCost = AreaCost;
    }

    public void Activate()
    {

      if (Game.CurrentPlayer == null) return;
      Game.CurrentPlayer.TotalArea += AreaCost;

    }

    public void Demolish() { }

  }

  public abstract class CardSpell : Card, CardSkillSpell
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
  }
}



// the cards but i'll make interface here
