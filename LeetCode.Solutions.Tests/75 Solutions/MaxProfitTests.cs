﻿using LeetCode.Solutions._75_Solutions;

namespace LeetCode.Solutions.Tests._75_Solutions;

[TestFixture]
public class MaxProfitTests
{
    private MaxProfit _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new MaxProfit();
    }
    
    [TestCase(new[]{7,1,5,3,6,4}, 5)]
    [TestCase(new[]{7,6,4,3,1}, 0)]
    public void Find(int[] inputArray, int expectedResult)
    {
        var result = _solution.Find(inputArray);
        result.Should().Be(expectedResult);
    }
}