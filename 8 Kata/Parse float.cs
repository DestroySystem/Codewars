/* Task:
Write function parseFloat which takes an input and returns a number or Nothing if conversion is not possible.
*/

 public class Kata
    {
        public static double? ParseF(object s = null)
        {
            double i;
            if (double.TryParse(s as string, out i))
                return i;
            return null;
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
    public void SampleTest()
    {
      Assert.AreEqual(1.0d, Kata.ParseF("1"));
    }
  }
}