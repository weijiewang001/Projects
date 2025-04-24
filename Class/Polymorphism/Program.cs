using System;

public class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Generic animal sound");
  }
}

public class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Woof!");
  }
}

public class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow!");
  }
}

class Program
{
  static void Main()
  {
    Animal myDog = new Dog();
    Animal myCat = new Cat();

    myDog.MakeSound();
    myCat.MakeSound();
  }
}