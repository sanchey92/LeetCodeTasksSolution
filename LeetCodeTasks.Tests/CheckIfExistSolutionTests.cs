using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class CheckIfExistSolutionTests
{
    [Fact]
    public void Check_Solution()
    {
        var arr1 = new int[] { 10, 2, 5, 3 }; // true
        var arr2 = new int[] { 3, 1, 7, 11 }; // false

        var result1 = CheckIfExistSolution.GetSolution(arr1);
        var result2 = CheckIfExistSolution.GetSolution(arr2);
        
        Assert.True(result1);
        Assert.False(result2);
    }
}