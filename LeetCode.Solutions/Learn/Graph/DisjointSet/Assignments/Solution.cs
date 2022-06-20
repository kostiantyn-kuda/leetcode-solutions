namespace LeetCode.Solutions.Learn.Graph.DisjointSet.Assignments;

public class Solution
{
    // https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3845/
    // LeetCode 547 - Number of Provinces
    public int FindCircleNum(int[][] isConnected)
    {
        var n = isConnected.Length;

        var union = BuildUnion(isConnected, n);

        var result = 0;
        for (var i = 0; i < n; i++)
        {
            if (union[i] == i)
            {
                result++;
            }
        }
        return result;
    }
    
    private static PathCompressionOptimizationWithUnionByRank BuildUnion(IReadOnlyList<int[]> isConnected, int n)
    {
        var union = new PathCompressionOptimizationWithUnionByRank(n);

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                var connected = isConnected[i][j] == 1;

                if (!connected)
                {
                    continue;
                }

                // if (union.Connected(i, j))
                // {
                //     continue;
                // }

                union.Union(i, j);
            }
        }

        return union;
    }
}