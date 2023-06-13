namespace LeetCode.Solutions.Others.Arrays;

// 53. Maximum Subarray
// https://leetcode.com/problems/maximum-subarray/
public class MaxSubArray
{
    public int FindWithBruteForce(int[] nums)
    {
        int startIndex = -1;
        int endIndex = -1;
        var currentSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                var sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum += nums[k];
                }

                if (sum > currentSum)
                {
                    currentSum = sum;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }
        return currentSum;
    }

    public int FindWithBruteForcePlusPartialCaching(int[] nums)
    {
        int startIndex = -1;
        int endIndex = -1;
        var currentSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            var iterationSum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                iterationSum += nums[j];
                
                if (iterationSum > currentSum)
                {
                    currentSum = iterationSum;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }
        return currentSum;
    }
  
    public int Find(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        int startIndex = 0;
        int endIndex = 0;
        var currentSum = nums[0];
        var max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum += nums[i];

            if (nums[i] > currentSum)
            {
                currentSum = nums[i];
                startIndex = i;
            }

            if (currentSum > max)
            {
                max = currentSum;
                endIndex = i;
            }
        }

        return max;
    }
}