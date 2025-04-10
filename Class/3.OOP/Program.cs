using System;

public class Animal
{
  // Public field
  public string Name;

  // Protected field
  protected int Age;

  // Internal field
  internal string Location;

  // Protected internal field
  protected internal string Habitat;

  // Private field
  private bool isHungry;

  // Constructor
  public Animal(string name, int age, string location, string habitat)
  {
    Name = name;
    Age = age;
    Location = location;
    Habitat = habitat;
    isHungry = true; // Private field can be accessed within the same class
  }

  // Public method
  public void DisplayDetails()
  {
    Console.WriteLine($"Name: {Name}, Age: {Age}, Location: {Location}, Habitat: {Habitat}");
    if (isHungry == true)
    {
      Console.WriteLine($"My {Name} is hungry");
    }
  }
}
class Program
{
  static void Main()
  {
    Animal animal = new Animal("Gray", 5, "South Sydney", "The house");

    Console.WriteLine($"My animal is in: {animal.Location} and habitat is: {animal.Habitat}");
    animal.DisplayDetails();
  }
}