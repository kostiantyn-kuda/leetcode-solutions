using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class MissingNumberTests
{
    private MissingNumber _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new MissingNumber();
    }
    
    [TestCase("3,0,1", 2)]
    [TestCase("0,1", 2)]
    [TestCase("9,6,4,2,3,5,7,0,1", 8)]
    public void CalculateTest(string stringArray, int expectedResult)
    {
        var result = _solution.Calculate(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
}