using System;
using System.Linq;

namespace LeetCode.Solutions.Tests.Extensions;

public static class StringExtensions
{
    public static int[] ToInt32Array(this string stringArray, char delimiter = ',')
    {
        return stringArray
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => Convert.ToInt32((string?)x))
            .ToArray();
    }
}