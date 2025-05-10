using System;

class Program
{
  public static void Main()
  {
    List<string> names = new List<string> { "Joe", "Anna", "Phillip", "Maria", "Bill" };
    var index = names.IndexOf("Maria");
    if (index != -1)
    {
      Console.WriteLine($"The name {names[index]} is at index {index}");
    }
    var notFound = names.IndexOf("Not Found");
    Console.WriteLine($"When an item is not found, InfexOf return {notFound}");


    names.Sort();
    foreach (var name in names)
    {
      Console.WriteLine($"Hello {name.ToUpper()}!");
    }
  }
}