namespace LeetCode.Solutions.Others;

// 70. Climbing Stairs
// https://leetcode.com/problems/climbing-stairs/
public class ClimbStairs
{
    public int Find(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n <= 2)
        {
            return n;
        }

        return Find(n - 1) + Find(n - 2);
    }

    public int Find2(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        if (n <= 2)
        {
            return n;
        }

        var first = 1;
        var second = 2;

        for (int i = n - 2 ; i > 1 ; i--)
        {
            var temp = second;
            second += first;
            first = temp;
        }

        return first + second;
    }
}