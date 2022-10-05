using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

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
    public void FindWithBrutForceTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.FindWithBrutForce(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new[]{5,4,-1,7,8}, 23)]
    public void FindWithBrutForcePlusPartialCachingTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.FindWithBrutForcePlusPartialCaching(inputArray);
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