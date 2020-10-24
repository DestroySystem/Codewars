/* Task:
Some new animals have arrived at the zoo. The zoo keeper is concerned that perhaps the animals do not have the right tails. 
To help her, you must correct the broken function to make sure that the second argument (tail), 
is the same as the last letter of the first argument (body) - otherwise the tail wouldn't fit!
If the tail is right return true, else return false.

The arguments will always be strings, and normal letters.

For Haskell, body has the type of String and tail has the type of Char. For Go, body has type string and tail has type rune.
*/

//Program that need to debug

public class Kata
{
  public static bool CorrectTail(string body, string tail)
  {
    string sub = body.SubString(bodylength - (tail.length));
    
    if (sub = tail)
      return true
    else
      return false
  }
}

//Debuged Program

public class Kata
{
    public static bool CorrectTail(string body, string tail)
    {
        string sub = body.Substring(body.Length - (tail.Length));

        if (sub == tail)
            return true;
        else
            return false;
    }
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class Sample_Test
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData("Fox", "x").Returns(true);
        yield return new TestCaseData("Rhino", "o").Returns(true);
        yield return new TestCaseData("Meerkat", "t").Returns(true);
        yield return new TestCaseData("Emu", "t").Returns(false);
        yield return new TestCaseData("Badger", "s").Returns(false);
        yield return new TestCaseData("Giraffe", "d").Returns(false);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public bool Test(string body, string tail) => Kata.CorrectTail(body, tail);
  }
}