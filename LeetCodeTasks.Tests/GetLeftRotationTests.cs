using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class GetLeftRotationTests
    {
        [Fact]
        public void Try_Execute_LeftRotation()
        {
            // Arrange
            var array = new int[] {1, 2, 3, 4, 5};
            // Act
            var newArray1 = ArrayLeftRotation.GetLeftRotation(array, 4);
            var newArray2 = ArrayLeftRotation.GetLeftRotation(array, 2);
            // Assert
            var tryArray1 = new int[] {5, 1, 2, 3, 4};
            var tryArray2 = new int[]  {3, 4, 5, 1, 2};
            Assert.Equal(tryArray1, newArray1);
            Assert.Equal(tryArray2, newArray2);
        }
    }
}