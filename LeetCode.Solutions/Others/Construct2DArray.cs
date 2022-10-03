namespace LeetCode.Solutions.Others;

// 2022. Convert 1D Array Into 2D Array
// https://leetcode.com/problems/convert-1d-array-into-2d-array/description/
public class Construct2DArray
{
    public int[][] Construct(int[] original, int m, int n)
    {
        if (m * n != original.Length)
        {
            return Array.Empty<int[]>();
        }
        
        var result = new int[m][];
        for (var i = 0; i < m; i++)
        {
            var subArray = new int[n];
            for (var j = 0; j < n; j++)
            {
                subArray[j] = original[i * n + j];
            }
            result[i] = subArray;
        }
        return result;
    }
}