using System;
using System.Security.Cryptography.X509Certificates;

public class Rectangle
{
  // Public field
  private double length;
  private double width;

  public double Length
  {
    get { return length; }
    set { length = value; }
  }

  public double Width
  {
    get { return width; }
    set { width = value; }
  }

  public double Area
  {
    get { return length * width; }
  }
}
class Program
{
  static void Main()
  {
    Rectangle rectangle = new Rectangle();

    rectangle.Length = 5.0;
    rectangle.Width = 3.0;
    Console.WriteLine("Length: " + rectangle.Length);
    Console.WriteLine("Width: " + rectangle.Width);
    Console.WriteLine("Area: " + rectangle.Area);
  }
}