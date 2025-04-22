using System;

public class Vehicle
{
  public string Brand { get; set; }

  public int Year { get; set; }

  public void Start()
  {
    Console.WriteLine("The vehicle is started.");
  }

  public void Stop()
  {
    Console.WriteLine("The vehicle is stopped.");
  }
}

public class Car : Vehicle
{
  public int NumberofDoors { get; set; }

  public void Accelerate()
  {
    Console.WriteLine("The car is accelerating.");
  }
}

class Program
{
  static void Main()
  {
    Car myCar = new Car();

    myCar.Brand = "Toyota";
    myCar.Year = 2025;

    myCar.NumberofDoors = 4;

    myCar.Start();

    myCar.Accelerate();

    myCar.Stop();

  }
}