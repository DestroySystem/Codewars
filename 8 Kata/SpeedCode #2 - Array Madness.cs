/* Task:
Objective
Given two integer arrays a, b, both of length >= 1, create a program that returns true if the sum of the squares of each 
element in a is strictly greater than the sum of the cubes of each element in b.

Exemple
Kata.ArrayMadness(new int[] {4, 5, 6}, new int[] {1, 2, 3}) => true 
// because 4 ** 2 + 5 ** 2 + 6 ** 2 > 1 ** 3 + 2 ** 3 + 3 ** 3
*/

public class Kata
{
    public static bool ArrayMadness(int[] a, int[] b)
    {
        int square = 0, cube = 0;
        if (a.Length >= 1 && b.Length >= 1)
        {
            for (int i = 0; i < a.Length; i++)
            {
                square += a[i] * a[i];
            }

            for (int j = 0; j < b.Length; j++)
            {
                cube += b[j] * b[j] * b[j];
            }
        }
        
      if(square > cube)
        {
            return true;
        }
        else
        {
            return false;
        }
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
    [Test, Description("Should work for sample tests")]
    public void SampleTest()
    {
      Assert.AreEqual(true, Kata.ArrayMadness(new int[] {4, 5, 6}, new int[] {1, 2, 3}));
      Assert.AreEqual(false, Kata.ArrayMadness(new int[] {5, 6, 7}, new int[] {4, 5, 6}));
    }
  }
}