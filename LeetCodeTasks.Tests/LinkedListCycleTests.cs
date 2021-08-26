using LeetCodeTasks.Library.LinkedListCycle;
using Xunit;

namespace LeetCodeTasks.Tests
{
    public class LinkedListCycleTests
    {
        [Fact]
        public void Linked_List_Has_Cycle()
        {
            // Arrange
            var linkedList = new LinkedList<int>();
            // Act
            linkedList.AppendLast(new Node<int>(10));
            linkedList.AppendLast(new Node<int>(20));
            linkedList.AppendLast(new Node<int>(30));
            var cycle = new Node<int>(40);
            linkedList.AppendLast(cycle);
            linkedList.AppendLast(new Node<int>(60));
            linkedList.AppendLast(cycle);
            // Assert
            Assert.True(linkedList.IsCycle());
        }
    }
}