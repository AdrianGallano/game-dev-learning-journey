namespace CardWars.Cards.CardComponents;

public interface ICardSkill
{
  public void Activate();
  public void Destroy();
}

public interface ICardSkillBeing : ICardSkill
{
  public void DoAttack(int Damage);
  public void DoDefend(int DefensePower);

}

interface ICardSkillBuilding : ICardSkill { }


interface ICardSkillSpell : ICardSkill { }

