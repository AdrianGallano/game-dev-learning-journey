namespace FileApp.Exceptions
{
  public class EmptyStringException : Exception
  {
    public EmptyStringException() : base()
    {

    }

    public EmptyStringException(string message) : base(message)
    {

    }
  }

  public class EmptyPathException : Exception
  {
    public EmptyPathException() : base()
    {

    }

    public EmptyPathException(string message) : base(message)
    {

    }
  }
}