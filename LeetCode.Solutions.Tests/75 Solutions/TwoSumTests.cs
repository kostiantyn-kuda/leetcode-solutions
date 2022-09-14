using LeetCode.Solutions._75_Solutions;

namespace LeetCode.Solutions.Tests._75_Solutions;

[TestFixture]
public class TwoSumTests
{
    private TwoSum _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new TwoSum();
    }
    
    [TestCase("2,7,11,15", 9, "0,1")]
    [TestCase("3,2,4", 6, "1,2")]
    [TestCase("3,3", 6, "0,1")]
    public void FindIndexes(string stringArray, int target, string expectedStringArray)
    {
        var indexes = _solution.Find(stringArray.ToInt32Array(), target);

        var expectedIndexArray = expectedStringArray.ToInt32Array();
        indexes.index1.Should().Be(expectedIndexArray[0]);
        indexes.index2.Should().Be(expectedIndexArray[1]);
    }
}