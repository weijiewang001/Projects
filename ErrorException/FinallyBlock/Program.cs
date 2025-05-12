
using System;


class Program
{
  static void Main()
  {
    try
    {
      // 
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occured: {ex.Message}");
    }
    finally
    {
      Console.WriteLine("Finally block executed.");
    }
  }
}