using System;

class Program
{
  public static void Main()
  {
    object obj = 42;
    int intValue = (int)obj;

    Console.WriteLine($"Casted value: {intValue}");
  }
}