using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class ContainsDuplicateTests
{
    private ContainsDuplicate _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ContainsDuplicate();
    }
    
    [TestCase(new[]{1,2,3,1}, true)]
    [TestCase(new[]{1,2,3,4}, false)]
    [TestCase(new[]{1,1,1,3,3,4,3,2,4,2}, true)]
    public void CheckTest(int[] inputArray, bool expectedResult)
    {
        var result = _solution.Check(inputArray);
        result.Should().Be(expectedResult);
    }
    
    [TestCase(new[]{1,2,3,1}, true)]
    [TestCase(new[]{1,2,3,4}, false)]
    [TestCase(new[]{1,1,1,3,3,4,3,2,4,2}, true)]
    public void Check2Test(int[] inputArray, bool expectedResult)
    {
        var result = _solution.Check2(inputArray);
        result.Should().Be(expectedResult);
    }
}