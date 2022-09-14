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
    
    [TestCase(new[]{3,0,1}, 2)]
    [TestCase(new[]{0,1}, 2)]
    [TestCase(new[]{9,6,4,2,3,5,7,0,1}, 8)]
    public void CalculateTest(int[] inputArray, int expectedResult)
    {
        var result = _solution.Calculate(inputArray);
        result.Should().Be(expectedResult);
    }
}