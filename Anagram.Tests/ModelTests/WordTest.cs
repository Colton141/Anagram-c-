using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void IsThisAWord_WordEntered_String()
    {
      AnagramClass testAnagram = new AnagramClass();
      Assert.AreEqual("bread", testAnagram.IsThisAWord("bread"));
    }
    [TestMethod]
    public void IsThisAListOfWords_ListEntered_True()
    {
      AnagramClass testAnagram = new AnagramClass();
      Assert.AreEqual(wordList, testAnagram.IsThisAListOfWords("bear, beard, break"));
    }

  }


}
