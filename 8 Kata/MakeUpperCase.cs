/* Task:
Write a function which converts the input string to uppercase.
*/

  public class Kata
  {
        public static string MakeUpperCase(string str) => str.ToUpper();
  }

  //NUnit Tests

  namespace Learning {
  using NUnit.Framework;
  using System;
  [TestFixture]
  public class MakeUpperCaseTest
  {
    [Test]
    public void BasicTest()
    {
       Assert.AreEqual("HELLO", Kata.MakeUpperCase("hello"));    
    }
  }    
}