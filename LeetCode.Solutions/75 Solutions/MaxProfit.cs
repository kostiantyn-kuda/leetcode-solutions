﻿namespace LeetCode.Solutions._75_Solutions;

// 121
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class MaxProfit
{
    public int Find(int[] prices)
    {
        if (prices.Length == 0)
        {
            return 0;
        }
        
        var minIndex = 0;
        var maxProfit = 0;
        
        for (int i = 0; i < prices.Length; i++)
        {
            var currentPrice = prices[i];
            
            var profit = currentPrice - prices[minIndex];

            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
            else if (profit < 0)
            {
                minIndex = i;
            }
        }

        return maxProfit;
    }
}