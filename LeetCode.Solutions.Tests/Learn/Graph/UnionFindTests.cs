using LeetCode.Solutions.Learn.Graph;

namespace LeetCode.Solutions.Tests.Learn.Graph;

[TestFixture]
public class UnionFindTests
{
    [Test]
    public void Test_IfConnected()
    {
        var uf = new UnionFind(10);
        // 1-2-5-6-7 3-8-9 4
        uf.Union((1, 2));
        uf.Union((2, 5));
        uf.Union((5, 6));
        uf.Union((6, 7));
        uf.Union((3, 8));
        uf.Union((8, 9));

        uf.Connected((1, 5)).Should().BeTrue();
        uf.Connected((5, 7)).Should().BeTrue();
        uf.Connected((4, 9)).Should().BeFalse();
        
        // 1-2-5-6-7 3-8-9-4
        uf.Union((9, 4));
        uf.Connected((4, 9)).Should().BeTrue();
    }
}