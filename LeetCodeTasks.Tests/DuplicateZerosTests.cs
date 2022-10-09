using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class DuplicateZerosTests
    {
        [Fact]
        public void Check_Solution()
        {
            var input1 = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };
            var input2 = new[] { 1, 2, 3 };
            
            var output1 = new[] { 1, 0, 0, 2, 3, 0, 0, 4 };
            var output2 = new[] { 1, 2, 3 };

            DuplicateZeros.AddZeros(input1);
            DuplicateZeros.AddZeros(input2);
            
            Assert.Equal(input1, output1);
            Assert.Equal(input2, output2);
        }
    }
}