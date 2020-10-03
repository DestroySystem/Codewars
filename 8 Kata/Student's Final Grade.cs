/* Task:
Create a function finalGrade, which calculates the final grade of a student depending on two parameters: 
a grade for the exam and a number of completed projects.
This function should take two arguments: exam - grade for exam (from 0 to 100); projects - number of completed projects (from 0 and above);
Examples:

FinalGrade(100, 12);  // 100
FinalGrade(99, 0);    // 100
FinalGrade(10, 15);   // 100

FinalGrade(85, 5);    // 90

FinalGrade(55, 3);    // 75

FinalGrade(55, 0);    // 0
FinalGrade(20, 2);    // 0
*/

using System;
using System.Linq;

namespace Solution {
  public class Kata
  {
    public static int FinalGrade(int exam, int projects)
    {
      if (exam > 90 || projects > 10)
      {
        return 100;
      }
      else if (exam > 75 && projects >= 5)
      {
        return 90;
      }
      else if (exam > 50 && projects >= 2) 
      {
        return 75;
      }
      else
      {
        return 0;
      }
      
    }
  }
}

//NUnit Tests

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class Testing
  {
    [Test]
    public void FinalGradeTest()
    {
      Assert.AreEqual(100, Kata.FinalGrade(100, 12));
      Assert.AreEqual(90, Kata.FinalGrade(85, 5));
    }
  }
}