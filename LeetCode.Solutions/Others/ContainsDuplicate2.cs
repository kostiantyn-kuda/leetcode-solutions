namespace LeetCode.Solutions.Others;

// 219. Contains Duplicate II
// https://leetcode.com/problems/contains-duplicate-ii/
public class ContainsDuplicate2
{
    public bool Check(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (Math.Abs(i - dict[nums[i]]) <= k)
                {
                    return true;
                }
            }
            dict[nums[i]] = i;
        }
        return false;
    }
}