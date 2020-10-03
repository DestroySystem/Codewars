/* Task:
I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. 
I'll appreciate for your help.
P.S. Each array includes only integer numbers. Output is a number too.
*/

public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        int sum1 = 0, sum2 = 0;
        for(int i = 0; i < arr1.Length; i++)
        {
            sum1 += arr1[i];
        }
        for(int j = 0; j < arr2.Length; j++ )
        {
            sum2 += arr2[j];
        }
        return sum1 + sum2;
    }
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(21, Kata.ArrayPlusArray(new int[]{1,2,3}, new int[]{4,5,6}));
      Assert.AreEqual(-21, Kata.ArrayPlusArray(new int[]{-1,-2,-3}, new int[]{-4,-5,-6}));
      Assert.AreEqual(15, Kata.ArrayPlusArray(new int[]{0,0,0}, new int[]{4,5,6}));
      Assert.AreEqual(2100, Kata.ArrayPlusArray(new int[]{100,200,300}, new int[]{400,500,600}));
      
    }
  }
}