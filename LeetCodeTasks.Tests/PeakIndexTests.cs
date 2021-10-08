using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class PeakIndexTests
    {
        [Fact]
        public static void Find_Peak_Index()
        {
            // Arrange
            var arr1 = new int[] { 0, 1, 0 }; // 1
            var arr2 = new int[] { 0, 2, 1, 0 }; // 1
            var arr3 = new int[] { 0, 10, 5, 2 }; // 1
            var arr4 = new int[] { 3, 4, 5, 1 }; // 2
            var arr5 = new int[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 }; // 2
            // Act
            var result1 = PeakIndex.FindPeakIndex(arr1);
            var result2 = PeakIndex.FindPeakIndex(arr2);
            var result3 = PeakIndex.FindPeakIndex(arr3);
            var result4 = PeakIndex.FindPeakIndex(arr4);
            var result5 = PeakIndex.FindPeakIndex(arr5);
            // Assert
            Assert.Equal(1, result1);
            Assert.Equal(1, result2);
            Assert.Equal(1, result3);
            Assert.Equal(2, result4);
            Assert.Equal(2, result5);
        }
    }
}