/* Task:
Personalized greeting
Create a function that gives a personalized greeting. This function takes two parameters: name and owner.
*/

public class Kata
{
  public static string Greet(string name, string owner)
  {
    if (name != owner)
      {
      return "Hello guest";
    }
    else
      {
      return "Hello boss";
    }
  }  
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void MyTest()
    {
      Assert.AreEqual("Hello boss", Kata.Greet("Daniel", "Daniel"));
      Assert.AreEqual("Hello guest", Kata.Greet("Greg", "Daniel"));
    }
  }
}