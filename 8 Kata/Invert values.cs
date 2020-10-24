/* Task:
Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become 
positives.

invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
invert([]) == []
*/


namespace Solution
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            int i;
            for (i = 0; i < input.Length; i++)
            {
                input[i] *= -1;
            }
            return input;
        }
    }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Test
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(new int[] {-1,-2,-3,-4,-5}, ArraysInversion.InvertValues(new int[] {1,2,3,4,5}));
      Assert.AreEqual(new int[] {-1,2,-3,4,-5}, ArraysInversion.InvertValues(new int []{1,-2,3,-4,5}));
      Assert.AreEqual(new int[] {}, ArraysInversion.InvertValues(new int[] {}));
      Assert.AreEqual(new int[] {0}, ArraysInversion.InvertValues(new int[] {0}));
    }
  }
}
