namespace LeetCode.Solutions.Others.Arrays;

// 152. Maximum Product Subarray
// https://leetcode.com/problems/maximum-product-subarray/
public class MaxProduct
{
    public int FindWithBruteForce(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        var maxProduct = Int32.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                var currentProduct = nums[i];
                
                for (int k = i + 1; k < j; k++)
                {
                    currentProduct *= nums[k];
                }

                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }
            }
        }

        return maxProduct;
    }

    // public int FindWithBruteForcePlusPartialCaching(int[] nums)
    // {
    //     if (nums.Length == 0)
    //     {
    //         return 0;
    //     }
    //
    //     if (nums.Length == 1)
    //     {
    //         return nums[0];
    //     }
    //     
    //     var maxProduct = Int32.MinValue;
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         var product = nums[i];
    //         for (int j = i; j < nums.Length; j++)
    //         {
    //             product *= nums[j];
    //             
    //             if (product > maxProduct)
    //             {
    //                 maxProduct = product;
    //             }
    //         }
    //     }
    //
    //     return maxProduct;
    // }
    
    // public int Find(int[] nums)
    // {
    //     if (nums.Length == 0)
    //     {
    //         return 0;
    //     }
    //
    //     if (nums.Length == 1)
    //     {
    //         return nums[0];
    //     }
    //     
    //     var maxProduct = Int32.MinValue;
    //     var product = 1;
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         product *= nums[i];
    //         
    //         if (product == 0)
    //         {
    //             product = nums[i];
    //         }
    //
    //         if (product > maxProduct)
    //         {
    //             maxProduct = product;
    //         }
    //     }
    //
    //     return maxProduct;
    // }
    
    public int Find(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        var maxProduct = Int32.MinValue;
        var product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
            
            if (product == 0)
            {
                product = nums[i];
            }

            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        return maxProduct;
    }
}