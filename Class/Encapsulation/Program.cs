using System;

public class Person
{
  private string name;
  private int age;


  public string GetName()
  {
    return name;
  }

  public void SetName(string newName)
  {
    if (!string.IsNullOrEmpty(newName))
    {
      name = newName;
    }
    else
    {
      Console.WriteLine("Name cannot be empty!");
    }
  }

  public int getAge()
  {
    return age;
  }

  public void SetAge(int newAge)
  {
    if (newAge >= 0)
    {
      age = newAge;
    }
    else
    {
      Console.WriteLine("Age cannot be negative!");
    }
  }


  //constructor
  public Person(string initialName, int initialAge)
  {
    SetName(initialName);
    SetAge(initialAge);
  }


  public void DisplayInfo()
  {
    Console.WriteLine($"Name: {name}, Age: {age}");
  }
}

class Program
{
  static void Main()
  {
    Person person1 = new Person("John", 25);
    Console.WriteLine($"Name: {person1.GetName()}, Age: {person1.getAge()}");

    person1.SetName("Wayne");
    person1.SetAge(24);

    person1.DisplayInfo();
  }
}