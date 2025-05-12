
using System;


public class CustomException : Exception
{
  public CustomException(string message) : base(message)
  {

  }

}

class Program
{
  static void Main()
  {
    try
    {
      throw new CustomException("Custom exception thrown.");
    }
    catch (CustomException ex)
    {
      Console.WriteLine($"Custom exception occured: {ex.Message}");
    }
    finally
    {
      Console.WriteLine("Finally block executed.");
    }
  }
}
