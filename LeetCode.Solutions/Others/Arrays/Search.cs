namespace LeetCode.Solutions.Others.Arrays;

// 33. Search in Rotated Sorted Array
// https://leetcode.com/problems/search-in-rotated-sorted-array/
public class Search
{
    public int FindIndex(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return -1;
        }
        if (nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }

        var left = 0;
        var right = nums.Length - 1;
        

        while (left < right)
        {
            var leftValue = nums[left];
            if (leftValue == target)
            {
                return left;
            }
            
            var rightValue = nums[right];
            if (rightValue == target)
            {
                return right;
            }

            var middle = (left + right) / 2;
            var middleValue = nums[middle];

            if (middleValue == target)
            {
                return middle;
            }

            if (leftValue < middleValue)
            {
                if (leftValue <= target && target < middleValue)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            else
            {
                if (target > leftValue || target <= middleValue)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
        }
        return -1;
    }
}