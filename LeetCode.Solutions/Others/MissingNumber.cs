namespace LeetCode.Solutions.Others;

// 268
// https://leetcode.com/problems/missing-number/
public class MissingNumber
{
    public int Calculate(int[] nums)
    {
        var expectedSum = 0;
        var currentSum = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            expectedSum += i;
            currentSum += nums[i];
        }

        expectedSum += nums.Length;

        return expectedSum - currentSum;
    }
}