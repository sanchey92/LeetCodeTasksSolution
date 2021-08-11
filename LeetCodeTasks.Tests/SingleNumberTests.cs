using System.Collections.Generic;
using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class SingleNumberTests
    {
        [Fact]
        public void Search_Single_Number()
        {
            // Arrange
            var list1 = new List<int> { 2, 2, 1 }; // 1
            var list2 = new List<int> { 4, 1, 2, 1, 2 }; // 4
            var list3 = new List<int> { 1 }; // 1
            // Act
            var result1 = SingleNumber.SearchSingeNumber(list1);
            var result2 = SingleNumber.SearchSingeNumber(list2);
            var result3 = SingleNumber.SearchSingeNumber(list3);
            // Assert
            Assert.Equal(1, result1);
            Assert.Equal(4, result2);
            Assert.Equal(1, result3);
        }
    }
}