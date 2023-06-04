using CardWars.Card.CardComponents;

namespace CardWars.Card
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

    public void Activate(int cost) { }
    public void DoAttack() { }
    public void DoDefend() { }

  }

  public abstract class CardBuillding : Card, CardSkillBuilding
  {

    public int Durability;

    public CardBuillding(string Name, string Type, int Durability) : base(Name, Type)
    {
      this.Durability = Durability;
    }

    public void Activate(int cost) { }
    public void Demolish() { }

  }

  public abstract class CardSpell : Card, CardSkillSpell
  {

    public CardSpell(string Name, string Type) : base(Name, Type) { }

    public void Activate(int cost) { }
  }
}



// the cards but i'll make interface here
