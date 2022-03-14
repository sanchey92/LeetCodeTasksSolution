using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class MakingAnagramsTests
    {
        [Fact]
        public void Try_Execute_Making_Anagrams()
        {
            // Arrange
            const string string1 = "cde";
            const string string2 = "abc";
            const int output1 = 4;
            // Act
            var result = MakingAnagrams.GetMakingAnagrams(string1, string2);
            // Assert
            Assert.Equal(output1, result);
        }
    }
}