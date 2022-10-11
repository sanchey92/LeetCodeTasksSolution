using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class BraceBalanceTests
{
    [Fact]
    public void Check_Solution()
    {
        const string str1 = "()[][{}]"; //true 
        const string str2 = "{]"; //@false
        const string str3 = ")][{}]"; //false
        const string str4 = "({}a)"; //true;
        
        
        Assert.True(BraceBalance.IsBalanced(str1));
        Assert.False(BraceBalance.IsBalanced(str2));
        Assert.False(BraceBalance.IsBalanced(str3));
        Assert.True(BraceBalance.IsBalanced(str4));

    }
}