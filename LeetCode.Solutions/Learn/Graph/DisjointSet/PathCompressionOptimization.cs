namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3880/
public class PathCompressionOptimization
{
    private readonly int[] _root;
    
    public PathCompressionOptimization(int size)
    {
        _root = new int[size];
        
        for (var i = 0; i < size; i++)
        {
            _root[i] = i;
        }
    }
    
    //Time Complexity: O(logN)
    public void Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);

        if (rootX != rootY)
        {
            _root[rootY] = x;
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
        if (x == _root[x])
        {
            return x;            
        }

        _root[x] = Find(_root[x]);
        return _root[x];
    }
}

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3880/