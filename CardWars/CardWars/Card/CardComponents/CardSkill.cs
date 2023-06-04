namespace CardWars.Card.CardComponents
{

  interface CardSkill
  {
    public void Activate(int cost);
  }

  interface CardSkillBeing : CardSkill
  {

    public void DoAttack();
    public void DoDefend();

  }

  interface CardSkillBuilding : CardSkill
  {
    public void Demolish();
  }

  interface CardSkillSpell : CardSkill { }

}
