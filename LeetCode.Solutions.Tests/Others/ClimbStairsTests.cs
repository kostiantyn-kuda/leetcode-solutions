using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class ClimbStairsTests
{
    private ClimbStairs _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ClimbStairs();
    }
    
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    public void FindTest(int input, int output)
    {
        var result = _solution.Find(input);
        result.Should().Be(output);
    }
}