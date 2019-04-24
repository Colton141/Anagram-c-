using System;
using System.Collections.Generic;

namespace Anagram.Models
{

  public class Word
  {
    private string _word;
    private static List<Word> _instances = new List<Word> {};

    public Word (string word)
    {
      _word = word;
      _instances.Add(this);
    }

    public string GetWord()
    {
      return _word;
    }

    public static List<Word> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static bool IsThereAnAnagram(string word,   string check)
    {
      char[] wordArray = word.ToCharArray();
      char[] checkArray = check.ToCharArray();

      Array.Sort(wordArray);
      Array.Sort(checkArray);

      string wordString = String.Join("", wordArray);
      string checkString = String.Join("", checkArray);

        if (wordString == checkString)
        {
          return true;
        }
        else {
          return false;
        }

    }
  }
}
