/* Task:
For every good kata idea there seem to be quite a few bad ones!
In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'. 
If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'. 
If there are no good ideas, as is often the case, return 'Fail!'.
*/

public class Kata
{
    public static string Well(string[] x)
    {
        int goodCount = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == "good")
            {
                goodCount++;
            }
        }
        if (goodCount == 0)
        {
            return "Fail!";
        }
        else if (goodCount > 0 && goodCount <= 2)
        {
            return "Publish!";
        }
        else if (goodCount > 2)
        {
            return "I smell a series!";
        }
        return "0";
    }
}

//NUnit Test

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("Fail!", Kata.Well(new string[] {"bad", "bad", "bad"}));
      Assert.AreEqual("Publish!", Kata.Well(new string[] {"good", "bad", "bad", "bad", "bad"}));
      Assert.AreEqual("I smell a series!", Kata.Well(new string[] {"good", "bad", "bad", "bad", "bad", "good", "bad", "bad", "good"}));
    }
  }
}