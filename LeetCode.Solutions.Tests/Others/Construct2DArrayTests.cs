using System;
using System.Collections.Generic;
using LeetCode.Solutions.Others;

namespace LeetCode.Solutions.Tests.Others;

[TestFixture]
public class Construct2DArrayTests
{
    private Construct2DArray _solution = null!;

    [SetUp]
    public void Setup()
    {
        _solution = new Construct2DArray();
    }
    
    public static IEnumerable<TestCaseData> DataSet1()
    {
        yield return new TestCaseData(
            new[]{1, 2, 3, 4}, 2, 2, new[] { new[]{ 1, 2 }, new[]{ 3, 4 } }
        );
    }
    
    public static IEnumerable<TestCaseData> DataSet2()
    {
        yield return new TestCaseData(
            new[]{1, 2, 3}, 1, 3, new[] { new[]{ 1, 2, 3 } }
        );
    }
    
    [Test]
    [TestCaseSource(nameof(DataSet1))]
    [TestCaseSource(nameof(DataSet2))]
    public void ConstructTest(int[] inputArray, int rows, int columns, int[][] expectedArray)
    {
        var resultArray = _solution.Construct(inputArray, rows, columns);
        resultArray.Should().BeEquivalentTo(expectedArray);
    }
}