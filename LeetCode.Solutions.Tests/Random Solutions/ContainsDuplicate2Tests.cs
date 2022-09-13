using System;
using System.Linq;
using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class ContainsDuplicate2Tests
{
    [TestCase("1,2,3,1", 3, true)]
    [TestCase("1,0,1,1", 1, true)]
    [TestCase("1,2,3,1,2,3", 2, false)]
    public void CheckTest(string arrayString, int k, bool expectedResult)
    {
        var inputArray = arrayString
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        var solution = new ContainsDuplicate2();
        var result = solution.Check(inputArray, k);
        result.Should().Be(expectedResult);
    }
}