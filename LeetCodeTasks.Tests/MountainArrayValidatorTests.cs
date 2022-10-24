using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class MountainArrayValidatorTests
{
    [Fact]
    public void Check_Solution()
    {
        var input1 = new int[] { 2, 1 }; // false
        var input2 = new int[] { 3, 5, 5 }; // false
        var input3 = new int[] { 0, 3, 2, 1 }; // true

        var result1 = MountainArrayValidator.GetValidation(input1);
        var result2 = MountainArrayValidator.GetValidation(input2);
        var result3 = MountainArrayValidator.GetValidation(input3);

        Assert.False(result1);
        Assert.False(result2);
        Assert.True(result3);
    }
}