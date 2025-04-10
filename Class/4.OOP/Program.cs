using System;

public class Circle
{
  // Public field
  private const double Pi = 3.14159;

  private double radius;

  public Circle(double radius)
  {
    this.radius = radius;
  }

  public double CalculateArea()
  {
    return Pi * radius * radius;
  }
}
class Program
{
  static void Main()
  {
    Circle circle = new Circle(5.0);
    Console.WriteLine($"Area: {circle.CalculateArea()}");
  }
}