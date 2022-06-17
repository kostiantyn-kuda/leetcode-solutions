namespace LeetCode.Solutions.Tests.Learn.Graph.DisjointSet;

[TestFixture]
public class UnionByRankTests
{
    [Test]
    public void Test_IfConnected()
    {
        var unionByRank = new UnionByRank(10);
        // 1-2-5-6-7 3-8-9 4
        unionByRank.Union(1, 2);
        unionByRank.Union(2, 5);
        unionByRank.Union(5, 6);
        unionByRank.Union(6, 7);
        unionByRank.Union(3, 8);
        unionByRank.Union(8, 9);

        unionByRank.Connected(1, 5).Should().BeTrue();
        unionByRank.Connected(5, 7).Should().BeTrue();
        unionByRank.Connected(4, 9).Should().BeFalse();
        
        // 1-2-5-6-7 3-8-9-4
        unionByRank.Union(9, 4);
        unionByRank.Connected(4, 9).Should().BeTrue();
    }
}