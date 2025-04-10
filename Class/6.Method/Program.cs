using System;
using System.Security.Cryptography.X509Certificates;

public class Calculator
{
  // Method to add two numbers
  public int Add(int num1, int num2)
  {
    return num1 + num2;
  }
  // Method to subtract two numbers
  public int Subtract(int num1, int num2)
  {
    return num1 - num2;
  }
  // Method to multiply two numbers
  public int Multiply(int num1, int num2)
  {
    return num1 * num2;
  }
  // Method to divide two numbers
  public double Divide(int num1, int num2)
  {
    if (num2 != 0)
    {
      return (double)num1 / num2;
    }
    else
    {
      throw new ArgumentException("Cannot divide by zero.");
    }
  }
}
class Program
{
  static void Main()
  {
    Calculator calculator = new Calculator();

    int sum = calculator.Add(5, 3);
    int difference = calculator.Subtract(10, 4);
    int product = calculator.Multiply(6, 2);
    double quotient = calculator.Divide(12, 3);

    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Difference: " + difference);
    Console.WriteLine("Product: " + product);
    Console.WriteLine("Quotient: " + quotient);


  }
}