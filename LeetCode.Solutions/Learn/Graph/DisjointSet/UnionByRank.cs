namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3879/
public class UnionByRank
{
    private readonly int[] _root;
    private readonly int[] _rank;

    public UnionByRank(int numberOfElements)
    {
        _root = new int[numberOfElements];
        _rank = new int[numberOfElements];

        for (var i = 0; i < numberOfElements; i++)
        {
            _root[i] = i;
            _rank[i] = 1;
        }
    }
    
    //Time Complexity: O(logN)
    public void Union((int left, int right) vertices)
    {
        var rootOfLeft = Find(vertices.left);
        var rootOfRight = Find(vertices.right);

        if (rootOfLeft != rootOfRight)
        {
            var rankOfLeft = _rank[rootOfLeft];
            var rankOfRight = _rank[rootOfRight];

            if (rankOfLeft > rankOfRight)
            {
                _root[rootOfRight] = rootOfLeft;
            }
            else if (rankOfRight > rankOfLeft)
            {
                _root[rootOfLeft] = rootOfRight;
            }
            else
            {
                _root[rootOfRight] = rootOfLeft;
                _rank[rootOfLeft]++;
            }
        }
    }

    //Time Complexity: O(logN)
    public bool Connected((int left, int right) vertices)
    {
        return Find(vertices.left) == Find(vertices.right);
    }

    //Time Complexity: O(logN)
    private int Find(int vertex)
    {
        while (vertex != _root[vertex])
        {
            vertex = _root[vertex];
        }
        return vertex;
    }
}