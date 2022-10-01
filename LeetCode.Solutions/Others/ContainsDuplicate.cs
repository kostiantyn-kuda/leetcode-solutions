namespace LeetCode.Solutions.Others;

// 217. Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/submissions/
public class ContainsDuplicate
{
    public bool Check(int[] nums)
    {
        if (!nums.Any())
        {
            return false;
        }
        
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                return true;
            }
            dict.Add(nums[i], 0);
        }

        return false;
    }
    
    public bool Check2(int[] nums)
    {
        if (!nums.Any())
        {
            return false;
        }

        var sortedArray = nums.OrderBy(x => x).ToArray();

        for (var i = 1; i < sortedArray.Length; i++)
        {
            if (sortedArray[i] == sortedArray[i - 1])
            {
                return true;
            }
        }
        return false;
    }
}