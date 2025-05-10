using System;

class Program
{
  public static void Main()
  {
    int Sum = 0;
    for (int i = 1; i < 21; i++)
    {
      if (i % 3 == 0)
      {
        Sum += i;
      }
    }
    Console.WriteLine($"Sum is {Sum}");
  }
}