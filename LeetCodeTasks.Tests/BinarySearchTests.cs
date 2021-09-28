using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void Find_Index_With_Binary_Search()
        {
            // Arrange
            var numsArray = new int[] { -1, 0, 3, 5, 9, 12 };
            // Act
            var result1 = BinarySearch.SearchIndex(numsArray, 9); // 4
            var result2 = BinarySearch.SearchIndex(numsArray, 2); // -1
            // Assert
            Assert.Equal(4, result1);
            Assert.Equal(-1, result2);
        }
    }
}