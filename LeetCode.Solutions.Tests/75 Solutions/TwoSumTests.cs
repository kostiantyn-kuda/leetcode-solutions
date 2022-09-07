using System;
using System.Linq;
using LeetCode.Solutions._75_Solutions;

namespace LeetCode.Solutions.Tests._75_Solutions;

[TestFixture]
public class TwoSumTests
{
    [TestCase("2,7,11,15", 9, "0,1")]
    [TestCase("3,2,4", 6, "1,2")]
    [TestCase("3,3", 6, "0,1")]
    public void FindIndexes(string inputArrayString, int target, string expectedIndexArrayString)
    {
        var inputArray = inputArrayString.Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();
        
        var expectedIndexArray = expectedIndexArrayString.Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();

        var instance = new TwoSum();
        var indexes = instance.Find(inputArray, target);
        
        
        indexes.index1.Should().Be(expectedIndexArray[0]);
        indexes.index2.Should().Be(expectedIndexArray[1]);
    }
}