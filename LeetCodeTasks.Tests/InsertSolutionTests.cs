using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class InsertSolutionTests
{
    [Fact]
    public void Check_InsertSort()
    {
        var testArray = new[] { 90, -90, 1, 2, 3, 4, 5, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        var sortedArray = new[] { -90, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7, 8, 9, 90 };
        InsertSortSolution.DoSort(testArray);
        Assert.Equal(testArray, sortedArray);
    }
}