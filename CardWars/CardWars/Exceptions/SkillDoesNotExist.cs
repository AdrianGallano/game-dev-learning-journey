namespace CardWars.Exceptions;


public class SkillDoesNotExist : NullReferenceException
{
  public SkillDoesNotExist() : base()
  {

  }

  public SkillDoesNotExist(string message) : base(message)
  {

  }
}