/* Task:
Get ASCII value of a character.
*/

using System;

public static class Kata
{
  public static int GetASCII(char c) => (int)c;
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
      Assert.That(Kata.GetASCII('A'), Is.EqualTo(65));
      Assert.That(Kata.GetASCII(' '), Is.EqualTo(32));
      Assert.That(Kata.GetASCII('!'), Is.EqualTo(33));
    }
  }
}