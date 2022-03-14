using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class SubarraySumCountTests
    {
        [Fact]
        public void Try_Execute_SubarraySumCount()
        {
            // Arrange
            var array1 = new int[] {10, 2, -2, -20, 10};
            var k1 = -10;
            var output1 = 3;

            var array2 = new int[] {9, 4, 20, 3, 10, 5};
            var k2 = 33;
            var output2 = 2;
            // Action
            var testCount1 = SubarraySumEqualsK.GetCumulativeSumCount(array1, k1);
            var testCount2 = SubarraySumEqualsK.GetCumulativeSumCount(array2, k2);
            // Assert
            Assert.Equal(output1, testCount1);
            Assert.Equal(output2, testCount2);
        }
    }
}