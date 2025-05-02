// Written by Holbrait
// 04/09/25

using System;

public class Program
{
    public static void Main()
    {
        LetterFinder finder = new LetterFinder();

        Console.WriteLine("Enter the original string (s):");
        string s = Console.ReadLine();

        Console.WriteLine("Enter the changed string (t):");
        string t = Console.ReadLine();

        char addedLetter = finder.FindAddedLetter(s, t);

        Console.WriteLine("The added letter is: " + addedLetter);
    }
}
