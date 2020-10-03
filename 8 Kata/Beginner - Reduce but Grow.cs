/* Task:
Given a non-empty array of integers, return the result of multiplying the values together in order. 
Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/

public class Kata
{
  public static int Grow(int[] x)
  {
    int mult = 1;
    for(int i = 0; i < x.Length; i++)
      {
      mult *= x[i];
    }
    return mult;
  }
}


//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(6, Kata.Grow(new [] { 1, 2, 3 }));
      Assert.AreEqual(16, Kata.Grow(new [] { 4, 1, 1, 1, 4 }));
      Assert.AreEqual(64, Kata.Grow(new [] { 2, 2, 2, 2, 2, 2 }));
    }
  }
}