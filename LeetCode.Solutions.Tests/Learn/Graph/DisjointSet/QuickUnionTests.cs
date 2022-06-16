namespace LeetCode.Solutions.Tests.Learn.Graph.DisjointSet;

[TestFixture]
public class QuickUnionTests
{
    [Test]
    public void Test_IfConnected()
    {
        var quickUnion = new QuickUnion(10);
        // 1-2-5-6-7 3-8-9 4
        quickUnion.Union((1, 2));
        quickUnion.Union((2, 5));
        quickUnion.Union((5, 6));
        quickUnion.Union((6, 7));
        quickUnion.Union((3, 8));
        quickUnion.Union((8, 9));

        quickUnion.Connected((1, 5)).Should().BeTrue();
        quickUnion.Connected((5, 7)).Should().BeTrue();
        quickUnion.Connected((4, 9)).Should().BeFalse();
        
        // 1-2-5-6-7 3-8-9-4
        quickUnion.Union((9, 4));
        quickUnion.Connected((4, 9)).Should().BeTrue();
    }
}