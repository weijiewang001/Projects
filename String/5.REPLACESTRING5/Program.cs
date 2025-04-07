using System;

class Program
{
    static void Main()
    {
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);

        sayHello = sayHello.Replace("Hello", "Greeting");
        Console.WriteLine(sayHello);

        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());
    }
}