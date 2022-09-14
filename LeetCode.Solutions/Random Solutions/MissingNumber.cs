namespace LeetCode.Solutions.Random_Solutions;

// https://leetcode.com/problems/missing-number/
public class MissingNumber
{
    public int Calculate(int[] nums)
    {
        var expectedSum = 0;
        var currentSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            expectedSum += i;
            currentSum += nums[i];
        }

        expectedSum += nums.Length;

        return expectedSum - currentSum;
    }
}