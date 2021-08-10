using System.Collections.Generic;
using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class CyclicSortTests
    {
        [Fact]
        public void Find_Disappeared_Numbers()
        {
            // Arrange
            var list1 = new List<int> { 4, 3, 2, 7, 8, 2, 3, 1 };
            var list2 = new List<int> { 1, 1 };
            // Act
            var result1 = CyclicSort.FindDisappearedNumbers(list1);
            var result2 = CyclicSort.FindDisappearedNumbers(list2);
            // Assert
            var extended1 = new List<int> {5, 6};
            Assert.Equal(extended1, result1);
            var extended2 = new List<int> { 2 };
            Assert.Equal(extended2, result2);
        }
    }
}