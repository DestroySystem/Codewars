/* Task:
This function should test if the factor is a factor of base.
Return true if it is a factor or false if it is not.

About factors
Factors are numbers you can multiply together to get another number.
2 and 3 are factors of 6 because: 2 * 3 = 6
*/

using System;

public class Kata
{
  public static bool CheckForFactor(int num, int factor) => num % factor == 0 ? true : false;
}

//NUnit Tests

using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(10,2,true)]
  [TestCase(63,7,true)]
  [TestCase(2450,5,true)]
  [TestCase(24612,3,true)]
  [TestCase(9,2,false)]
  [TestCase(653,7,false)]
  [TestCase(2453,5,false)]
  [TestCase(24617,3,false)]
  public static void FixedTest(int num, int factor, bool isFactor)
  {
    Assert.AreEqual(isFactor, Kata.CheckForFactor(num, factor));
  }
}