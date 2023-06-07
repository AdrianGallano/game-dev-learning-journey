namespace CardWars.Cards.CardComponents
{

  interface CardSkill
  {
    public void Activate();
  }

  interface CardSkillBeing : CardSkill
  {
    public void DoAttack();
    public void DoDefend();
    public void DoSpecialty();
  }

  interface CardSkillBuilding : CardSkill
  {
    public void Demolish();
  }

  interface CardSkillSpell : CardSkill { }

}
