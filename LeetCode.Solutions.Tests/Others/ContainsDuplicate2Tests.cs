namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class ContainsDuplicate2Tests
{
    private ContainsDuplicate2 _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new ContainsDuplicate2();
    }
    
    [TestCase(new[]{1,2,3,1}, 3, true)]
    [TestCase(new[]{1,0,1,1}, 1, true)]
    [TestCase(new[]{1,2,3,1,2,3}, 2, false)]
    public void CheckTest(int[] inputArray, int k, bool expectedResult)
    {
        var result = _solution.Check(inputArray, k);
        result.Should().Be(expectedResult);
    }
}