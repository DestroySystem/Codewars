/* Task:
The wide mouth frog is particularly interested in the eating habits of other creatures.
He just can't stop asking the creatures he encounters what they like to eat. But then he meet the alligator who just LOVES 
to eat wide-mouthed frogs!
When he meets the alligator, it then makes a tiny mouth.
Your goal in this kata is to create complete the mouth_size method this method take one argument animal which corresponds 
to the animal encountered by frog. If this one is an alligator (case insensitive) return small otherwise return wide.
*/


using System;

public class Kata
{
    public static string MouthSize(string animal) => string.Equals(animal, "alligator", StringComparison.OrdinalIgnoreCase) ? "small" : "wide";
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("wide", Kata.MouthSize("toucan"));
      Assert.AreEqual("wide", Kata.MouthSize("ant bear"));
      Assert.AreEqual("small", Kata.MouthSize("alligator"));
    }
  }
}