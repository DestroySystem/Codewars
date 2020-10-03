/* Task:
Description
We need a function that can transform a string into a number. What ways of achieving this do you know?

Examples
StringToNumber("1234") == 1234
StringToNumber("605") == 605
StringToNumber("1405") == 1405
StringToNumber("-7") == -7
*/

using System;
  public class Kata
  {
    public static int StringToNumber(String str) {
        int number = int.Parse(str);
      return number;
  }
}

//NUnit Tests

using NUnit.Framework;
  using System;
  [TestFixture]
  public class StringToNumberTest
  { 
    [Test]
    public void test1()
    {
      Assert.AreEqual(1234 , Kata.StringToNumber("1234"));
    }

    [Test]
    public void test2()
    {
      Assert.AreEqual(605 , Kata.StringToNumber("605"));
    }

    [Test]
    public void test3()
    {
      Assert.AreEqual(1405 , Kata.StringToNumber("1405"));
    }

    [Test]
    public void test4()
    {
      Assert.AreEqual(-7 , Kata.StringToNumber("-7"));
    }  
  }