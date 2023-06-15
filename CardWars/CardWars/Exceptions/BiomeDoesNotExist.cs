namespace CardWars.Exceptions;

public class BiomeDoesNotExist : NullReferenceException
{
  public BiomeDoesNotExist() : base()
  {

  }

  public BiomeDoesNotExist(string message) : base(message)
  {

  }
}