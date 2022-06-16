namespace LeetCode.Solutions.Learn.Graph.DisjointSet;

// https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3840/
public class QuickUnion
{
    private readonly int[] _root;

    //Time Complexity: O(N)
    public QuickUnion(int numberOfElements)
    {
        _root = new int[numberOfElements];

        for (var i = 0; i < numberOfElements; i++)
        {
            _root[i] = i;
        }
    }

    //Time Complexity: O(N)
    public void Union((int left, int right) vertices)
    {
        var leftRoot = Find(vertices.left);
        var rightRoot = Find(vertices.right);

        if (leftRoot != rightRoot)
        {
            _root[vertices.right] = vertices.left;
        }
    }

    //Time Complexity: O(N)
    public bool Connected((int left, int right) vertices)
    {
        return Find(vertices.left) == Find(vertices.right);
    }

    //Time Complexity: O(N)
    private int Find(int vertex)
    {
        while (vertex != _root[vertex])
        {
            vertex = _root[vertex];
        }
        return vertex;
    }
}