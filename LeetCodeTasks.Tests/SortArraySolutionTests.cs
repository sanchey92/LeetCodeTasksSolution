using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class SortArraySolutionTests
{
    [Fact]
    public void Check_SortArrayByParity()
    {
        var input1 = new int[] { 3, 1, 2, 4 };
        var input2 = new int[] { 0 };

        var output1 = new int[] { 2, 4, 3, 1 };
        var output2 = new int[] { 0 };

        var result1 = SortArraySolution.SortArrayByParity(input1);
        var result2 = SortArraySolution.SortArrayByParity(input2);

        Assert.Equal(output1, result1);
        Assert.Equal(output2, result2);
    }
}