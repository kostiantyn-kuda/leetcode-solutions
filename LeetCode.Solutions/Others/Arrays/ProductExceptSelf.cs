namespace LeetCode.Solutions.Others.Arrays;

// 238. Product of Array Except Self
// https://leetcode.com/problems/product-of-array-except-self/
public class ProductExceptSelf
{
    public int[] CalculateWithDivisionOperator(int[] nums)
    {
        if (nums.Length == 0)
        {
            return Array.Empty<int>();
        }
        
        var productOfAll = 1;
        var zeroCount = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zeroCount++;
            }
            else
            {
                productOfAll *= nums[i];
            }
        }
        
        var resultArray = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            if (zeroCount > 0)
            {
                if (nums[i] != 0 || zeroCount > 1)
                {
                    resultArray[i] = 0;
                }
                else
                {
                    resultArray[i] = productOfAll;
                }
            }
            else
            {
                resultArray[i] = productOfAll / nums[i];
            }
        }
        return resultArray;
    }

    public int[] CalculateEfficientApproach(int[] nums)
    {
        var outputArray = new int[nums.Length];

        var prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            outputArray[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            outputArray[i] *= postfix;
            postfix *= nums[i];
        }

        return outputArray;
    }
}