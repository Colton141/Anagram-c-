using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
 public class ItemTest : IDisposable
 {

   public void Dispose()
   {
     //Act
     Word.ClearAll();
   }


    [TestMethod]
    public void IsThereAnAnagram_GetWordThatMatches_True()
    {
      //Arrange
      Word newWord = new Word ("test");

      //Act
      // string output = newWord.IsThereAnAnagram();

      //Assert

      Assert.AreEqual (true, Word.IsThereAnAnagram("bread", "beard"));
    }

    // [TestMethod]
    // public void IsThereAnAnagram_GetWordThatMatches_False()
    // {
    //   //Arrange
    //   Word newWord = new Word ("test");
    //
    //   //Act
    //   // string output = newWord.IsThereAnAnagram();
    //
    //   //Assert
    //
    //   Assert.AreEqual (true, Word.IsThereAnAnagram("bread", "beard"));
    // }




  // [TestMethod]
  // public void Word_GetAll_String()
  // {
  //   //Arrange
  //   Word newWord = new Word ("test");
  //
  //   //Act
  //   string output = newWord.GetAll();
  //
  //   //Assert
  //   Assert.AreEqual (output, true)
  // }


}
}
