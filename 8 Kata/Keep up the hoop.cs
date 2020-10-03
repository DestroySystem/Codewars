/* Task:
Alex just got a new hula hoop, he loves it but feels discouraged because his little brother is better than him
Write a program where Alex can input (n) how many times the hoop goes round and it will return him an encouraging message :)
*/

public class Kata
{
  public static string HoopCount(int n)
  {
    if(n >= 10)
      {
      return "Great, now move on to tricks";
    }
    else
      {
      return "Keep at it until you get it";
    }
  }
}

//NUnit Tests

using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
  [Test]
  public static void FixedTest()
  {
    Assert.AreEqual("Keep at it until you get it", Kata.HoopCount(6), "Should work for 6");
    Assert.AreEqual("Great, now move on to tricks", Kata.HoopCount(22), "Should work for 22");
  }
}