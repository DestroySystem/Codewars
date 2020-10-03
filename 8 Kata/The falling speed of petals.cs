/* Task:
Write a function that receives the speed (in cm/s) of a petal as input, and returns the time it takes for that petal 
to reach the ground from the same branch.

Notes:
The movement of the petal is quite complicated, so in this case we can see the velocity as a constant during its falling.
Pay attention to the data types.
If the initial velocity is non-positive, the return value should be 0
*/

using System;

public static class Kata
{
  public static double SakuraFall(double v) => v > 0 ? (400 / v) : 0;
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class SampleTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(5).Returns(80);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public double Test(double v) =>
      Kata.SakuraFall(v);
  }
}