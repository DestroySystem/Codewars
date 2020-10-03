/* Task:
As you plunge out of the slide into the water, you see a shark hovering in the darkness under the pontoon... Crap!

You need to work out if the shark will get to you before you can get to the pontoon. 
To make it easier... as you do the mental calculations in the water you either freeze when you realise you are dead, 
or swim when you realise you can make it!

You are given 5 variables;

sharkDistance = distance from the shark to the pontoon. The shark will eat you if it reaches you before you escape to the pontoon.

sharkSpeed = how fast it can move in metres/second.

pontoonDistance = how far you need to swim to safety in metres.

youSpeed = how fast you can swim in metres/second.

dolphin = a boolean, if true, you can half the swimming speed of the shark as the dolphin will attack it.

The pontoon, you, and the shark are all aligned in one dimension.
If you make it, return "Alive!", if not, return "Shark Bait!".
*/

public class Kata
{
  public static string Shark(int pontoonDistance, int sharkDistance, int yourSpeed, int sharkSpeed, bool dolphin)
  {
    return pontoonDistance * sharkSpeed < yourSpeed * sharkDistance * (dolphin ? 2 : 1)
      ? "Alive!"
      : "Shark Bait!";
  }
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class BasicTests
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, true));
      Assert.AreEqual("Alive!", Kata.Shark(12, 50, 4, 8, false));
      Assert.AreEqual("Alive!", Kata.Shark(7, 55, 4, 16, true));
      Assert.AreEqual("Shark Bait!", Kata.Shark(24, 0, 4, 8, true));
      Assert.AreEqual("Shark Bait!", Kata.Shark(40, 35, 3, 20, true));
      Assert.AreEqual("Alive!", Kata.Shark(7, 8, 3, 4, true));
      Assert.AreEqual("Shark Bait!", Kata.Shark(7, 8, 3, 4, false));
    }
  }
}