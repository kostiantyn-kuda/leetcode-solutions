namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class ClimbStairsTests
{
    private ClimbStairs _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new ClimbStairs();
    }
    
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(5, 8)]
    public void FindTest(int input, int output)
    {
        var result = _solution.Find(input);
        result.Should().Be(output);
    }
    
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(5, 8)]
    public void Find2Test(int input, int output)
    {
        var result = _solution.Find2(input);
        result.Should().Be(output);
    }
}