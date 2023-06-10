using Debugging;

Console.Write("Enter a Number: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"The value of the {length} is {Fibonacci.Solve(length)}");
Console.WriteLine($"The value of the {length} is {Fibonacci.SumOfFibLength(length)}");
Console.WriteLine($"The value of the {dividend} divided by {divisor} is {Division.Divide(dividend, divisor)}");
