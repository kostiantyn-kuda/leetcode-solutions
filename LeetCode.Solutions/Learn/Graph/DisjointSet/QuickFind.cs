namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3878/
public class QuickFind
{
    private readonly int[] _root;

    //Time Complexity: O(N)
    public QuickFind(int size)
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
            for (var i = 0; i < _root.Length; i++)
            {
                if (_root[i] == rootY)
                {
                    _root[i] = rootX;
                }
            }
        }
    }

    //Time Complexity: O(1)
    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }

    //Time Complexity: O(1)
    private int Find(int x)
    {
        return _root[x];
    }
}