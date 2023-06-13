namespace LeetCode.Solutions.Tests.Others.Arrays;

[TestFixture]
public class MaxProductTests
{
    private MaxProduct _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new MaxProduct();
    }
    
    [TestCase(new[]{2,3,-2,4}, 6)]
    [TestCase(new[]{-2,0,-1}, 0)]
    [TestCase(new[]{0,2}, 2)]
    [TestCase(new[]{3,-1,4}, 4)]
    public void FindWithBruteForceTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.FindWithBruteForce(inputArray);
        result.Should().Be(expectedResult);
    }
    
    // [TestCase(new[]{2,3,-2,4}, 6)]
    // [TestCase(new[]{-2,0,-1}, 0)]
    // [TestCase(new[]{0,2}, 2)]
    // [TestCase(new[]{3,-1,4}, 4)]
    // public void FindWithBruteForcePlusPartialCachingTest(int[] inputArray, int expectedResult)
    // {
    //     var result = _solution.FindWithBruteForcePlusPartialCaching(inputArray);
    //     result.Should().Be(expectedResult);
    // }
    
    [TestCase(new[]{2,3,-2,4}, 6)]
    [TestCase(new[]{-2,0,-1}, 0)]
    [TestCase(new[]{0,2}, 2)]
    [TestCase(new[]{3,-1,4}, 4)]
    public void FindTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find(inputArray);
        result.Should().Be(expectedResult);
    }
}