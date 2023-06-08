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

    /* 
    if 1.0 inclusive
    if (1.0,) 1.1 up
    if [1.0,] 1.0 up
    if (,1.0] 1.0 >= x
    if (,1.0) 1.0 > x
    if [1,3] 1.0 to 3.0
    if (1,3) 2.x.x
    if [1.0, 3.0) 1.0 >= x > 3.0
    if (1.0) invalid

    x.0.0 major update
    0.x.0 minor update
    0.0.x patch
     */
  }
}
