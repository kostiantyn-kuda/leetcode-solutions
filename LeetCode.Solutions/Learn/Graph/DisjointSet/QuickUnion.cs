namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3840/
public class QuickUnion
{
    private readonly int[] _root;

    //Time Complexity: O(N)
    public QuickUnion(int size)
    {
        _root = new int[size];

        for (var i = 0; i < size; i++)
        {
            _root[i] = i;
        }
    }

    //Time Complexity: O(N)
    public void Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);

        if (rootX != rootY)
        {
            _root[y] = x;
        }
    }

    //Time Complexity: O(N)
    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }

    //Time Complexity: O(N)
    private int Find(int x)
    {
        while (x != _root[x])
        {
            x = _root[x];
        }
        return x;
    }
}