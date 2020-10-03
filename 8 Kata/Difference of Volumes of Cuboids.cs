/* Task:
In this simple exercise, you will create a program that will take two lists of integers, a and b. 
Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b. 
You must find the difference of the cuboids' volumes regardless of which is bigger.

For example, if the parameters passed are ([2, 2, 3], [5, 4, 1]), 
the volume of a is 12 and the volume of b is 20. Therefore, the function should return 8.
*/

public class Kata
{
    public static int FindDifference(int[] a, int[] b)
    {
        int sum_a = 1, sum_b = 1;
        for(int i = 0; i < a.Length; i++)
        {
            sum_a *= a[i];
        }
        for(int j = 0; j < b.Length; j++)
        {
            sum_b *= b[j];
        }
        if(sum_a > sum_b)
        {
            return sum_a -= sum_b;
        }
        else
        {
           return sum_b -= sum_a;
        }    
    }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class Sample_Tests
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(new[] {new int[] {3, 2, 5}, new int[] {1, 4, 4}}).Returns(14);
        yield return new TestCaseData(new[] {new int[] {9, 7, 2}, new int[] {5, 2, 2}}).Returns(106);
        yield return new TestCaseData(new[] {new int[] {11, 2, 5}, new int[] {1, 10, 8}}).Returns(30);
        yield return new TestCaseData(new[] {new int[] {4, 4, 7}, new int[] {3, 9, 3}}).Returns(31);
        yield return new TestCaseData(new[] {new int[] {15, 20, 25}, new int[] {10, 30, 25}}).Returns(0);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public int Test(int[] a, int[] b) => Kata.FindDifference(a, b);
  }
}