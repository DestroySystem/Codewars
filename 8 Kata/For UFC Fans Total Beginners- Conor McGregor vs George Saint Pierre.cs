/* Task:
This is a beginner friendly kata especially for UFC/MMA fans.

It's a fight between the two legends: Conor McGregor vs George Saint Pierre in Madison Square Garden. 
Only one fighter will remain standing, and after the fight in an interview with Joe Rogan the winner will make his legendary statement. 
It's your job to return the right statement depending on the winner!
*/

using System;

public static class Kata
{
  public static string Quote(string fighter) => string.Equals(fighter, "Conor McGregor", StringComparison.CurrentCultureIgnoreCase) ? "I'd like to take this chance to apologize.. To absolutely NOBODY!" : "I am not impressed by your performance.";
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
      Assert.AreEqual("I am not impressed by your performance.", Kata.Quote("george saint pierre"));
      Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", Kata.Quote("conor mcgregor"));
      Assert.AreEqual("I am not impressed by your performance.", Kata.Quote("George Saint Pierre"));
      Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", Kata.Quote("Conor McGregor"));
    }
  }
}
