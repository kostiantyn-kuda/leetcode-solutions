namespace LeetCode.Solutions.Others.Arrays;

// 1. Two Sum
// https://leetcode.com/problems/two-sum/
public class TwoSum
{
    public (int index1, int index2) Find(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var value = nums[i];

            var diff = target - value;

            if (dict.TryGetValue(diff, out var dictValue))
            {
                return (dictValue, i);
            }
            dict[value] = i;
        }
        throw new NotSupportedException();
    }
}