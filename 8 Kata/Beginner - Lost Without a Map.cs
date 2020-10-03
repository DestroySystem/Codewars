/* Task:
Given an array of integers, return a new array with each value doubled.
For example:
[1, 2, 3] --> [2, 4, 6]
*/

using System.Linq;
public class Kata
{
  public static int[] Maps(int[] x) => x.Select(v => v * 2).ToArray();
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
      Assert.AreEqual(new [] { 2, 4, 6 }, Kata.Maps(new [] { 1, 2, 3 }));
      Assert.AreEqual(new [] { 8, 2, 2, 2, 8 }, Kata.Maps(new [] { 4, 1, 1, 1, 4 }));
      Assert.AreEqual(new [] { 4, 4, 4, 4, 4, 4 }, Kata.Maps(new [] { 2, 2, 2, 2, 2, 2 }));
    }
  }
}