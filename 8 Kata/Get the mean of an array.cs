/* Task:
It's the academic year's end, fateful moment of your school report. The averages must be calculated. 
All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.
Return the average of the given array rounded down to its nearest integer.
The array will never be empty.
*/

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    return (int)marks.Average();
  }
}

//NUnit Tests

using NUnit.Framework;

public class Tests
{
  [Test]
  [TestCase(new int[]{2,2,2,2}, ExpectedResult= 2)]
  [TestCase(new int[]{5,10}, ExpectedResult= 7)]
  public static int FixedTest(int[] marks)
  {
    return Kata.GetAverage(marks);
  }
}