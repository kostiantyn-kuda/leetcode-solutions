namespace LeetCode.Solutions.Tests.Others.Arrays;

[TestFixture]
public class SearchTests
{
    private Search _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new Search();
    }

    [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [TestCase(new[] { 1 }, 0, -1)]
    [TestCase(new[] { 5, 1, 2, 3, 4 }, 1, 1)]
    [TestCase(new[] { 8, 9, 2, 3, 4 }, 9, 1)]
    public void FindIndex_BestCase(int[] nums, int target, int expectedIndex)
    {
        var result = _solution.FindIndex(nums, target);
        result.Should().Be(expectedIndex);
    }
}