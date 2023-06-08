namespace Humanize
{
  public class Program
  {
    static void Main(string[] args)
    { 
      Console.WriteLine("Quantities: ");
      IDescriptive.HumanizeQuantities();

      Console.WriteLine("\nHumanize Dates: ");
      IDescriptive.HumanizeDate();
    }
  }
}
