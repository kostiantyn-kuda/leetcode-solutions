namespace LeetCode.Solutions.Tests.Learn.Graph.DisjointSet;

[TestFixture]
public class PathCompressionOptimizationWithUnionByRankTests
{
    [Test]
    public void Test_IfConnected()
    {
        var pathCompressionOptimization = new PathCompressionOptimizationWithUnionByRank(10);
        // 1-2-5-6-7 3-8-9 4
        pathCompressionOptimization.Union(1, 2);
        pathCompressionOptimization.Union(2, 5);
        pathCompressionOptimization.Union(5, 6);
        pathCompressionOptimization.Union(6, 7);
        pathCompressionOptimization.Union(3, 8);
        pathCompressionOptimization.Union(8, 9);

        pathCompressionOptimization.Connected(1, 5).Should().BeTrue();
        pathCompressionOptimization.Connected(5, 7).Should().BeTrue();
        pathCompressionOptimization.Connected(4, 9).Should().BeFalse();
        
        // 1-2-5-6-7 3-8-9-4
        pathCompressionOptimization.Union(9, 4);
        pathCompressionOptimization.Connected(4, 9).Should().BeTrue();
    }
}