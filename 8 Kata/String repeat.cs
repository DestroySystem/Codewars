/* Task:
Write a function called repeat_str which repeats the given string src exactly count times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/

using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
    return new String(Enumerable.Range(0, n).SelectMany(x => s).ToArray());
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
    [Test]
    public void MyTest()
    {
      Assert.AreEqual("***", Program.repeatStr(3, "*"));
    }
  }
}