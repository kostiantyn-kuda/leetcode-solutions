namespace LeetCode.Solutions.Others;

// 136. Single Number
// https://leetcode.com/problems/single-number/
public class SingleNumber
{
    public int Find(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        Array.Sort(nums);
        for (var i = 1; i < nums.Length; i += 2)
        {
            var currentValue = nums[i];
            var previousValue = nums[i - 1];
            
            if (currentValue != previousValue)
            {
                if (nums.Length - 1 == i)
                {
                    return currentValue;
                }

                var nextValue = nums[i + 1];

                return nextValue == currentValue ? previousValue : currentValue;
            }
        }

        return nums[^1];
    }
    
    public int Find2(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
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
                dict.Add(nums[i], 1);
            }
        }

        foreach (var pair in dict)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        
        throw new NotImplementedException();
    }
    
    public int Find3(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        var result = 0;
        foreach (var t in nums)
        {
            result ^= t;
        }
        return result;
    }
}