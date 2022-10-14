using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests;

public class MergeSortedSolutionTests
{
    [Fact]
    public void Check_Merge()
    {
        var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        var m = 3;
        var nums2 = new int[] { 2, 5, 6 };
        var n = 3;
        var output1 = new int[] { 1, 2, 2, 3, 5, 6 };

        MergeSortedSolution.Merge(nums1, m, nums2, n);

        Assert.Equal(nums1, output1);
    }
}