using System.Diagnostics;

namespace Debugging
{
  public static class Fibonacci
  {


    public static int Solve(int Length)
    {
      int temp = default;
      int first = default;
      int second = 1;
      for (int i = 0; i < Length; i++)
      {
        temp = second;
        second += first;
        first = temp;
      }

      return first;
    }

    public static int SumOfFibLength(int Length)
    {
      int temp = default;
      int first = default;
      int second = 1;
      int sum = default;
      for (int i = 0; i < Length; i++)
      {
        temp = second;
        second += first;
        first = temp;
        sum += first;

        Debug.WriteLine($"The current value of {nameof(first)} is {first} and the current value of {nameof(sum)} is {sum}");
        Debug.WriteLineIf(sum == 1, $"the value of first value is {first} and second value is {second}");
      }

      return sum;
    }
  }
}