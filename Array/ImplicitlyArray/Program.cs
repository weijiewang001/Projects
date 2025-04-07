using System;

class Program
{
  static void Main()
  {
    int[] a = new int[] { 1, 10, 100, 1000 };

    Console.WriteLine("First Element: " + a[0]);
    Console.WriteLine("Second Element: " + a[1]);
    a[1] = 30;
    Console.WriteLine("Second 30 Element: " + a[1]);

    Console.WriteLine("Third Element: " + a[2]);
    Console.WriteLine("Fourth Element: " + a[3]);
  }
}