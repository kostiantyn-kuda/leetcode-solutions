using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class FindDisappearedNumbersTests
{
    private FindDisappearedNumbers _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new FindDisappearedNumbers();
    }
    
    [TestCase(new[]{4,3,2,7,8,2,3,1}, new[]{5,6})]
    [TestCase(new[]{1,1}, new[]{2})]
    public void FindTest(int[] inputArray, int[] expectedArray)
    {
        var resultArray = _solution.Find(inputArray);
        resultArray.Should().BeEquivalentTo(expectedArray);
    }
    
    [TestCase(new[]{4,3,2,7,8,2,3,1}, new[]{5,6})]
    [TestCase(new[]{1,1}, new[]{2})]
    public void Find2Test(int[] inputArray, int[] expectedArray)
    {
        var resultArray = _solution.Find2(inputArray);
        resultArray.Should().BeEquivalentTo(expectedArray);
    }
}