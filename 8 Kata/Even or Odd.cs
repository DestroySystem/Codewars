/* Task:
Create a function (or write a script in Shell) that takes an integer as an argument 
and returns "Even" for even numbers or "Odd" for odd numbers.
*/

using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      if(number % 2 == 0)
        {
        return "Even";
      }
      else
        {
        return "Odd";
      }
    }
  }
}

//NUnit Tests

using System;
using NUnit.Framework;

namespace Solution
{
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void MyTest()
    {
      Assert.AreEqual("Even", SolutionClass.EvenOrOdd(2));
      Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(1));
      Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
      Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(7));
      Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(-1));
    }
  }
}