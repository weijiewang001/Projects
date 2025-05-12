
using System;


class Program
{
  static void Main()
  {
    try
    {
      int[] numbers = { 1, 2, 3 };
      int index = 4;
      int value = numbers[index];
    }
    catch (IndexOutOfRangeException)
    {
      Console.WriteLine($"Index out of range.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occured: {ex.Message}");
    }
  }
}