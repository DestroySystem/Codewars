/* Task:
In this Kata we are passing a number (n) into a function.
Your code will determine if the number passed is even (or not).
The function needs to return either a true or false.
Numbers may be positive or negative, integers or floats.
*/

public class Number
{
  public bool IsEven(double n)
  {
    if(n % 2 == 0)
      {
      return true;
    }else
      {
      return false;
    }
  }
}

//NUnit Tests

using NUnit.Framework;

[TestFixture]
public class NumberTest
{
  private Number num;
  
  [SetUp]
  public void SetUp() 
  {
    num = new Number();
  }

  [TearDown]
  public void TearDown()
  {
    num = null;
  }

  [Test]
  public void Tests()
  {
    Assert.AreEqual(true, num.IsEven(0));
    Assert.AreEqual(false, num.IsEven(0.5));
    Assert.AreEqual(false, num.IsEven(1));
    Assert.AreEqual(true, num.IsEven(2));
    Assert.AreEqual(true, num.IsEven(-4));    
  }
}