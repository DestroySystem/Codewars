/* Task:
Your friend has been out shopping for puppies (what a time to be alive!)... 
He arrives back with multiple dogs, and you simply do not know how to respond!
By repairing the function provided, you will find out exactly how you should respond, 
depending on the number of dogs he has.
The number of dogs will always be a number and there will always be at least 1 dog.
*/

using System.Collections.Generic;

public static class Kata
    {
    public static string HowManyDalmatians(int n)
    {
        List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
        if (n <= 10)
        {
            return dogs[0];
        } else if (n <= 50)
        {
            return dogs[1];
        } else if (n == 101)
        {
            return dogs[3];
        } else
        {
            return dogs[2];
        }
    }
}

//NUnit Tests

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("More than a handful!",Kata.HowManyDalmatians(26));
            StringAssert.AreEqualIgnoringCase("Hardly any",Kata.HowManyDalmatians(8));
            StringAssert.AreEqualIgnoringCase("More than a handful!",Kata.HowManyDalmatians(14));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!",Kata.HowManyDalmatians(80));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!",Kata.HowManyDalmatians(100));
            StringAssert.AreEqualIgnoringCase("More than a handful!",Kata.HowManyDalmatians(50));
            StringAssert.AreEqualIgnoringCase("Hardly any",Kata.HowManyDalmatians(10));
            StringAssert.AreEqualIgnoringCase("101 DALMATIONS!!!",Kata.HowManyDalmatians(101));
        }
    }