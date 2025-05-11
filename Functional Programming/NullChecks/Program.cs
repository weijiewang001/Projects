using System;

class Program
{
  public static void Main()
  {
    List<string> names = null;
    if (names != null)
    {
      int count = names.Count;
      Console.WriteLine("Name count is " + count.ToString());
    }
    else
    {
      Console.WriteLine("Names are null");
    }

    int countWithNullConditional = names?.Count ?? 0;
    Console.WriteLine("The null-conditional operator is " + countWithNullConditional.ToString());



    names = new List<string> { "Alice", "Bob", "Charlie", "David" };

    if (names != null)
    {
      int count = names.Count;
      Console.WriteLine("Name count is " + count.ToString());
    }
    else
    {
      Console.WriteLine("Names are null");
    }

    countWithNullConditional = names?.Count ?? 0;
    Console.WriteLine("The null-conditional operator2 is " + countWithNullConditional.ToString());

  }
}