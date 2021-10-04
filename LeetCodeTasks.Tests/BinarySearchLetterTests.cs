using LeetCodeTasks.Library;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class BinarySearchLetterTests
    {
        [Fact]
        public void Find_next_Greatest_Letter()
        {
            // Arrange
            var letters = new char[] { 'c', 'f', 'j' }; //target = a, c, d, g, j
            // Act
            var result1 = BinarySearchLetter.NextGreatestLetter(letters, 'a'); // c
            var result2 = BinarySearchLetter.NextGreatestLetter(letters, 'c'); // f
            var result3 = BinarySearchLetter.NextGreatestLetter(letters, 'd'); // f
            var result4 = BinarySearchLetter.NextGreatestLetter(letters, 'g'); // j
            var result5 = BinarySearchLetter.NextGreatestLetter(letters, 'j'); // c
            // Assert
            Assert.Equal('c', result1);
            Assert.Equal('f', result2);
            Assert.Equal('f', result3);
            Assert.Equal('j', result4);
            Assert.Equal('c', result5);
        }
    }
}