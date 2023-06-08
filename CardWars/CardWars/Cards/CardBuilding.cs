using CardWars.Cards.CardComponents;


namespace CardWars.Cards
{
  public abstract class CardBuillding : Card, ICardSkillBuilding
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

    public void Destroy() { }

  }
}