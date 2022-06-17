namespace LeetCode.Solutions.Tests.Learn.Graph.DisjointSet;

[TestFixture]
public class QuickFindTests
{
    [Test]
    public void Test_IfConnected()
    {
        var quickFind = new QuickFind(10);
        // 1-2-5-6-7 3-8-9 4
        quickFind.Union(1, 2);
        quickFind.Union(2, 5);
        quickFind.Union(5, 6);
        quickFind.Union(6, 7);
        quickFind.Union(3, 8);
        quickFind.Union(8, 9);

        quickFind.Connected(1, 5).Should().BeTrue();
        quickFind.Connected(5, 7).Should().BeTrue();
        quickFind.Connected(4, 9).Should().BeFalse();
        
        // 1-2-5-6-7 3-8-9-4
        quickFind.Union(9, 4);
        quickFind.Connected(4, 9).Should().BeTrue();
    }
}