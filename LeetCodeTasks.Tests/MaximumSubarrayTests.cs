using System.Collections.Generic;
using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void Find_Maximum_Subarray()
        {
            // Arrange
            var list1 = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 }; // 6
            var list2 = new List<int> { 1 }; // 1
            var list3 = new List<int> { 5, 4, -1, 7, 8 }; // 23
            // Act
            var result1 = MaximumSubarray.FindMaxSum(list1);
            var result2 = MaximumSubarray.FindMaxSum(list2);
            var result3 = MaximumSubarray.FindMaxSum(list3);
            // Assert
            Assert.Equal(6, result1);
            Assert.Equal(1, result2);
            Assert.Equal(23, result3);
        }
    }
}