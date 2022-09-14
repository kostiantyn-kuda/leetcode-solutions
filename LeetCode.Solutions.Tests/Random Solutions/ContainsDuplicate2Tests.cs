using LeetCode.Solutions.Random_Solutions;

namespace LeetCode.Solutions.Tests.Random_Solutions;

[TestFixture]
public class ContainsDuplicate2Tests
{
    private ContainsDuplicate2 _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ContainsDuplicate2();
    }
    
    [TestCase("1,2,3,1", 3, true)]
    [TestCase("1,0,1,1", 1, true)]
    [TestCase("1,2,3,1,2,3", 2, false)]
    public void CheckTest(string stringArray, int k, bool expectedResult)
    {
        var result = _solution.Check(stringArray.ToInt32Array(), k);
        result.Should().Be(expectedResult);
    }
}