using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class HeightsCheckerSolutionTests
{
    [Fact]
    public void Check_CheckHeights()
    {
        var input1 = new int[] { 1, 1, 4, 2, 1, 3 };
        var input2 = new int[] { 5, 1, 2, 3, 4 };
        var input3 = new int[] { 1, 2, 3, 4, 5 };

        var result1 = HeightsCheckerSolution.CheckHeights(input1);
        var result2 = HeightsCheckerSolution.CheckHeights(input2);
        var result3 = HeightsCheckerSolution.CheckHeights(input3);

        Assert.Equal(3, result1);
        Assert.Equal(5, result2);
        Assert.Equal(0, result3);
    }
}