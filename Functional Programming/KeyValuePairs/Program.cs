using System;

class Program
{
  public static void Main()
  {
    var list = new List<KeyValuePair<string, string>> {
      new KeyValuePair<string, string>("000001", "John"),
      new KeyValuePair<string, string>("000002", "Joe")
    };

    list.ForEach(kvp => Console.WriteLine($"{kvp.Key}: {kvp.Value}"));
  }
}