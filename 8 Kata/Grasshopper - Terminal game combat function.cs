/* Task:
Create a combat function that takes the player's current health and the amount of damage recieved, 
and returns the player's new health. Health can't be less than 0.
*/

using System;

public static class Game
{
  public static float Combat(float health, float damage) => health - damage > 0 ? health-damage : 0;
}

//NUnit Tests

namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class BasicTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(100, 5).Returns(95);
        yield return new TestCaseData(92, 8).Returns(84);
        yield return new TestCaseData(20, 30).Returns(0);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public float Test(float health, float damage) =>
      Game.Combat(health, damage);
  }
}