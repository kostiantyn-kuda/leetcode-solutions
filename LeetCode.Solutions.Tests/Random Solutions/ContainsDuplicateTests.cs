using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class ContainsDuplicateTests
{
    private ContainsDuplicate _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ContainsDuplicate();
    }
    
    [TestCase("1,2,3,1", true)]
    [TestCase("1,2,3,4", false)]
    [TestCase("1,1,1,3,3,4,3,2,4,2", true)]
    public void CheckTest(string stringArray, bool expectedResult)
    {
        var result = _solution.Check(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
    
    [TestCase("1,2,3,1", true)]
    [TestCase("1,2,3,4", false)]
    [TestCase("1,1,1,3,3,4,3,2,4,2", true)]
    public void Check2Test(string stringArray, bool expectedResult)
    {
        var result = _solution.Check2(stringArray.ToInt32Array());
        result.Should().Be(expectedResult);
    }
}