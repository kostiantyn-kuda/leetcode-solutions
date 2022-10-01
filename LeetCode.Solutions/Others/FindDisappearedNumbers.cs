namespace LeetCode.Solutions.Others;

// 448. Find All Numbers Disappeared in an Array
// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
public class FindDisappearedNumbers
{
    public int[] Find(int[] nums)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<int>();
        }

        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }

        var result = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var number = i + 1;
            if (!dict.ContainsKey(number))
            {
                result.Add(number);
            }
        }

        return result.ToArray();
    }

    // https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/discuss/344583/Python%3A-O(1)-space-solution
    public int[] Find2(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var number = Math.Abs(nums[i]);
            var index = number - 1;

            if (nums[index] > 0)
            {
                nums[index] *= -1;                
            }
        }

        var result = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }
        return result.ToArray();
    }
}