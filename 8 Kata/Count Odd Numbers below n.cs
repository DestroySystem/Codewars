/* Task:
Given a number n, return the number of positive odd numbers below n, EASY!

Kata.OddCount(7) => 3, i.e [1, 3, 5]
Kata.OddCount(15) => 7, i.e [1, 3, 5, 7, 9, 11, 13]
*/

public static class Kata
{
    public static ulong OddCount(ulong n)
    {
        ulong count = 0, odd = 0;
        ulong[] array = new ulong[n];
        for (ulong i = 1; i < n; i++)
        {
            count++;
            array[i] = count;

            if (array[i] % 2 != 0 && array[i] > 0)
            {
                odd++;
            }
        }
        return odd;
    }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SampleTest
  {
    [Test]
    public void Test()
    {
      Assert.AreEqual(7, Kata.OddCount(15));
      Assert.AreEqual(7511, Kata.OddCount(15023));
    }
  }
}