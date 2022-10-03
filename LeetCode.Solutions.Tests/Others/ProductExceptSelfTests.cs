using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class ProductExceptSelfTests
{
    private ProductExceptSelf _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new ProductExceptSelf();
    }

    [TestCase(new[]{1,2,3,4}, new[]{24,12,8,6})]
    [TestCase(new[]{-1,1,0,-3,3}, new[]{0,0,9,0,0})]
    [TestCase(new[]{0,0}, new[]{0,0})]
    [TestCase(new[]{0,4,0}, new[]{0,0,0})]
    public void CalculateWithDivisionOperatorTest(int[] inputArray, int[] expectedArray)
    {
        var result = _solution.CalculateWithDivisionOperator(inputArray);
        result.Should().BeEquivalentTo(expectedArray);
    }
    
    [TestCase(new[]{1,2,3,4}, new[]{24,12,8,6})]
    [TestCase(new[]{-1,1,0,-3,3}, new[]{0,0,9,0,0})]
    [TestCase(new[]{0,0}, new[]{0,0})]
    [TestCase(new[]{0,4,0}, new[]{0,0,0})]
    public void CalculateEfficientApproachTest(int[] inputArray, int[] expectedArray)
    {
        var result = _solution.CalculateEfficientApproach(inputArray);
        result.Should().BeEquivalentTo(expectedArray);
    }
}