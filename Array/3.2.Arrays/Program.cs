using System;

class Program
{
  static void Main()
  {
    int[,] array2DDeclaration = new int[4, 2];
    int[,,] array3DDeclaration = new int[4, 2, 3];

    int[,] array2DInitionloization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

    // Three - dimensional array.

    int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                    { { 7, 8, 9 }, { 10, 11, 12 } } };


    Console.WriteLine(array2DInitionloization[0, 0]);
    Console.WriteLine(array2DInitionloization[0, 1]);
    Console.WriteLine(array2DInitionloization[1, 0]);
    Console.WriteLine(array2DInitionloization[1, 1]);
    Console.WriteLine(array2DInitionloization[3, 0]);
    Console.WriteLine(array2DInitionloization[3, 1]);

    Console.WriteLine(array3D[1, 0, 1]);
    Console.WriteLine(array3D[1, 1, 2]);



  }
}