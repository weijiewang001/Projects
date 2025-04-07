using System;
class Program
{
	static void Main()
	{
		// Sample - Search for Strings
		string songLyrics = "You say goodbye, and I say hello";
		Console.WriteLine(songLyrics.Contains("goodbye"));
		Console.WriteLine(songLyrics.Contains("greetings"));

		Console.WriteLine("3" + songLyrics.StartsWith("You"));
		Console.WriteLine("4" + songLyrics.StartsWith("goodbye"));

		Console.WriteLine(songLyrics.EndsWith("hello"));
		Console.WriteLine(songLyrics.EndsWith("goodbye"));

	}
}
