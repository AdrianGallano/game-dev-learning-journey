using Anonymous;


public static class Program
{
  internal static bool Run = true;
  internal static Notebook notebook = new Notebook();

  public static void Main(string[] args)
  {

    while (Run)
    {
      Console.Clear();
      Menu.ShowMenuOptions();
      int option = Menu.GetOption();
      Menu.MenuDecision(option);
    }
  }
}

