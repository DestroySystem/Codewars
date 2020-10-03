/* Task:
The code gives an error!
Kata.A = 123.ToSTring();
Fix it!
*/

public class Kata
{
  public static string A = (123.ToString());
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void Test()
    {
      Assert.AreEqual("123", Kata.A);
    }
  }
}