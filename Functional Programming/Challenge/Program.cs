using System;

class Program
{
  public static void Main()
  {
    var employees = new List<KeyValuePair<string, string>> {
      new KeyValuePair<string, string>("Dave", "Developer"),
      new KeyValuePair<string, string>("Jane", "Business Analyst"),
      new KeyValuePair<string, string>("Charlie", "Developer")
    };

    foreach (var employee in employees)
    {
      switch (employee.Value)
      {
        case "Developer":
          Console.WriteLine($"{employee.Key} is a {employee.Value}");
          break;
        default:
          break;
      }
    }
  }
}









// var list = new List<KeyValuePair<string, string>> {
//       new KeyValuePair<string, string>("000001", "John"),
//       new KeyValuePair<string, string>("000002", "Joe")
//     };

//     list.ForEach(kvp => Console.WriteLine($"{kvp.Key}: {kvp.Value}"));