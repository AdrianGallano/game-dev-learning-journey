using Asynchronous;

public class Program
{
  static async Task Main(string[] args)
  {
    BreakFast.Coffee cup = PourCoffee();
    Console.WriteLine("coffee is ready");
    Console.WriteLine();

    var FryEggTask = FryEggsAsync(2);
    var FryBaconTask = FryBaconAsync(3);
    var ToastBreadTask = ToastBreadAsync(2);

    BreakFast.Egg eggs = await FryEggTask;
    Console.WriteLine("eggs are ready");
    Console.WriteLine();

    BreakFast.Bacon bacon = await FryBaconTask;
    Console.WriteLine("bacon is ready");
    Console.WriteLine();

    BreakFast.Toast toast = await ToastBreadTask;
    ApplyButter(toast);
    ApplyJam(toast);
    Console.WriteLine("toast is ready");
    Console.WriteLine();

    BreakFast.Juice oj = PourOrangeJuice();
    Console.WriteLine("orange juice is ready");
    Console.WriteLine();


    Console.WriteLine("Breakfast is ready!");
    Console.WriteLine();

  }


  public static BreakFast.Juice PourOrangeJuice()
  {
    Console.WriteLine("Pouring orange juice.");
    Console.WriteLine();

    return new BreakFast.Juice();
  }

  private static void ApplyJam(BreakFast.Toast toast) =>
    Console.WriteLine("Putting jam on the toast");

  private static void ApplyButter(BreakFast.Toast toast) =>
      Console.WriteLine("Putting butter on the toast");

  private static async Task<BreakFast.Toast> ToastBreadAsync(int slices)
  {
    for (int slice = 0; slice < slices; slice++)
    {
      Console.WriteLine("Putting a slice of bread in the toaster");
    }
    Console.WriteLine("Start toasting...");
    await Task.Delay(3000);
    Console.WriteLine("Remove toast from toaster");
    Console.WriteLine();

    return new BreakFast.Toast();
  }

  private static async Task<BreakFast.Bacon> FryBaconAsync(int slices)
  {
    Console.WriteLine($"putting {slices} slices of bacon in the pan");
    Console.WriteLine("cooking first side of bacon...");
    
    Console.WriteLine();
    await Task.Delay(3000);
    for (int slice = 0; slice < slices; slice++)
    {
      Console.WriteLine("flipping a slice of bacon");
    }
    Console.WriteLine("cooking the second side of bacon...");
    Console.WriteLine();

    await Task.Delay(3000);
    Console.WriteLine("Put bacon on plate");
    Console.WriteLine();
    return new BreakFast.Bacon();
  }

  private static async Task<BreakFast.Egg> FryEggsAsync(int howMany)
  {
    Console.WriteLine("Warming the egg pan...");
    await Task.Delay(3000);
    Console.WriteLine($"cracking {howMany} eggs");
    Console.WriteLine("cooking the eggs ...");
    await Task.Delay(3000);
    Console.WriteLine("Put eggs on plate");

    Console.WriteLine();


    return new BreakFast.Egg();
  }

  private static BreakFast.Coffee PourCoffee()
  {
    Console.WriteLine("Pouring coffee");
    Console.WriteLine();
    return new BreakFast.Coffee();
  }
}

