using System;

public class OuterClass
{
  private int outerField = 10;

  public class NestedClass
  {
    public void DisplayOuterField(OuterClass outer)
    {
      Console.WriteLine("Outer field value : " + outer.outerField);
    }
  }
}

public class Program
{
  public static void Main()
  {
    OuterClass outerObj = new OuterClass();
    OuterClass.NestedClass nestedObj = new OuterClass.NestedClass();

    nestedObj.DisplayOuterField(outerObj);
  }
}