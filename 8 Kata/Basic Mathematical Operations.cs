/* Task:
Your task is to create a function that does four basic mathematical operations.
The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.

Examples
basicOp('+', 4, 7)         // Output: 11
basicOp('-', 15, 18)       // Output: -3
basicOp('*', 5, 5)         // Output: 25
basicOp('/', 49, 7)        // Output: 7
*/

namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch(operation)
            {
                case '+':
                    return value1 + value2;
                    break;
                case '-':
                    return value1 - value2;
                    break;
                case '*':
                    if (value1 > 0 && value2 > 0)
                        return value1 * value2;
                    break;
                case '/':
                    if (value1 > 0 && value2 > 0)
                        return value1 / value2;
                    else
                        return value2 / value1;
                    break;
            }
            return 0;
        }
    }
}

//NUnit Tests

namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void StaticTests()
    {
      Assert.AreEqual(Program.basicOp('+', 4, 7), 11);
      Assert.AreEqual(Program.basicOp('-', 15, 18), -3);
      Assert.AreEqual(Program.basicOp('*', 5, 5), 25);
      Assert.AreEqual(Program.basicOp('/', 49, 7), 7);
    }
  }
}