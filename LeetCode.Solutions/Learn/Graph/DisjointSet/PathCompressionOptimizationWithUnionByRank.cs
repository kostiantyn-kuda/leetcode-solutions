namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3843/
public class PathCompressionOptimizationWithUnionByRank
{
    private readonly int[] _root;
    private readonly int[] _rank;
    
    public PathCompressionOptimizationWithUnionByRank(int size)
    {
        _root = new int[size];
        _rank = new int[size];

        for (var i = 0; i < size; i++)
        {
            _root[i] = i;
            _rank[i] = 1;
        }
    }
    
    //Time Complexity: 
    public void Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);
        if (rootX != rootY)
        {
            var rankX = _rank[x];
            var rankY = _rank[y];

            if (rankX > rankY)
            {
                _root[rootY] = rootX;
            }
            else if (rankX < rankY)
            {
                _rank[rootX] = rootY;
            }
            else
            {
                _root[rootY] = rootX;
                _rank[rootX]++;
            }
        }
    }

    //Time Complexity: 
    public bool Connected(int x, int y)
    {
        return Find(x) == Find(y);
    }

    //Time Complexity: 
    private int Find(int x)
    {
        if (x == _root[x])
        {
            return x;
        }

        _root[x] = Find(_root[x]);
        return _root[x];
    }
}