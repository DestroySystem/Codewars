/* Task:
Write a method sum (sum_array in python, sumarray in julia, SumArray in C#) that takes an array of numbers 
and returns the sum of the numbers. These may be integers or decimals for Ruby and any instance of Num for Haskell. 
The numbers can also be negative. If the array does not contain any numbers then you should return 0.
Exemple: Kata.SumArray(new int[] {1, 2, 3}) => 6
*/

public class Kata
{
  public static double SumArray(double[] array)
  {
    double sum = 0;
    for(int i = 0; i < array.Length; i++)
      {
      sum += array[i];
    }
    return sum;
  }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Sample_Test
  {
    private static object[] testCases = new object[]
    {
      new object[] {new double[] {1, 5.2, 4, 0, -1}, 9.2},
      new object[] {new double[] {}, 0},
    };
  
    [Test, TestCaseSource("testCases")]
    public void Test(double[] array, double expected) => Assert.AreEqual(expected, Kata.SumArray(array));
  }
}