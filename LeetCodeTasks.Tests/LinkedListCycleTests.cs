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
            linkedList.AppendLast(new Node<int>(10));
            linkedList.AppendLast(new Node<int>(20));
            linkedList.AppendLast(new Node<int>(30));
            // Act
            var cycle = new Node<int>(40);
            linkedList.AppendLast(cycle);
            linkedList.AppendLast(new Node<int>(60));
            linkedList.AppendLast(cycle);
            // Assert
            Assert.True(linkedList.IsCycle());
        }

        [Fact]
        public void Linked_List_Middle_Node()
        {
            // Arrange 
            var linkedList = new LinkedList<int>();
            linkedList.AppendLast(new Node<int>(1));
            linkedList.AppendLast(new Node<int>(2));
            linkedList.AppendLast(new Node<int>(3));
            linkedList.AppendLast(new Node<int>(4));
            linkedList.AppendLast(new Node<int>(5));
            // Act
            var result = linkedList.FindMiddleNode();
            // Assert
            var middleNode = new Node<int>(3);
            Assert.Equal(result.Value, middleNode.Value);
        }
    }
}