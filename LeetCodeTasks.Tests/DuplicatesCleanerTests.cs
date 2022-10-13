using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class DuplicatesCleanerTests
{
    [Fact]
    public void Check_RemoveDuplicatesFromSortedArray()
    {
        var input1 = new int[] { 1, 2, 2, 3, 4, 4, 5, 5, 6 }; // 6
        var input2 = new int[] { 0, 0, 1, 1, 2 }; // 3

        var result1 = DuplicatesCleaner.RemoveDuplicatesFromSortedArray(input1);
        var result2 = DuplicatesCleaner.RemoveDuplicatesFromSortedArray(input2);
        
        Assert.Equal(6, result1);  
        Assert.Equal(3, result2);

    }
}