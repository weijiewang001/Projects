using System;

class Program
{
  public static void Main()
  {
    object someObject = 'c';
    if (someObject is string stringValue)
    {
      Console.WriteLine($"The object is a string {stringValue}");
    }
    else if (someObject is int intValue)
    {
      Console.WriteLine($"The object is a int {intValue}");
    }
    else
    {
      Console.WriteLine($"The object is of an unknow type");
    }
  }
}