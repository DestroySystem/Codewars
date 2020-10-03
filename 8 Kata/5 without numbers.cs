/* Task:
Write a function that always returns 5
Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/
*/

class Kata
{
    public static int UnusualFive()
    { string s = "hello";
       return s.Length;
    }
}

//NUnit Tests

using NUnit.Framework;
[TestFixture]
class Tests
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.UnusualFive(), Is.EqualTo(5));
    }
}