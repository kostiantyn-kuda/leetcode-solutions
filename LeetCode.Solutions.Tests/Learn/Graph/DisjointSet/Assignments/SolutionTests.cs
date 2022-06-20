using System.Text.Json;
using LeetCode.Solutions.Learn.Graph.DisjointSet.Assignments;

namespace LeetCode.Solutions.Tests.Learn.Graph.DisjointSet.Assignments;

[TestFixture]
public class SolutionTests
{
    [TestCase("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    [TestCase("[[1,0,0],[0,1,0],[0,0,1]]", 3)]
    [TestCase("[[1,0,0,0,0,0,0,0,0,1,0,0,0,0,0],[0,1,0,1,0,0,0,0,0,0,0,0,0,1,0],[0,0,1,0,0,0,0,0,0,0,0,0,0,0,0],[0,1,0,1,0,0,0,1,0,0,0,1,0,0,0],[0,0,0,0,1,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,1,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,0,1,0,0,0,0,0,0,0,0],[0,0,0,1,0,0,0,1,1,0,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0,0,0],[1,0,0,0,0,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0,0,0],[0,0,0,1,0,0,0,0,0,0,0,1,0,0,0],[0,0,0,0,1,0,0,0,0,0,0,0,1,0,0],[0,1,0,0,0,0,0,0,0,0,0,0,0,1,0],[0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]]", 8)]
    public void FindCircleNum_ShouldSuccess(string input, int expectedResult)
    {
        var array = JsonSerializer.Deserialize<int[][]>(input);
        var solution = new Solution();
        var result = solution.FindCircleNum(array);
        result.Should().Be(expectedResult);
    }
}