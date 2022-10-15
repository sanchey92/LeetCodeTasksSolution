using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class RemoveElementSolutionTests
{
    [Fact]
    public void Check_RemoveElement()
    {
        var nums1 = new int[] { 3, 2, 3, 2 };
        const int value1 = 3;

        var result1 = RemoveElementSolution.RemoveElement(nums1, value1);

        Assert.Equal(2, result1);
    }
}