using System;

class Program
{
  public static void Main()
  {
    object obj = "Hello";
    string? strValue = obj as string;

    if (strValue != null)
    {
      Console.WriteLine($"Casted Value: {strValue}");
    }
    else
    {
      Console.Write("Casting failed");
    }
  }
}