namespace LeetCode.Solutions.Tests.Others.Arrays;

[TestFixture]
public class TwoSumTests
{
    private TwoSum _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new TwoSum();
    }
    
    [TestCase(new[]{2,7,11,15}, 9, new[]{0,1})]
    [TestCase(new[]{3,2,4}, 6, new[]{1,2})]
    [TestCase(new[]{3,3}, 6, new[]{0,1})]
    public void FindIndexes(int[] inputArray, int target, int[] expectedArray)
    {
        var indexes = _solution.Find(inputArray, target);

        indexes.index1.Should().Be(expectedArray[0]);
        indexes.index2.Should().Be(expectedArray[1]);
    }
}