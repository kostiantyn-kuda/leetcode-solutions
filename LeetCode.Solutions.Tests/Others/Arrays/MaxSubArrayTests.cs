namespace LeetCode.Solutions.Tests.Others.Arrays;

[TestFixture]
public class MaxSubArrayTests
{
    private MaxSubArray _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new MaxSubArray();
    }
    
    [TestCase(new[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new[]{5,4,-1,7,8}, 23)]
    public void FindWithBruteForceTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.FindWithBruteForce(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new[]{5,4,-1,7,8}, 23)]
    public void FindWithBruteForcePlusPartialCachingTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.FindWithBruteForcePlusPartialCaching(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new[]{5,4,-1,7,8}, 23)]
    public void FindTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find(inputArray);
        result.Should().Be(expectedResult);
    }
}