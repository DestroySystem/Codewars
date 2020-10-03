/* Task:
Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. 
Return the resulting string.
*/

using System.Text.RegularExpressions;
public class Kata
{
  public static string FakeBin(string x)
  {
    x = Regex.Replace(x, "[4321]", "0");
    x = Regex.Replace(x, "[56789]", "1");
    return x;
  }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("01011110001100111", Kata.FakeBin("45385593107843568"));
      Assert.AreEqual("101000111101101", Kata.FakeBin("509321967506747"));
      Assert.AreEqual("011011110000101010000011011", Kata.FakeBin("366058562030849490134388085"));
    }
  }
}