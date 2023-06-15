namespace CardWars.Cards.CardComponents;

public interface ICardSkill
{
  public void Activate();
  public void Destroy();
}

public interface ICardSkillBeing : ICardSkill
{
  public void DoAttack(ref CardBeing entity);
  public void DoAttack(ref CardBuillding entity);
  public void SetDefense();
  public void SetAttack();

}

interface ICardSkillBuilding : ICardSkill { }


interface ICardSkillSpell : ICardSkill { }

