
using System;


class Program
{
  static void Main()
  {
    try
    {
      int zeroVal = 0;
      int result = (10 / zeroVal);
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred: {ex.Message}");
    }
  }
}