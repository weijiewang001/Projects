using System;

public class Library
{
  private string[] books;

  public Library(int capacity)
  {
    books = new string[capacity];
  }

  public string this[int index]
  {
    get
    {
      if (index >= 0 && index < books.Length)
      {
        return books[index];
      }
      else
      {
        throw new IndexOutOfRangeException("Invalid index.");
      }
    }
    set
    {
      if (index >= 0 && index < books.Length)
      {
        books[index] = value;
      }
      else
      {
        throw new IndexOutOfRangeException("Invalid index.");
      }
    }
  }
}

public class Program
{
  public static void Main()
  {
    Library library = new Library(5);

    library[0] = "Book 1";
    library[1] = "Book 2";
    library[2] = "Book 3";
    library[3] = "Book 4";
    library[4] = "Book 5";



    Console.WriteLine("Book at index 2: " + library[2]);
    Console.WriteLine("Book at index 4: " + library[4]);

  }
}