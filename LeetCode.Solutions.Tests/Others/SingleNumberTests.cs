using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class SingleNumberTests
{
    private SingleNumber _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new SingleNumber();
    }

    [TestCase(new[]{2,2,1}, 1)]
    [TestCase(new[]{4,1,2,1,2}, 4)]
    [TestCase(new[]{1}, 1)]
    public void FindTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{2,2,1}, 1)]
    [TestCase(new[]{4,1,2,1,2}, 4)]
    [TestCase(new[]{1}, 1)]
    public void Find2Test(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find2(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{2,2,1}, 1)]
    [TestCase(new[]{4,1,2,1,2}, 4)]
    [TestCase(new[]{1}, 1)]
    public void Find3Test(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find3(inputArray);
        result.Should().Be(expectedResult);
    }
}