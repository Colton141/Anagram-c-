using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");
      string inputtedWord = Console.ReadLine();

      Console.WriteLine("Enter a list of words to match: ");
      string inputtedList = Console.ReadLine();

      // Word toCheck = new Word(inputtedWord, inputtedList);
      string answer = Word.IsThereAnAnagram(inputtedWord, inputtedList);
      Console.WriteLine("This is " + answer);

    }
  }
}
