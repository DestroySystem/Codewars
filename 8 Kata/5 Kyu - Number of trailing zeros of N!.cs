/* Task:
Write a program that will calculate the number of trailing zeros in a factorial of a given number.
N! = 1 * 2 * 3 * ... * N
Be careful 1000! has 2568 digits...

Examples
zeros(6) = 1
# 6! = 1 * 2 * 3 * 4 * 5 * 6 = 720 --> 1 trailing zero

zeros(12) = 2
# 12! = 479001600 --> 2 trailing zeros
Hint: You're not meant to calculate the factorial. Find another way to find the number of zeros.
*/

using System;

public static class Kata 
{
   public static int TrailingZeros(int n)
    {
        int count = 0;
        for (int i = 5; n / i >= 1; i *= 5)
            count += n / i;

        return count;
    }

}

//NUnit Tests

namespace Solution
{
  using System;
  using NUnit.Framework;
  
  [TestFixture]
  public class TrailingZeros 
  {
    [Test]
    public void BasicTests() 
    {
      Assert.AreEqual(1, Kata.TrailingZeros(5));
      Assert.AreEqual(6, Kata.TrailingZeros(25));
      Assert.AreEqual(131, Kata.TrailingZeros(531));
    }
  }
}