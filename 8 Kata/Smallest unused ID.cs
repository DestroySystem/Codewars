/* Task:
You've got much data to manage and of course you use zero-based and non-negative ID's to make each data item unique!
Therefore you need a method, which returns the smallest unused ID for your next new data item...
Note: The given array of used IDs may be unsorted. For test reasons there may be duplicate IDs, but you don't have to find 
or remove them!
*/

using System;

public class Kata
{
  public static int NextId(int[] ids)
  {
    for(int i = 0; i < ids.Length; i++)
    {
      if(ids[i] != i)
        return i;
    }
    
    return ids.Length;
  }
}

//NUnit Tests

using System;
using NUnit.Framework;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(new int[]{0,1,2,3,5}, ExpectedResult=4)]
  [TestCase(new int[]{0,1,2,3,4,5,6,7,8,9,10}, ExpectedResult=11)]
  [TestCase(new int[]{9,9,8}, ExpectedResult=0)]
  public static int FixedTest(int[] ids)
  {
    return Kata.NextId(ids);
  }
}