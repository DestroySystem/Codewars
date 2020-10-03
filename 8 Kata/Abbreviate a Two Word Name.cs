/* Task:
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
The output should be two capital letters with a dot separating them.

It should look like this:
Sam Harris => S.H
Patrick Feeney => P.F
*/

using System;

public class Kata
{
    public static string AbbrevName(string name)
    {
        string s = "";
        for (int i = 1; i < name.Length - 1; i++)
        {
            if (name[i] == ' ')
            {
                s =  (Char.ToUpper(name[0]) + ("." + Char.ToUpper(name[i + 1])));
            }
        }
        return s;

    }
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class KataTests
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("S.H", Kata.AbbrevName("Sam Harris"));
      Assert.AreEqual("P.F", Kata.AbbrevName("Patrick Feenan"));
      Assert.AreEqual("E.C", Kata.AbbrevName("Evan Cole"));
      Assert.AreEqual("P.F", Kata.AbbrevName("P Favuzzi"));
      Assert.AreEqual("D.M", Kata.AbbrevName("David Mendieta"));
    }
  }
}