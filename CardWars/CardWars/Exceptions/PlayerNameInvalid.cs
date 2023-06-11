namespace CardWars.Exceptions
{
  public class PlayerNameInvalid : Exception
  {
    public PlayerNameInvalid() : base()
    {

    }

    public PlayerNameInvalid(string message) : base(message)
    {

    }
  }
}