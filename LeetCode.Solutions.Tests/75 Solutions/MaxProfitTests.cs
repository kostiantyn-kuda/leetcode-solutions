using LeetCode.Solutions._75_Solutions;

namespace LeetCode.Solutions.Tests._75_Solutions;

[TestFixture]
public class MaxProfitTests
{
    private MaxProfit _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new MaxProfit();
    }
    
    [TestCase("7,1,5,3,6,4", 5)]
    [TestCase("7,6,4,3,1", 0)]
    public void Find(string stringArray, int expectedResult)
    {
        var result = _solution.Find(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
}