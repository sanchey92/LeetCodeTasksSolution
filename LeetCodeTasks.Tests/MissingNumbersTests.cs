using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class MissingNumbersTests
    {
        [Fact]
        public void Search_Missing_Numbers()
        {
            // Arrange
            var nums1 = new[] { 3, 0, 1 };
            var nums2 = new[] { 0, 1 };
            var nums3 = new[] { 0 };
            var nums4 = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            // Act
            var result1 = MissingNumbers.Search(nums1);
            var result2 = MissingNumbers.Search(nums2);
            var result3 = MissingNumbers.Search(nums3);
            var result4 = MissingNumbers.Search(nums4);
            // Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
            Assert.Equal(1, result3);
            Assert.Equal(8, result4);
        }
    }
}