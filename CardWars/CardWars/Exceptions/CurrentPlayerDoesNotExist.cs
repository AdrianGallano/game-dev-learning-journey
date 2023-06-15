namespace CardWars.Exceptions;


public class CurrentPlayerDoesNotExist : NullReferenceException
{
  public CurrentPlayerDoesNotExist() : base()
  {

  }

  public CurrentPlayerDoesNotExist(string message) : base(message)
  {

  }
}