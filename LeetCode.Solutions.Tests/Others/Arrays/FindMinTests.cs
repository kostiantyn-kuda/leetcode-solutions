namespace LeetCode.Solutions.Tests.Others.Arrays;

[TestFixture]
public class FindMinTests
{
    private FindMin _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new FindMin();
    }
    
    [TestCase(new[]{3,4,5,1,2}, 1)]
    [TestCase(new[]{4,5,6,7,0,1,2}, 0)]
    [TestCase(new[]{11,13,15,17}, 11)]
    [TestCase(new[]{5,1,2,3,4}, 1)]
    public void Find1Test(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find1(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{3,4,5,1,2}, 1)]
    [TestCase(new[]{4,5,6,7,0,1,2}, 0)]
    [TestCase(new[]{11,13,15,17}, 11)]
    [TestCase(new[]{5,1,2,3,4}, 1)]
    public void Find2Test(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find2(inputArray);
        result.Should().Be(expectedResult);
    }
}