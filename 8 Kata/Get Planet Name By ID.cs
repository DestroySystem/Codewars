/* Task:
The function is not returning the correct values. Can you figure out why?
getPlanetName(3); // should return 'Earth'
*/

public class Kata
{
    public static string GetPlanetName(int id)
    {
        string name = " ";
        switch (id)
        {
            case 1:
                name = "Mercury";
                break;
            case 2:
                name = "Venus";
                break;
            case 3:
                name = "Earth";
                break;
            case 4:
                name = "Mars";
                break;
            case 5:
                name = "Jupiter";
                break;
            case 6:
                name = "Saturn";
                break;
            case 7:
                name = "Uranus";
                break;
            case 8:
                name = "Neptune";
                break;
        }
        return name;
    }
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void Test()
    {
      Assert.AreEqual("Venus", Kata.GetPlanetName(2));
      Assert.AreEqual("Jupiter", Kata.GetPlanetName(5));
    }
  }
}