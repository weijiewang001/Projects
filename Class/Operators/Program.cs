using System;

public class ComplexNumber
{
  public double Real { get; private set; }
  public double Imaginary { get; private set; }

  public ComplexNumber(double real, double imaginary)
  {
    Real = real;
    Imaginary = imaginary;
  }

  // Overloading the + operator to add two complex numbers
  public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
  {
    double realPart = c1.Real + c2.Real;
    double imaginaryPart = c1.Imaginary + c2.Imaginary;
    return new ComplexNumber(realPart, imaginaryPart);
  }

  public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
  {
    double realPart = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
    double imaginaryPart = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);
    return new ComplexNumber(realPart, imaginaryPart);
  }


  public override string ToString()
  {
    return $"{Real} + {Imaginary}i";
  }
}

public class Program
{
  public static void Main()
  {
    ComplexNumber c1 = new ComplexNumber(2, 3);
    ComplexNumber c2 = new ComplexNumber(1, 2);

    ComplexNumber sum = c1 + c2;
    ComplexNumber product = c1 * c2;

    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Product: " + product);
  }
}