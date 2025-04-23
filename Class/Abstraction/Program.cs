using System;

public abstract class Shape
{
  public abstract double CalculateArea();

  public void Display()
  {
    Console.WriteLine("This is a Shape.");
  }
}

public class Circle : Shape
{
  public double Radius { get; set; }

  public override double CalculateArea()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }
}

class Program
{
  static void Main()
  {
    Circle myCircle = new Circle
    {
      Radius = 5
    };


    myCircle.Display();

    double area = myCircle.CalculateArea();
    Console.WriteLine($"This area of the circle is: {area}");
  }


}