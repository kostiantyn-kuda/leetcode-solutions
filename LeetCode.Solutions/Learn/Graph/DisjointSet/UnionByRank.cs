namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3879/
public class UnionByRank
{
    private readonly int[] _root;
    private readonly int[] _rank;

    public UnionByRank(int size)
    {
        _root = new int[size];
        _rank = new int[size];

        for (var i = 0; i < size; i++)
        {
            _root[i] = i;
            _rank[i] = 1;
        }
    }
    
    //Time Complexity: O(logN)
    public void Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);

        if (rootX != rootY)
        {
            var rankX = _rank[rootX];
            var rankY = _rank[rootY];

            if (rankX > rankY)
            {
                _root[rootY] = rootX;
            }
            else if (rankY > rankX)
            {
                _root[rootX] = rootY;
            }
            else
            {
                _root[rootY] = rootX;
                _rank[rootX]++;
            }
        }
    }

    //Time Complexity: O(logN)
    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }

    //Time Complexity: O(logN)
    private int Find(int x)
    {
        while (x != _root[x])
        {
            x = _root[x];
        }
        return x;
    }
}