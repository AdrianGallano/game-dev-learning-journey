using Humanizer;

public interface IDescriptive
{
  static void HumanizeQuantities()
  {
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
  }

  static void HumanizeDate()
  {
    Console.WriteLine(DateTime.Now.AddHours(2).Humanize());
    Console.WriteLine(DateTime.Now.AddHours(-30).Humanize());
    Console.WriteLine(TimeSpan.FromDays(20).Humanize());
    Console.WriteLine(TimeSpan.FromDays(-30).Humanize());
  }
}