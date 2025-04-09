using System;

public class Car
{
  // Attribute or fields
  public string Make;
  public string Model;
  public int Year;

  // Behaviours or methods
  public void Start()
  {
    Console.WriteLine("The car is started.");
  }
  public void Drive()
  {
    Console.WriteLine("The car is in motion.");
  }
}
class Program
{
  static void Main()
  {
    Car myCar = new Car();
    myCar.Make = "Benz";
    myCar.Model = "C200";
    myCar.Year = 2022;


    Car mySecondCar = new Car();
    mySecondCar.Make = "Audi";
    mySecondCar.Model = "Q7 55TFSI";
    mySecondCar.Year = 2020;

    Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
    myCar.Start();
    myCar.Drive();


    Console.WriteLine($"My second car is a {mySecondCar.Year} {mySecondCar.Make} {mySecondCar.Model}");
    myCar.Start();
    myCar.Drive();
  }
}