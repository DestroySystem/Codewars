/* Task:
Given an array of integers.
Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.
If the input array is empty or null, return an empty array.
Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/

using System.Linq;
using System;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] a)
    {
        // guard clause for edge cases
        if (a == null || a.Length == 0) return new int[0];

        int count = 0;
        int sum = 0;
        // ".ToList()" is required to iterate the sequence
        a.Select(n => n > 0 ? count++ : sum += n).ToList();

        return new[] {count, sum};
    }
}

//NUnit Tests

using System;
using NUnit.Framework;

[TestFixture]
public class SumTests
{
    [Test]
    public void CountPositivesSumNegatives_BasicTest()
    {
        int[] expectedResult = new int[] {10, -65};
    
        Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15}));
    }
    
    [Test]
    public void CountPositivesSumNegatives_InputWithZeroes()
    {
        int[] expectedResult = new int[] {8, -50};
    
        Assert.AreEqual(expectedResult, Kata.CountPositivesSumNegatives(new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}));
    }
}