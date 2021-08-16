using System.Collections.Generic;
using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class MaxProfitTests
    {
        [Fact]
        public void Find_Max_Profit()
        {
            // Arrange
            var prices1 = new List<int> { 7, 1, 5, 3, 6, 4 }; //5
            var prices2 = new List<int> { 7, 6, 4, 3, 1 }; //0
            
            // Act
            var result1 = MaxProfit.FindMaxProfit(prices1);
            var result2 = MaxProfit.FindMaxProfit(prices2);
            
            // Assert
            Assert.Equal(5, result1);
            Assert.Equal(0, result2);
        }
    }
}