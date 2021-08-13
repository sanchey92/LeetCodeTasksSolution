using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class ClimbingStairsTests
    {
        [Fact]
        public void SearchClimbingStairs()
        {
            // Arrange
            var n1 = 2;
            var n2 = 3;
            
            // Act
            var result1 = ClimbingStairs.FindClimbingStairs(n1);
            var result2 = ClimbingStairs.FindClimbingStairs(n2);
            
            // Assert
            Assert.Equal(2, result1);
            Assert.Equal(3, result2);
        }
    }
}