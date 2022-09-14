using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class SingleNumberTests
{
    private SingleNumber _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new SingleNumber();
    }

    [TestCase("2,2,1", 1)]
    [TestCase("4,1,2,1,2", 4)]
    [TestCase("1", 1)]
    public void FindTest(string stringArray, int expectedResult)
    {
        var result = _solution.Find2(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
    
    [TestCase("2,2,1", 1)]
    [TestCase("4,1,2,1,2", 4)]
    [TestCase("1", 1)]
    public void Find2Test(string stringArray, int expectedResult)
    {
        var result = _solution.Find2(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
    
    [TestCase("2,2,1", 1)]
    [TestCase("4,1,2,1,2", 4)]
    [TestCase("1", 1)]
    public void Find3Test(string stringArray, int expectedResult)
    {
        var result = _solution.Find3(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
}