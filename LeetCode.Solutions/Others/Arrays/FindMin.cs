namespace LeetCode.Solutions.Others.Arrays;

// 153. Find Minimum in Rotated Sorted Array
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
public class FindMin
{
    // brute-force
    public int Find1(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var min = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return min;
    }

    public int Find2(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        var low = 0;
        var high = nums.Length - 1;
        
        while (low < high)
        {
            var middle = low + (high - low) / 2;
            if (nums[middle] > nums[high])
            {
                low = middle + 1;
            }
            else
            {
                high = middle;
            }
        }

        return nums[high];
    }
}