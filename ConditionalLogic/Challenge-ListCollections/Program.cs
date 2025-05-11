using System;

class Program
{
  public static void Main()
  {
    var fibonacciNumbers = new List<int> { 1, 1 };
    while (fibonacciNumbers.Count < 20)
    {
      fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);

    }

    foreach (var number in fibonacciNumbers)
    {
      Console.WriteLine(number);
    }


  }
}