using System;
using System.Linq;
using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class ContainsDuplicateTests
{
    [TestCase("1,2,3,1", true)]
    [TestCase("1,2,3,4", false)]
    [TestCase("1,1,1,3,3,4,3,2,4,2", true)]
    public void CheckTest(string arrayString, bool expectedResult)
    {
        var inputArray = arrayString
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        var solution = new ContainsDuplicate();
        var result = solution.Check(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase("1,2,3,1", true)]
    [TestCase("1,2,3,4", false)]
    [TestCase("1,1,1,3,3,4,3,2,4,2", true)]
    public void Check2Test(string arrayString, bool expectedResult)
    {
        var inputArray = arrayString
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        var solution = new ContainsDuplicate();
        var result = solution.Check2(inputArray);
        result.Should().Be(expectedResult);
    }
}