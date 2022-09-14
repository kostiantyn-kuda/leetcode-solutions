using System;
using System.Linq;
using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class MissingNumberTests
{
    [TestCase("3,0,1", 2)]
    [TestCase("0,1", 2)]
    [TestCase("9,6,4,2,3,5,7,0,1", 8)]
    public void CalculateTest(string arrayString, int expectedResult)
    {
        var inputArray = arrayString
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        var solution = new MissingNumber();
        var result = solution.Calculate(inputArray);
        result.Should().Be(expectedResult);
    }
}