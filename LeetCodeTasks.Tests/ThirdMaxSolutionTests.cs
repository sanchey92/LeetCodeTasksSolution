using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class ThirdMaxSolutionTests
{
    [Fact]
    public void Check_FindThirdMax()
    {
        var input1 = new int[] { 3, 2, 1 };
        var input2 = new int[] { 1, 2 };
        var input3 = new int[] { 2, 2, 3, 1 };

        var output1 = ThirdMaxSolution.FindThirdMax(input1);
        var output2 = ThirdMaxSolution.FindThirdMax(input2);
        var output3 = ThirdMaxSolution.FindThirdMax(input3);
        
        Assert.Equal(1, output1);
        Assert.Equal(2, output2);
        Assert.Equal(1, output3);
    }
}