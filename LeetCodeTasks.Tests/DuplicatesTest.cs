using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class DuplicatesTest
    {
        [Fact]
        public void HasDuplicates()
        {
            // Arrange
            var nums1 = new[] { 1, 2, 3, 1 };
            var nums2 = new[] { 1, 2, 3, 4 };
            var nums3 = new[] { 0, 2, 4, 6, 2, 0 };
            // Act
            var result1 = Duplicates.HasDuplicates(nums1);
            var result2 = Duplicates.HasDuplicates(nums2);
            var result3 = Duplicates.HasDuplicates(nums3);
            // Assert
            Assert.True(result1);
            Assert.False(result2);
            Assert.True(result3);
        }
    }
}