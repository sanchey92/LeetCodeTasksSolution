using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class ReplaceElementsSolutionTests
{
    [Fact]
    public void Check_Replace()
    {
        var input1 = new int[] { 17, 18, 5, 4, 6, 1 };
        var input2 = new int[] { 400 };
        var output1 = new int[] { 18, 6, 6, 6, 1, -1 };
        var output2 = new int[] { -1 };

        var result1 = ReplaceElementsSolution.ReplaceElements(input1);
        var result2 = ReplaceElementsSolution.ReplaceElements(input2);

        Assert.Equal(result1, output1);
        Assert.Equal(result2, output2);
    }
}