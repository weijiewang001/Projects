using System;

class Program
{
  public static void Main()
  {
    List<string> names = new List<string> { "Joe", "Jack", "Anna" };

    foreach (var name in names)
    {
      Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Anna");

    foreach (var name in names)
    {
      Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}.");
    Console.WriteLine($"I have added {names[2]} and {names[3]} to the list");
    Console.WriteLine($"The list has {names.Count} people in it.");

  }
}