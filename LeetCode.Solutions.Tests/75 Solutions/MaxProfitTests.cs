using System;
using System.Linq;
using LeetCode.Solutions._75_Solutions;

namespace LeetCode.Solutions.Tests._75_Solutions;

[TestFixture]
public class MaxProfitTests
{
    [TestCase("7,1,5,3,6,4", 5)]
    [TestCase("7,6,4,3,1", 0)]
    public void Find(string inputPricesString, int expectedResult)
    {
        var prices = inputPricesString.Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32(x))
            .ToArray();
        
        var instance = new MaxProfit();
        var result = instance.Find(prices);
        result.Should().Be(expectedResult);
    }
}