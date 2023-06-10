using System.Diagnostics;

namespace Debugging
{
  public static class Division
  {

    public static int Divide(int dividend, int divisor)
    {
      Debug.Assert(divisor != 0, $"{nameof(divisor)} is {divisor}. {nameof(divisor)} should not be 0");

      return dividend / divisor;
    }

  }
}